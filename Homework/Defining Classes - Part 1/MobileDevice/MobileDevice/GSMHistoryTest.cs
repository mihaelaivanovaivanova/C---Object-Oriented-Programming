using System;

namespace MobileDevice
{
    class CallHistoryTest
    {
        private GSM testGSM = new GSM("3310", "Nokia", 50, "Gosho", new Battery(BatteryType.NiCd, 160, 140), new Display(2, 2));
        public void func()
        {
            testGSM.AddCall(new Calls(new DateTime(2016, 06, 14, 16, 38, 42), "0885 408 298", 123));
            testGSM.AddCall(new Calls(new DateTime(2016, 06, 14, 17, 04, 13), "0899 349 657", 496));
            testGSM.AddCall(new Calls(new DateTime(2016, 06, 15, 03, 21, 28), "0874 521 999", 218));
            testGSM.AddCall(new Calls(new DateTime(2016, 06, 15, 07, 01, 14), "0874 521 999", 69));

            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                Console.WriteLine("{0} {1} {2}", testGSM.CallHistory[i].Date, testGSM.CallHistory[i].Time, testGSM.CallHistory[i].Duration);
            }

            double totalPrice = testGSM.CallPrice(0.37);
            Console.WriteLine($"Calls total price {totalPrice:F2}");
            Calls longestCall = testGSM.CallHistory[0];

            for (int i = 0; i < testGSM.CallHistory.Count; i++)
            {
                if (testGSM.CallHistory[i].Duration > longestCall.Duration)
                {
                    longestCall = testGSM.CallHistory[i];
                }
            }

            testGSM.CallHistory.Remove(longestCall);
            double newTotalPrice = testGSM.CallPrice(0.37);
            Console.WriteLine($"Calls new total price {newTotalPrice:F2}");
            testGSM.CallHistory.Clear();
            if (testGSM.CallHistory.Count == 0)
            {
                Console.WriteLine("No calls in history");
            }
            else
            {
                for (int i = 0; i < testGSM.CallHistory.Count; i++)
                {
                    Console.WriteLine("{0} {1} {2}", testGSM.CallHistory[i].Date, testGSM.CallHistory[i].Time, testGSM.CallHistory[i].Duration);
                }
            }
        }
    }
}
