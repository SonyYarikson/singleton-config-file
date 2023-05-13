using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Config_class;


namespace singleton_config_file
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var content = "";
            var path = "C:\\Users\\yaros\\OneDrive\\Рабочий стол\\прикладное\\singleton-config-file\\json.txt";
            Console.WriteLine("Добавление строк в файл:");
            content = Console.ReadLine();
            Singleton.GetInstance("C:\\Users\\yaros\\OneDrive\\Рабочий стол\\прикладное\\singleton-config-file\\config.txt");
            File.AppendAllText(Singleton.data, content);
            var json = JsonSerializer.Serialize(File.ReadAllText(Singleton.data));
            File.WriteAllText(path, json);
        }
    }
}
