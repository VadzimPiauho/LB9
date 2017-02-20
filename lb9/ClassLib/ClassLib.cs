using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    [Serializable]
    public class ClassLib 
    {
        public string marka
        {
            get;
            set;
        }
        public int Snumber
        {
            get;
            set;
        }
        public bool power
        {
            get;
            set;
        }
        public ClassLib()
        {

        }

        public ClassLib(string marka, int Snumber, bool power)
        {
            this.marka = marka;
            this.Snumber = Snumber;
            this.power = false;
        }        

        public void PowerOnOff()
        {
            if (power==false)
            {
                power = true;
                Console.WriteLine("ПК вкл");
            }
            else
            {
                power = false;
                Console.WriteLine("ПК выкл");
            }
        }
        public void PowerReset()
        {
            if (power == false)
            {               
                Console.WriteLine("ПК выключен. Перезагрзка не работает");
            }
            else
            {
                power = false;
                Console.WriteLine("ПК выкл");
                power = true;
                Console.WriteLine("ПК вкл");
            }
        }
        //public ClassLib(SerializationInfo sInfo, StreamingContext contextArg)
        //{
        //    this.marka = (List<Student>)sInfo.GetValue("marka", typeof(List<Student>));
        //    this.students = (List<Student>)sInfo.GetValue("Students", typeof(List<Student>));
        //}
        //public void GetObjectData(SerializationInfo info, StreamingContext context)
        //{
        //    info.AddValue("marka", this.marka);
        //    info.AddValue("Snumber", this.Snumber);
        //}
    }
}
