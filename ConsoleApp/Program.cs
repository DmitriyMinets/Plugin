using System.Runtime.Loader;

namespace ConsoleApp;

internal class Program
{
    private static void Main()
    {
        var path = @"C:\Users\dotad\source\repos\Plugin\Plugin\bin\Debug\net6.0\Plugin.dll";

        var assembly = AssemblyLoadContext.Default.LoadFromAssemblyPath(path);

        var modul = assembly.GetModule("Plugin.dll");

        var type = modul.GetType("Plugin.Plugin");

        var method = type.GetMethod("RunLogic");

        var classInstance = Activator.CreateInstance(type, null);
        method.Invoke(classInstance, null);
    }
}