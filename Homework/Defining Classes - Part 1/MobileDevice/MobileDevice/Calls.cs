using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Calls
    {
        private DateTime date;
        private DateTime time;
        private string dialedNum;
        private long duration;

        public Calls(DateTime dateTime, string dialedNum, long duration)
        {
            this.Date = dateTime.ToShortDateString();
            this.Time = dateTime.ToShortTimeString();
            this.DialedNum = dialedNum;
            this.Duration = duration;
        }

        public String Date { get; private set; }
        public String Time { get; private set; }
        public string DialedNum { get; private set; }
        public long Duration { get; private set; }
    }
}
