using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class Employee
    {
        public string Name {  get; set; }

        private double _selary;

        public double Selary
        {
            get
            {
                return _selary;
            }
            set
            {
                if (value > 0)
                {
                    _selary = value;
                }
            }
        }

        public Employee(string name, double selary) 
        {
            Name = name;
            Selary = selary;
        }

        public void DisplayEmployeeInfo()
        {
            Console.Write($"{Name} | {Selary}");
        }
    }

    class Manager : Employee
    {

        public string Department {  get; set; }
        public Manager(string name, double selary, string department) : base(name, selary)
        {
            Department = department;
        }

        public void DisplayManagerInfo()
        {
            Console.Write($"{Name} | {Selary} | {Department}");
        }
    }
}
