using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Program
    {
        static void Main(string[] args)
        {
            GSMTest test = new GSMTest();
            test.DisplayPhoneInfo();

            var call = new Calls(new DateTime(2016, 03, 17, 14, 32, 03), "0884 365 781", 213);
            Console.WriteLine(call.ToString());
            var callTest = new CallHistoryTest();
            callTest.func();
        }
    }
}
