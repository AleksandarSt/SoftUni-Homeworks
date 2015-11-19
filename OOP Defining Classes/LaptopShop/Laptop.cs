using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LaptopShop
{
    class Laptop
    {
        private string model;
        private string manifacturer;
        private string processor;
        private int ram;
        private string gpu;
        private int hdd;
        private string screen;
        private Battery battery;
        private decimal price;

        #region Properties
		 
        public string Model
        {
            get { return this.model; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Model must note be empty or null!");
                }
                this.model = value;
            }
        }

        public string Manifacturer
        {
            get { return this.manifacturer; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Manifacturer must note be empty or null!");
                }
                this.manifacturer = value;
            }
        }

        public string Processor
        {
            get { return this.processor; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Processor must note be empty or null!");
                }
                this.processor = value;
            }
        }

        public int Ram
        {
            get { return this.ram; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("RAM value must not be negative!");
                }
                this.ram = value;
            }
        }

        public string Gpu
        {
            get { return this.gpu; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("GPU must note be empty or null!");
                }
                this.gpu = value;
            }
        }

        public int Hdd
        {
            get { return this.hdd; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("HDD value must not be negative!");
                }
                this.hdd = value;
            }
        }

        public string Screen
        {
            get { return this.screen; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Screen must note be empty or null!");
                }
                this.screen = value;
            }
        }

        public decimal Price
        {
            get { return this.price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price value must not be negative!");
                }
                this.price = value;
            }
        }

	    #endregion

        #region Constructors
        public Laptop (string model,string manifacturer,string processor, int ram,string gpu, int hdd, string screen, Battery battery, decimal price)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.Gpu = gpu;
            this.Hdd = hdd;
            this.Screen = screen;
            this.battery = battery;
            this.Price = price;
        }

        public Laptop(string model,decimal price)
            : this(model, null, null, 0, null, 0, null, new Battery(null, 0), price)
        {

        }

        public Laptop(string model, string manifacturer, string processor, int ram, string gpu, int hdd, string screen, decimal price)
            : this(model, manifacturer, processor, ram, gpu, hdd, screen, new Battery(null, 0), price)
        {

        }

        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format(
                "<Model:> {0} \n<Manifacturer:> {1} \n<Processor:> {2} \n<RAM:> {3} GB \n<Graphics card:> {4} \n<HDD:> {5} GB \n<Screen:> {6}" +
                " \n<Battery:> {7} \n<Battery Life:> {8:0.0} hours \n<Price:> {9:0.00} lv", this.model,this.manifacturer, this.processor,
                this.ram,this.gpu,this.hdd,this.screen,this.battery.BatteryType,this.battery.BatteryLife,this.price);
        }

        private static void Main()
        {
            Laptop firstLaptop = new Laptop
                (
                    "Lenovo Yoga 2 Pro",
                    "Lenovo",
                    "Intel Core i5-4210U (2-core, 1.70 - 2.70 GHz, 3MB cache)",
                    8,
                    "Intel HD Graphics 4400",
                    128,
                    "13.3\" (33.78 cm) – 3200 x 1800 (QHD+), IPS sensor display",
                    new Battery("Li-Ion, 4-cells, 2550 mAh", 4.5),
                    2259.00m
                );

            //Laptop secondLaptop = new Laptop("HP 250 G2", 699.00m);

            //Laptop thirdLaptop = new Laptop
            //    (
            //        "Lenovo W540",
            //        "Lenovo",
            //        "Intel Core i7-4900MQ (2.80GHz)",
            //        8,
            //        "Nvidia Quadro K2100M",
            //        512,
            //        "15.5\" 2880 x 1620 Wide viewing angle & High density display",
            //        4129.00m
            //    );

            Console.WriteLine(firstLaptop);

            //Laptop[] someLaptops = new Laptop[] {firstLaptop, secondLaptop, thirdLaptop};

            //foreach (var VARIABLE in someLaptops)
            //{
            //    Console.WriteLine(VARIABLE);
            //    Console.WriteLine("<--------------------------------------------------------------------->");
            //}
        }

        #endregion

    }
}
