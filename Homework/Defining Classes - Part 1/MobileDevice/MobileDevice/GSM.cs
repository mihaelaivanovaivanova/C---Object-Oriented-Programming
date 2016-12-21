using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileDevice
{
    class GSM
    {
        private string model;
        private string manifacturer;
        private double price;
        private string owner;
        private Battery battery;
        private Display display;
        private List<Calls> callHistory = new List<Calls>();
        internal static GSM IPhone4S = new GSM
            (
             "iPhone 4S",
             "Apple",
             786,
             "Misha",
             new Battery(BatteryType.LiIon, 76, 51),
             new Display(12, 16000000)
            );

        public GSM(string model, string manifacturer)
        {
            this.model = model;
            this.manifacturer = manifacturer;

        }

        public GSM(string model, string manufacturer, double price) : this(model, manufacturer)
        {
            this.Price = price;

        }

        public GSM(string model, string manufacturer, double price, string owner) : this(model, manufacturer, price)
        {
            this.Owner = owner;

        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery) : this(model, manufacturer, price,owner)
        {
            this.battery = battery;

        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display) : this(model, manufacturer, price, owner,battery)
        {
            this.display = display;

        }

        public string Model
        {
            get
            {
                return this.model;
            }
        }

        public string Manifacturer
        {
            get
            {
                return this.manifacturer;
            }
        }


        public double Price
        {
            get
            {
                return this.price;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Price must have a positive value!");
                }
                else
                {
                    this.price = value;
                }
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            private set
            {
                this.owner = value;
            }
        }

        public Battery Battery
        {
            get
            {
                return this.battery;
            }
        }

        public Display Display
        {
            get
            {
                return this.display;
            }
        }

        public List<Calls> CallHistory
        {
            get
            {
                return this.callHistory;
            }
        }

        public void AddCall(Calls callToBeAdded)
        {
            this.callHistory.Add(callToBeAdded);
        }

        public void DeleteCall(Calls callToBeDeleted)
        {
            this.callHistory.Remove(callToBeDeleted);
        }

        public void ClearHistory()
        {
            this.callHistory.Clear();
        }

        public double CallPrice(double price)
        {
            double callDurationTotal = 0;
            foreach (Calls call in callHistory)
            {
                callDurationTotal += call.Duration;
            }
            double totalPrice = callDurationTotal*price/60;
            return totalPrice;
        }


        public override string ToString()
        {
            StringBuilder print = new StringBuilder();
            print.Append($"Model: {this.model}");
            print.Append("\n");
            print.Append($"Manifacturer: {this.manifacturer}");
            print.Append("\n");

            if (this.price > 0)
            {
                print.Append($"Price: {this.price:F2} BGN");
            }
            else
            {
                print.Append($"Price: No information");
            }

            print.Append("\n");

            if (this.owner.Length > 0)
            {
                print.Append($"Owner: {this.owner}");
            }
            else
            {
                print.Append($"Owner: No information");
            }

            print.Append("\n");

            if (this.battery != null)
            {
                print.Append($"Battery Type: {this.battery.BatteryType}");
                print.Append("\n");
                print.Append($"Battery Hours Idle: {this.battery.HoursIdle}");
                print.Append("\n");
                print.Append($"Battery Hours Talk: {this.battery.HoursTalk}");

            }
            else
            {
                print.Append($"Battery: No information");
            }

            print.Append("\n");

            if (this.display != null)
            {
                print.Append($"Display size: {this.display.Size}");
            }
            else
            {
                print.Append($"Display size: No information");
            }

            print.Append("\n");

            if (this.display != null)
            {
                print.Append($"Display number of colors: {this.display.NumOfColors}");
            }
            else
            {
                print.Append($"Display number of colors: No information");
            }

            print.Append("\n");

            return print.ToString();
        }

    }


}
