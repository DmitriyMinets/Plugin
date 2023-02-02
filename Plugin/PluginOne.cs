using System.Threading.Channels;

namespace Plugin
{
    public class PluginOne
    {
        public  void RunLogic(string message) 
        {
            Console.WriteLine(message);
        }
    }
}