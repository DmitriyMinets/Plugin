using Plugin;
namespace ConsoleApp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            PluginOne plugin = new PluginOne();
            plugin.RunLogic("Метод библиотеки Plugin, PluginOne");
        }
    }
}