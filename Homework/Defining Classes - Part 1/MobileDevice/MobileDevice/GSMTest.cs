using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class GSMTest
    {
        internal GSM[] phones = 
            {
                new GSM ("Galaxy A5","Samsung",800, "Vesko", new Battery(BatteryType.NiMH,92,49), new Display(32000000,9)),
                new GSM("Galaxy Duo","Samsung",320, "Anna", new Battery(BatteryType.NiCd,47,22), new Display(2000000,6)),
                new GSM("Galaxy 5S","Samsung",320, "Anna"),
                new GSM("Chocolate", "LG",500, "Vicky",new Battery(BatteryType.LiIon,67,38))
        };

        public List<GSM> GetPhones()
        {
            List<GSM> phonesToGet = new List<GSM>();
            foreach(GSM phone in phones)
            {
                phonesToGet.Add(phone);
            }
            return phonesToGet;
        }

        public void DisplayPhoneInfo()
        {
            foreach(GSM phone in phones)
            {
                Console.WriteLine(phone.ToString());
            }
            Console.WriteLine(GSM.IPhone4S.ToString());
        }
    }
}
