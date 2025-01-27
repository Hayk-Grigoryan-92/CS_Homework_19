using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class Vehicle
    {
        public string Mark {  get; set; }
        public string Model {  get; set; }

        public Vehicle(string mark, string model)
        {
            Mark = mark;
            Model = model;
        }

        public void DisplayVehicleinfo()
        {
            Console.Write($"{Mark} | {Model}");
        }
    }

    class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public Car(string mark, string model,int numberOfDoors) : base(mark, model)
        {
            NumberOfDoors = numberOfDoors;
        }

        public void DisplayCarInfo()
        {
            Console.Write($"{Mark} | {Model} | {NumberOfDoors} \n");
        }
    }
}
