using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerCatalog
{
    class ComputerCatalog
    {
        static void Main()
        {
            Component gpuTypeOne = new Component("GPU", "Intel HD Graphics 4400", 256.6M);
            Component gpuTypeTwo = new Component("GPU", "Intel HD Graphics 5000", 306.6M);
            Component gpuTypeThree=new Component("GPU","Nvidia Quadro K2100QM",513.60m);
            Component ssdTypeOne = new Component("SSD", "250GB Samsung 850 EVO", 207.9M);
            Component ssdTypeTwo = new Component("SSD", "120GB A-Data Pro SP920", 114.64M);
            Component hddTypeOne = new Component("HDD", " 500GB Seagate Tech123", 180.99m);
            Component ramTypeOne = new Component("RAM", "4GB Kingston P100", 199.89M);
            Component ramTypeTwo = new Component("RAM", "8GB Kingston S230", 234.50m);
            Component cpuTypeOne = new Component("CPU", "Intel Core i5", 369.52M);
            Component cpuTypeTwo = new Component("CPU", "Intel Core i7", 489.02M);
            Component kb = new Component("Keyboard", "Gift", 0M);
            Component mouse=new Component("Mouse", "Loghitech F13",44.00m);

            List<Computer> computers = new List<Computer>()
            {

                new Computer("Dell",new List<Component>(){gpuTypeThree,ssdTypeOne,ramTypeOne,cpuTypeTwo}),
                new Computer("Dell",new List<Component>(){gpuTypeTwo,hddTypeOne,ramTypeTwo,cpuTypeOne}),
                new Computer("Sony",new List<Component>(){gpuTypeOne,ssdTypeTwo,ramTypeTwo,cpuTypeTwo,kb,mouse}),
                new Computer("HP",new List<Component>(){gpuTypeTwo,ssdTypeOne,ramTypeTwo,cpuTypeOne}),
                new Computer("Apple",new List<Component>(){gpuTypeOne,ssdTypeTwo,ramTypeOne,cpuTypeTwo,kb}),
            };

            computers
                 .OrderBy(computer => computer.Price)
                 .ToList()
                 .ForEach(Console.WriteLine);
        }
    }
}
