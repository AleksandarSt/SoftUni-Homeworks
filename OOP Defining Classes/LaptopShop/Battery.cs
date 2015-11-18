using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LaptopShop
{
    class Battery
    {
        private string batteryType;
        private double batteryLife;

        #region Properties
        public string BatteryType
        {
            get { return this.batteryType; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(" Battery Type must not be empty or null");
                }
                this.batteryType = value;
            }
        }

        public double BatteryLife
        {
            get { return this.batteryLife; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("Battery Life must not be negative!");
                }
                this.batteryLife = value;
            }
        }
        #endregion
        public Battery(string batteryType,double batteryLife)
        {
            this.BatteryType = batteryType;
            this.BatteryLife = batteryLife;
        }

        public Battery()
            :this(null,0)
        {

        }
    }
}
