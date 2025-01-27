using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class Person
    {
        public string Name { get; set; }
        private int _age;

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
        public Person(string name, int age) 
        {
            Name = name;
            Age = age;
        }

        public void DisplayInfo()
        {
            Console.Write($"{Name} | {Age} \n");
        }
    }

    internal class Student : Person
    {
        public string StudentId { get; set; }
        public Student(string name, int age) : base(name, age)
        {
            StudentId = Guid.NewGuid().ToString();
        }

        public void StudentInfo()
        {
            Console.WriteLine($"{Name} | {Age} | {StudentId}  \n");
        }
    }
}
