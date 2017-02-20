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
            pc.Add(new ClassLib.ClassLib("HP", 123) { });
            pc.Add(new ClassLib.ClassLib("aser", 321) { });
            pc.Add(new ClassLib.ClassLib("asus", 444) { });
            pc.Add(new ClassLib.ClassLib("apple", 333) { });
            pc.Add(new ClassLib.ClassLib("Xiaomi", 222) { });
            pc.Add(new ClassLib.ClassLib("Microsoft", 111) { });
            Console.WriteLine("До serialize");
            foreach (ClassLib.ClassLib aPC in pc)
                {
                    Console.WriteLine("Марка - {0} \t Серийный номер - {1}", aPC.marka, aPC.Snumber);
                }

            string dir = @"C:\Users\Vadzim_Pliauho\Desktop\LB9\lb9\lb9\bin\Debug";
            string serializationFile = Path.Combine(dir, "listSerial.txt");
            SaveBinaryFormat(pc, serializationFile);
            Console.ReadKey();




        }

        private static void SaveBinaryFormat(object objGraph, string fileName)
        {
            //serialize
            using (Stream stream = File.Open(fileName, FileMode.Create))
            {
                var bformatter = new BinaryFormatter();

                bformatter.Serialize(stream, fileName);
            }


            //var binFormat = new BinaryFormatter();
            //using (Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
            //{
            //    binFormat.Serialize(fStream, objGraph);
            //}
            Console.WriteLine("--> Сохранение объекта в Binary format");
           
        }
    }
}
