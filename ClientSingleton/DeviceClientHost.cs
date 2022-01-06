
namespace Pasgateway.ClientSingleton
{
    using Microsoft.Azure.Devices.Client;

    public class DeviceClientHost : IDeviceClientHost {

        private readonly DeviceClient instance;

        public DeviceClientHost(IConfiguration configuration)
        {
            var connectionString = configuration["IOTHUB_DEVICE_CONNECTION_STRING"];
            instance = DeviceClient.CreateFromConnectionString(connectionString, TransportType.Mqtt);
            instance.OperationTimeoutInMilliseconds = 5 * 60 * 1000; // 5 minutes
        }

        public DeviceClient Instance => instance;
    }
}