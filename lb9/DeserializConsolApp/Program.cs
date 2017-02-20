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
            string dir = @"C:\Users\Vadzim_Pliauho\Desktop\LB9\lb9\lb9\bin\Debug";
            string serializationFile = Path.Combine(dir, "listSerial.txt");
            //deserialize
            using (Stream stream = File.Open(serializationFile, FileMode.Open))
            {
                var bformatter = new BinaryFormatter();

                List<ClassLib.ClassLib> pc = (List<ClassLib.ClassLib>)bformatter.Deserialize(stream);
                Console.WriteLine();
                Console.WriteLine("После deserialize");
                foreach (ClassLib.ClassLib aPC in pc)
                {
                    Console.WriteLine("Марка - {0} \t Серийный номер - {1}", aPC.marka, aPC.Snumber);
                }
            }
        }
    }
}
