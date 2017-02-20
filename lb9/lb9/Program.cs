using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;



namespace SerializConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List < ClassLib.ClassLib > pc = new List<ClassLib.ClassLib>();
            pc.Add(new ClassLib.ClassLib("HP", 123,false) { });
            pc.Add(new ClassLib.ClassLib("aser", 321, false) { });
            pc.Add(new ClassLib.ClassLib("asus", 444, false) { });
            pc.Add(new ClassLib.ClassLib("apple", 333, false) { });
            pc.Add(new ClassLib.ClassLib("Xiaomi", 222, false) { });
            pc.Add(new ClassLib.ClassLib("Microsoft", 111, false) { });
            Console.WriteLine("До serialize");
            foreach (ClassLib.ClassLib aPC in pc)
                {
                    Console.WriteLine("Марка - {0} \t Серийный номер - {1}", aPC.marka, aPC.Snumber);
                }

            string dir = @"C:\Users\Vadzim_Pliauho\Desktop\LB9\lb9\lb9\bin\Debug";
            string serializationFile = Path.Combine(dir, "listSerial.txt");
            SaveBinaryFormat(serializationFile, pc);
            Console.ReadKey();

        }

        private static void SaveBinaryFormat(string fileName, object objGraph)
        {
            //serialize
            using (FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write))
            {
                var bformatter = new BinaryFormatter();

                bformatter.Serialize(stream, objGraph);
                stream.Close();
            }
            Console.WriteLine("--> Сохранение объекта в Binary format");
        }
    }
}
