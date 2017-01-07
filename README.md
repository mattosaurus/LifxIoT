# LifxIoT
.NET wrapper to control Lifx bulbs via their cloud API. This code is based on that created by Daniel Porry <a href="https://github.com/porrey/iot/tree/master/source/IoT%20Devices%20and%20Sensors/Porrey.Uwp.IoT.Devices.Lifx" alt="Porrey.Uwp.IoT.Devices.Lifx">here</a> with the only change here being that all await methods now have their continueOnCapturedContext property set to false so as to prevent the code hanging when deployed to a Raspberry Pi 3 running Windows IoT.

# Installation
To use LifxIoT in your C# project, you can either download the LifxIoT C# .NET libraries directly from the Github repository or, if you have the NuGet package manager installed, you can grab them automatically.

```
PM> Install-Package LifxIoT
```
Once you have the LifxIoT libraries properly referenced in your project, you can include calls to them in your code.

Add the following namespaces to use the library:

```C#
using LifxIoT.Api;
using LifxIoT.Models;
```
# Dependencies
A Lifx account (and bulbs) are required for use, an access token should be generated in the Lifx account.

# Usage
This is intended for usage in Windows IoT projects.

The below code in MainPage.xaml.cs lists all bulbs linked to the account.

```C#
        public MainPage()
        {
            this.InitializeComponent();

            LifxApi api = new LifxApi("YOUR_TOKEN_HERE");

            SelectorList selectors = new SelectorList();

            selectors.Add(LifxIoT.Models.Selector.All);

            IEnumerable<Light> lights = api.ListLights(selectors).Result;
        }
```
