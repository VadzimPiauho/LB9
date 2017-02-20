using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLib
{
    public class ClassLib
    {
        public string marka { get; set; }
        public int Snumber { get; set; }
        public bool power { get; set; }

        public ClassLib(string marka, int Snumber)
        {
            this.marka = marka;
            this.Snumber = Snumber;
            this.power = false;
        }

        public ClassLib()
        {
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

    }
}
