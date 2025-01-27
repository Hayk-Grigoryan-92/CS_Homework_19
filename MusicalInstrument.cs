using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class MusicalInstrument
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public MusicalInstrument(string name, string type)
        {
            Name = name;
            Type = type;
        }

        public void DisplayInstrumentInfo()
        {
            Console.Write($"{Name} | {Type} \n");
        }
    }

    class Guitar : MusicalInstrument
    {
        private int _numberOfStrings;

        public int NumberOfStrings
        {
            get
            {
                return _numberOfStrings;
            }
            set
            {
                if(value > 0)
                {
                    _numberOfStrings = value;
                }
            }
        }

        public Guitar(string name, string type, int numStr) : base(name,type)
        {
            NumberOfStrings = numStr;
        }

        public void DisplayGuitarInfo()
        {
            Console.Write($"{Name} | {Type} | {NumberOfStrings} \n");
        }
    }
}
