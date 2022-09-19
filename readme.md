# Edge Gateway for PurpleAir PA-II to Azure IoT Hub

This repository contains a simple HTTP-MQTT gateway that can be used with any [PurpleAir PA-II](https://www2.purpleair.com/collections/air-quality-sensors/products/purpleair-pa-ii) air quality sensor to filter and send data on to an [Azure IoT Hub](https://docs.microsoft.com/azure/iot-hub/) instance.

While the PurpleAir devices have pre-configured (if undocumented) support for Azure IoT Hub, I was unable to get this functioning, so decided to go ahead an build this solution.

In order to build and run locally you will need the [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0), [VS Code](https://code.visualstudio.com/Download) and [Docker](https://www.docker.com/products/docker-desktop) (Community/Desktop Edition is fine).

The resulting Docker image is [published to Docker Hub](https://hub.docker.com/r/sjwaight/airsensorgateway) so it can easily be deployed to edge devices such as consumer NAS devices that support Docker.

> Note: this repository is not affiliated with, or maintained by, PurpleAir or Microsoft.

## Runtime Configuration

When you run the application it expects the following four configuration items.

- IOTHUB_DEVICE_CONNECTION_STRING: full connection string for the Azure IoT Hub instance you wish to publish events to. This can be obtained from the Device properties blade in the Azure Portal.
- API_ACCESS_KEY: a HTTP header key you will set on your PA-II device so that you can ensure only an authorised device can use your gateway. 
- ALLOWED_SENSOR_ID: the hostname of the Sensor that will be using the gateway. This will be in the format of a MAC address.
- SKIP_EVENT_COUNT: if you want to limit the number of events sent to Azure, you can tell the gateway to skip every X message. Set to 0 if you want to send all events.

You may choose to limit events sent even though a PA-II device will send total events that fit within the free tier of Azure IoT Hub in any given month. There may be other upstream services you want to use that have lower limits (for example, [Anomaly Detector](https://azure.microsoft.com/services/cognitive-services/anomaly-detector/)).
