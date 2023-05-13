using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace listener
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var path = "C:\\Users\\yaros\\OneDrive\\Рабочий стол\\прикладное\\singleton-config-file\\json.txt";
            var jsontext = File.ReadAllText(path);           
            Listener listener = new Listener();
            do
            {
                if (File.GetLastWriteTime(path) == DateTime.Now) { 
                    var json = JsonSerializer.Deserialize<string>(jsontext);
                    listener.update(json);
                }
            } while (true);
        }
    }
}
