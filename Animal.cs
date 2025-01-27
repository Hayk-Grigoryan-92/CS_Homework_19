using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class Animal
    {
        public string Species {  get; set; }
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if(value > 0)
                {
                    _age = value;
                }
            }
        }

        public Animal(string species, int age) 
        {
            Species = species;
            Age = age;
        }

        public void DisplayAnimalInfo()
        {
            Console.Write($"{Species} | {Age} \n");
        }
    }

    class Dog : Animal
    {
        public string Breed { get; set; }

        public Dog(string species, int age, string breed) : base(species, age) 
        {
            Breed = breed;
        }

        public void DisplayDogInfo()
        {
            Console.Write($"{Species} | {Age} | {Breed} \n");
        }
    }
}
