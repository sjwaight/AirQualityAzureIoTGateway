namespace Pasgateway.Controllers;

    using System.Text;
    using System.Text.Json;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.Devices.Client;
    using Pasgateway.Models;
    using Pasgateway.ClientSingleton;

    [ApiController]
    [Route("[controller]")]
    public class SensorReadingController : ControllerBase
    {
        private readonly ILogger<SensorReadingController> logger;
        private readonly IDeviceClientHost deviceClientHost;
        private readonly string accessKey;
        private readonly string allowedClient;
        private readonly int skipEventCount;
        private int currentEventCount = 0;
        private readonly IConfiguration config;    
        
        public SensorReadingController(ILogger<SensorReadingController> loggerInstance, IConfiguration configuration, IDeviceClientHost clientHost)
        {
            config = configuration;
            logger = loggerInstance;

            accessKey = config["API_ACCESS_KEY"];
            allowedClient = config["ALLOWED_SENSOR_ID"];

            Int32.TryParse(config["SKIP_EVENT_COUNT"], out skipEventCount);

            deviceClientHost = clientHost;
        }

        [HttpPost]
        public async Task<IActionResult> Post(SensorData data)
        {
            // Check that the calling host is allowed. Request should include a HTTP header with an Access Key 
            // and the Sensor ID (effectively it's MAC Address) should match what we have configured
            if((!Request.Headers.ContainsKey("AccessKey")) || 
                (Request.Headers["AccessKey"] != accessKey) ||
                (allowedClient != data.SensorId))
            {
                logger.LogWarning($"Unauthorised call to the API from host {HttpContext.Connection.RemoteIpAddress}");
                return Unauthorized();
            }

            // if we want to filter how many messages we send to Azure we check here.
            // if skipMessageCount is set to 0 then we don't run this logic.
            if(skipEventCount != 0 && currentEventCount == skipEventCount)
            {
                logger.LogInformation("Resetting message skipped count to 0");
                currentEventCount = 0;
                return Ok();
            }

            try 
            {
                // Sensor temperature is in Fahrenheit
                double tempCelsius = (data.CurrentTempFahrenheit - 32) * 5 / 9;

                // Create JSON message
                string messageBody = JsonSerializer.Serialize(
                            new
                            {
                                name = data.SensorName,
                                #pragma warning disable CS8604 // Nullable warning
                                readtime = DateTime.Parse(data.ReadingTime),
                                #pragma warning restore CS8604 
                                latitude = data.Latitude,
                                longitude = data.Longitude,
                                temperature = tempCelsius,
                                humidity = data.CurrentHumidityPercentage,
                                pressure = data.PressureMillibars,
                                pm25atma = data.Pm25Atm_ChannelA,
                                pm25atmb = data.Pm25Atm_ChannelB,
                                pm100atma = data.Pm100Atm_ChannelA,
                                pm100atmb = data.Pm100Atm_ChannelB
                            });
                
                using var message = new Message(Encoding.ASCII.GetBytes(messageBody))
                {
                    ContentType = "application/json",
                    ContentEncoding = "utf-8",
                };

                logger.LogInformation($"SensorId: {data.SensorId} | Name: {data.SensorName} | Temp (C): {tempCelsius}");

                // Send the telemetry message to Azure IoT Hub
                await deviceClientHost.Instance.SendEventAsync(message);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, $"Failed to send message to Azure IoT Hub. Reason: {ex.Message}");
            }

            if(skipEventCount != 0)
                currentEventCount++;

            return Ok();
        }
}