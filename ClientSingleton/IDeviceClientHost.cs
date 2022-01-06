namespace Pasgateway.ClientSingleton
{
    using Microsoft.Azure.Devices.Client;
    
    public interface IDeviceClientHost
    {
        DeviceClient Instance { get; }
    }
}