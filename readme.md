# Edge Gateway for PurpleAir PA-II to Azure IoT Hub

This repository contains a simple HTTP-MQTT gateway that can be used with any [PurpleAir PA-II](https://www2.purpleair.com/collections/air-quality-sensors/products/purpleair-pa-ii) air quality sensor to filter and send data on to an [Azure IoT Hub](https://docs.microsoft.com/azure/iot-hub/) instance.

While the PurpleAir devices have pre-configured (if undocumented) support for Azure IoT Hub, I was unable to get this functioning, so decided to go ahead an build this solution.

In order to build and run locally you will need the [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0), [VS Code](https://code.visualstudio.com/Download) and [Docker](https://www.docker.com/products/docker-desktop) (Community/Desktop Edition is fine).

> Note: this repository is not affiliated with, or maintained by, PurpleAir or Microsoft.