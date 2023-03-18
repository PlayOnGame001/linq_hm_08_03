using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_hm_08_03
{
    class Device
    {
        public string name { get; set; }
        public string firm { get; set; }
        public int cena { get; set; }

        public Device() { }
        public Device(string name, string company, int price)
        {
            this.name = name;
            this.firm = firm;
            this.cena = cena;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Device> device1 = new List<Device>()
            {
                new Device("A10", "Samsung", 180),
                new Device("iPhone 13 max pro ultra", "Apple", 2031),
                new Device("NEFOS", "Nefos", 150),
                new Device("A12", "Samsung", 500),
                new Device("U12", "Honor", 380),
                new Device("iPhone 11", "Apple", 1250)
            };

            var DeviceGroups = from dev in device1
                               group dev by dev.firm;
            foreach (IGrouping<string, Device> d in DeviceGroups)
            {
                Console.WriteLine($"{d.Key}:");
                foreach (var a in d)
                {
                    Console.WriteLine(a.name);
                }
                Console.WriteLine();
            }
        }
    }
}