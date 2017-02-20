using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace DeserializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string dir = @"C:\Users\Vadzim_Pliauho\Desktop\LB9\lb9\lb9\bin\Debug";
                string serializationFile = Path.Combine(dir, "listSerial.txt");
                ..Console.WriteLine(File.Exists(serializationFile) ? "File с таким именем найден, будет произведена deserialize." : "File с таким именем не найдено");
                //deserialize
                using (FileStream stream2 = new FileStream(serializationFile, FileMode.Open, FileAccess.Read))
                {
                    var bformatter = new BinaryFormatter();

                    //object obj = bformatter.Deserialize(stream);
                    //var objects = obj as List<object>;

                    List<ClassLib.ClassLib> pc2 = (List<ClassLib.ClassLib>)bformatter.Deserialize(stream2);
                    Console.WriteLine();
                    Console.WriteLine("После deserialize");
                    stream2.Close();
                    foreach (ClassLib.ClassLib aPC in pc2)
                    {
                        Console.WriteLine("Марка - {0} \t Серийный номер - {1}", aPC.marka, aPC.Snumber);
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("Файл по указанному пути - {0} не найден", e.FileName);
            }
        }
    }
}
