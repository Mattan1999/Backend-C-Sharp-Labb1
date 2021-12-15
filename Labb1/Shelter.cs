using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1
{
    class Shelter
    {
        private readonly List<Animal> animals;

        public Shelter() {
            animals = new List<Animal>();
        }
        
        public void AddAnimal(Animal dog)
        {
            animals.Add(dog);
        }

        public void DeleteAnimal(string name)
        {
            foreach(Animal animal in animals)
            {
                if (animal.Name == name)
                {
                    animals.Remove(animal);
                    break;
                }
            }
        }

        public void DeleteAnimal(int id)
        {
            foreach (Animal animal in animals)
            {
                if (animal.Id == id)
                {
                    animals.Remove(animal);
                    break;
                }
            }
        }

        public void UpdateAnimal(Animal dog, string newName)
        {
            foreach (Animal animal in animals)
            {
                if (animal == dog)
                {
                    animal.Name = newName;
                    break;
                }
            }
        }

        public Animal GetAnimal(int id)
        {
            foreach (Animal animal in animals)
            {
                if (animal.Id == id)
                {
                    return animal;
                }
            }
            return null;
        }

        public List<Animal> GetAnimals()
        {
            return animals;
        }
    }
}
