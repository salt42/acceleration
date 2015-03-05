using WP7CordovaClassLib.Cordova;
using WP7CordovaClassLib.Cordova.Commands;
using WP7CordovaClassLib.Cordova.JSON;
using Microsoft.Devices.Sensors;

namespace Cordova.Extension.Commands
{
    public class Acceleration : BaseCommand
    {
        private Accelerometer sensor;
        public Acceleration()
        {
            sensor = new Accelerometer();
        }
        public void getMax(string args)
        {
            string name = JsonHelper.Deserialize<string>(args);
            string message = "Hello, " + name;
            PluginResult result = new PluginResult(PluginResult.Status.OK, message);
            DispatchCommandResult(result);
        }
    }
}
