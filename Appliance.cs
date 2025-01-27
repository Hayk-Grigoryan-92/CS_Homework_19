using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class Appliance
    {
        public string Brand { get; set; }

        private int _power;

        public int Power
        {
            get
            {
                return _power;
            }
            set
            {
                if (value > 0)
                {
                    _power = value;
                }
            }
        }

        public Appliance(string brand, int power)
        {
            Brand = brand;
            Power = power;
        }

        public void DisplayApplianceInfo()
        {
            Console.Write($"{Brand} | {Power} \n");
        }
    }

    class WashingMachine : Appliance
    {
        private int _loadCapacity;
        public int LoadCapacity
        {
            get
            {
                return _loadCapacity;
            }
            set
            {
                if (value > 0)
                {
                    _loadCapacity = value;
                }
            }
        }

        public WashingMachine(string brand, int power, int loadCapacity) : base(brand, power)
        {
            LoadCapacity = loadCapacity;
        }

        public void DisplayWashingMachineInfo()
        {
            Console.Write($"{Brand} | {Power} | {LoadCapacity} \n");
        }
    }
}
