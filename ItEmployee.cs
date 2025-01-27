using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class ItEmployee
    {
        public string Name { get; set; }
        public string Position { get; set; }

        public ItEmployee(string name, string position) 
        {
            Name = name;
            Position = position;
        }

        public void DisplayItEmployeeInfo()
        {
            Console.Write($"{Name} | {Position} \n"); 
        }
    }

    class Developer : ItEmployee
    {
        public string ProgrammingLanguage { get; set; }

        public Developer(string name, string position, string language) : base(name,position)
        {
            ProgrammingLanguage = language;
        }

        public void DisplayDeveloperInfo()
        {
            Console.Write($"{Name} | {Position} | {ProgrammingLanguage} \n");
        }
    }
}
