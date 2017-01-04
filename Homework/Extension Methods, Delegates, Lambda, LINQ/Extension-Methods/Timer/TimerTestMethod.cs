using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timer
{
    class TimerTestMethod
    {
        public static void Run()
        {
            TimerMethod testDelegate = TestMethod;
            testDelegate += AnotherTestMetod;
            testDelegate += delegate
            {
                Console.WriteLine("I am Anonimus Method" + "\r\n");
            };

            Timer testTimer = new Timer(2, testDelegate);
            testTimer.Run();
        }

        private static void TestMethod()
        {
            Console.WriteLine(DateTime.Now);
        }

        private static void AnotherTestMetod()
        {
            Console.WriteLine($"After 2 seconds");
        }
    }
}
