using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Homework_19
{
    internal class Book
    {
        public string Name {  get; set; }
        public string Author { get; set; }

        public Book(string name, string author)
        {
            Name = name;
            Author = author;
        }

        public void DisplayBookinfo()
        {
            Console.Write($"{Name} | {Author} \n");
        }
    }

    class EBook : Book
    {
        private double _fileSize;

        public double FileSize
        {
            get
            {
                return _fileSize;
            }
            set 
            {
                if(value > 0)
                {
                    _fileSize = value;
                }
            }
        }

        public EBook(string name, string author, double size): base(name,author)
        {
            FileSize = size;
        }

        public void DisplayEBookInfo()
        {
            Console.Write($"{Name} | {Author} | {FileSize} \n");
        }
    }
}
