
namespace Pasgateway.Models
{

    using System.Text.Json.Serialization;

    // Documentation reference: https://docs.google.com/document/d/15ijz94dXJ-YAZLi9iZ_RaBwrZ4KtYeCy08goGBwnbCU/edit
    public class SensorData
    {
        [JsonPropertyName("SensorId")]
        public string? SensorId { get; set; }

        [JsonPropertyName("DateTime")]
        public string? ReadingTime { get; set; }

        [JsonPropertyName("Geo")]
        public string? SensorName { get; set; }

        [JsonPropertyName("Mem")]
        public int Mem { get; set; }

        [JsonPropertyName("memfrag")]
        public int Memfrag { get; set; }

        [JsonPropertyName("memfb")]
        public int Memfb { get; set; }

        [JsonPropertyName("memcs")]
        public int Memcs { get; set; }

        [JsonPropertyName("Id")]
        public int Id { get; set; }

        [JsonPropertyName("lat")]
        public double Latitude { get; set; }

        [JsonPropertyName("lon")]
        public double Longitude { get; set; }

        [JsonPropertyName("Adc")]
        public double Adc { get; set; }

        [JsonPropertyName("loggingrate")]
        public int Loggingrate { get; set; }

        [JsonPropertyName("place")]
        public string? Place { get; set; }

        [JsonPropertyName("version")]
        public string? Version { get; set; }

        [JsonPropertyName("uptime")]
        public int Uptime { get; set; }

        [JsonPropertyName("rssi")]
        public int Rssi { get; set; }

        [JsonPropertyName("period")]
        public int Period { get; set; }

        [JsonPropertyName("httpsuccess")]
        public int Httpsuccess { get; set; }

        [JsonPropertyName("httpsends")]
        public int Httpsends { get; set; }

        [JsonPropertyName("hardwareversion")]
        public string? Hardwareversion { get; set; }

        [JsonPropertyName("hardwarediscovered")]
        public string? Hardwarediscovered { get; set; }

        [JsonPropertyName("current_temp_f")]
        public int CurrentTempFahrenheit { get; set; }

        [JsonPropertyName("current_humidity")]
        public int CurrentHumidityPercentage { get; set; }

        [JsonPropertyName("current_dewpoint_f")]
        public int CurrentDewpointFahrenheit { get; set; }

        [JsonPropertyName("pressure")]
        public double PressureMillibars { get; set; }

        [JsonPropertyName("p25aqic_b")]
        public string? P25aqic_ChannelB { get; set; }

        [JsonPropertyName("pm2.5_aqi_b")]
        public int Pm25Aqi_ChannelB { get; set; }

        [JsonPropertyName("pm1_0_cf_1_b")]
        public double Pm10Cf1_ChannelB { get; set; }

        [JsonPropertyName("p_0_3_um_b")]
        public double P03Um_ChannelB { get; set; }

        [JsonPropertyName("pm2_5_cf_1_b")]
        public double Pm25Cf1_ChannelB { get; set; }

        [JsonPropertyName("p_0_5_um_b")]
        public double P05Um_ChannelB { get; set; }

        [JsonPropertyName("pm10_0_cf_1_b")]
        public double Pm100Cf1_ChannelB { get; set; }

        [JsonPropertyName("p_1_0_um_b")]
        public double P10Um_ChannelB { get; set; }

        [JsonPropertyName("pm1_0_atm_b")]
        public double Pm10Atm_ChannelB { get; set; }

        [JsonPropertyName("p_2_5_um_b")]
        public double P25Um_ChannelB { get; set; }

        [JsonPropertyName("pm2_5_atm_b")]
        public double Pm25Atm_ChannelB { get; set; }

        [JsonPropertyName("p_5_0_um_b")]
        public double P50Um_ChannelB { get; set; }

        [JsonPropertyName("pm10_0_atm_b")]
        public double Pm100Atm_ChannelB { get; set; }

        [JsonPropertyName("p_10_0_um_b")]
        public double P100Um_ChannelB { get; set; }

        [JsonPropertyName("p25aqic")]
        public string? P25aqic_ChannelA { get; set; }

        [JsonPropertyName("pm2.5_aqi")]
        public int Pm25Aqi_ChannelA { get; set; }

        [JsonPropertyName("pm1_0_cf_1")]
        public double Pm10Cf1_ChannelA { get; set; }

        [JsonPropertyName("p_0_3_um")]
        public double P03Um_ChannelA { get; set; }

        [JsonPropertyName("pm2_5_cf_1")]
        public double Pm25Cf1_ChannelA { get; set; }

        [JsonPropertyName("p_0_5_um")]
        public double P05Um_ChannelA { get; set; }

        [JsonPropertyName("pm10_0_cf_1")]
        public double Pm100Cf1_ChannelA { get; set; }

        [JsonPropertyName("p_1_0_um")]
        public double P10Um_ChannelA { get; set; }

        [JsonPropertyName("pm1_0_atm")]
        public double Pm10Atm_ChannelA { get; set; }

        [JsonPropertyName("p_2_5_um")]
        public double P25Um_ChannelA { get; set; }

        [JsonPropertyName("pm2_5_atm")]
        public double Pm25Atm_ChannelA { get; set; }

        [JsonPropertyName("p_5_0_um")]
        public double P50Um_ChannelA { get; set; }

        [JsonPropertyName("pm10_0_atm")]
        public double Pm100Atm_ChannelA { get; set; }

        [JsonPropertyName("p_10_0_um")]
        public double P100Um_ChannelA { get; set; }

        [JsonPropertyName("pa_latency")]
        public int PaLatency { get; set; }

        [JsonPropertyName("response")]
        public int Response { get; set; }

        [JsonPropertyName("response_date")]
        public int ResponseDate { get; set; }

        [JsonPropertyName("latency")]
        public int Latency { get; set; }

        [JsonPropertyName("key1_response")]
        public int Key1Response { get; set; }

        [JsonPropertyName("key1_response_date")]
        public int Key1ResponseDate { get; set; }

        [JsonPropertyName("key1_count")]
        public int Key1Count { get; set; }

        [JsonPropertyName("ts_latency")]
        public int TsLatency { get; set; }

        [JsonPropertyName("key2_response")]
        public int Key2Response { get; set; }

        [JsonPropertyName("key2_response_date")]
        public int Key2ResponseDate { get; set; }

        [JsonPropertyName("key2_count")]
        public int Key2Count { get; set; }

        [JsonPropertyName("ts_s_latency")]
        public int TsSLatency { get; set; }

        [JsonPropertyName("response_b")]
        public int ResponseB { get; set; }

        [JsonPropertyName("response_date_b")]
        public int ResponseDateB { get; set; }

        [JsonPropertyName("latency_b")]
        public int LatencyB { get; set; }

        [JsonPropertyName("key1_response_b")]
        public int Key1ResponseB { get; set; }

        [JsonPropertyName("key1_response_date_b")]
        public int Key1ResponseDateB { get; set; }

        [JsonPropertyName("key1_count_b")]
        public int Key1CountB { get; set; }

        [JsonPropertyName("ts_latency_b")]
        public int TsLatencyB { get; set; }

        [JsonPropertyName("key2_response_b")]
        public int Key2ResponseB { get; set; }

        [JsonPropertyName("key2_response_date_b")]
        public int Key2ResponseDateB { get; set; }

        [JsonPropertyName("key2_count_b")]
        public int Key2CountB { get; set; }

        [JsonPropertyName("ts_s_latency_b")]
        public int TsSLatencyB { get; set; }

        [JsonPropertyName("wlstate")]
        public string? Wlstate { get; set; }

        [JsonPropertyName("status_0")]
        public int Status0 { get; set; }

        [JsonPropertyName("status_1")]
        public int Status1 { get; set; }

        [JsonPropertyName("status_2")]
        public int Status2 { get; set; }

        [JsonPropertyName("status_3")]
        public int Status3 { get; set; }

        [JsonPropertyName("status_4")]
        public int Status4 { get; set; }

        [JsonPropertyName("status_5")]
        public int Status5 { get; set; }

        [JsonPropertyName("status_6")]
        public int Status6 { get; set; }

        [JsonPropertyName("status_7")]
        public int Status7 { get; set; }

        [JsonPropertyName("status_8")]
        public int Status8 { get; set; }

        [JsonPropertyName("status_9")]
        public int Status9 { get; set; }

        [JsonPropertyName("status_10")]
        public int Status10 { get; set; }
    }

}