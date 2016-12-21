using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class Battery
    {
        private BatteryType batteryType;
        private int? hoursIdle = null;
        private int? hoursTalk = null;

        public Battery(BatteryType batteryType)
        {
            this.BatteryType =batteryType;
        }

        public Battery(BatteryType batteryType, int? hoursIdle) : this(batteryType)
        {
            this.HoursIdle = hoursIdle;
        }

        public Battery(BatteryType batteryType, int? hoursIdle, int? hoursTalk) : this(batteryType, hoursIdle)
        {
            this.HoursTalk = hoursTalk;
        }

        public int? HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("HoursIdle must be a positive number!");
                }
                else
                {
                    this.hoursIdle = value;
                }
            }
        }

        public int? HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("HoursTalk must be a positive number!");
                }
                else
                {
                    this.hoursTalk = value;
                }
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }
    }
}
