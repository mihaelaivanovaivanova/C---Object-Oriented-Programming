using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    public delegate void TimerMethod();
   public class Timer
    {
        private double seconds;

        public Timer(double seconds, TimerMethod action)
        {
            this.Seconds = seconds;
            this.Action = action;
        }

        public double Seconds
        {
            get
            {
                return this.seconds;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("The value for seconds must be a postive number!");
                }
                this.seconds = value*1000;
            }
        }

        public TimerMethod Action { get; set; }


        public void Run()
        {
            while (true)
            {
                Thread.Sleep((int)this.seconds);
                this.Action();
            }
        }
    }
}
