using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Animal
    {
        public string Name { get; set; }
        public int Id { get; }

        public Animal(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
        public void MakeSound()
        {
            Console.WriteLine("Voff!!");
        }

        public string GetName()
        {
            return Name;
        }
    }
}
