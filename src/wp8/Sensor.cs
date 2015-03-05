using WPCordovaClassLib.Cordova.JSON;

namespace WPCordovaClassLib.Cordova.Commands
{
    public class Sensor : BaseCommand
    {
        public void getMinInterval(string args)
        {
            string message = "42";
            PluginResult result = new PluginResult(PluginResult.Status.OK, message);
            DispatchCommandResult(result);
        }
        public void getData(string args)
        {
            string message = "nice:42:fuck:you";
            PluginResult result = new PluginResult(PluginResult.Status.OK, message);
            DispatchCommandResult(result);
        }
    }
}
