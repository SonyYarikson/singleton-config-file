using System;
using System.IO;

namespace Config_class
{
    public class Singleton
    {
        private static Singleton uniqueinstance;
        public static string data = "";
        private static string GetConfigurationKey(string path)
        {
            if (File.Exists(path) == true)
            {
                data = File.ReadAllText(path);
                return data;
            }
            else Console.WriteLine("Нет конфиругационого файла");
            return default;
        }
        public static Singleton GetInstance(string path)
        {
            if (uniqueinstance == null)
            {
                uniqueinstance = new Singleton();
                GetConfigurationKey(path);
            }
            GetConfigurationKey(path);
            return uniqueinstance;
        }
    }
}
