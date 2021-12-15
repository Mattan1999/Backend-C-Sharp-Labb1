using System;

namespace Labb1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog("Dog-1", 1); // Ett nytt Dog-objekt skapas
            Animal dog2 = new Dog("Dog-2", 2); // Ett nytt Dog-objekt skapas
            Shelter shelter = new Shelter(); // Ett nytt Shelter-objekt skapas
            shelter.AddAnimal(dog); // Shelter har någon form av datastruktur.
            // När vi kallar på funktionen AddAnimal() kommer objektet vi lägger in som argument att sparas i denna.
            shelter.AddAnimal(dog2);
            shelter.DeleteAnimal("Dog-1"); // Shelter har två metoder för radera en Dog, en baserad på namn, och en baserad på id.
            shelter.DeleteAnimal(2);
            shelter.AddAnimal(dog);
            shelter.AddAnimal(dog2);
            shelter.UpdateAnimal(dog, "New name"); // UpdateAnimal() tar in ett Dog - objekt och en sträng, vilket uppdaterar namnet på objektet vi skickade med.
            Console.WriteLine(shelter.GetAnimal(1).GetName()); // "New name"
            var myshelter = shelter.GetAnimals();
            foreach (Animal animal in myshelter)
            {
                animal.MakeSound(); // "Voff!"
            }
        }
    }
}
