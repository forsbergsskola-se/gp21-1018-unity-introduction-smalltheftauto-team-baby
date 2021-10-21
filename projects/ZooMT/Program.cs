using System;

namespace ZooMT
{
    
    
    class Progam
    {
        public static void Main()
        {
        {
            Zoo<Fish> fishZoo = new Zoo<Fish>();
            fishZoo.AddAnimal(new Salmon());
            fishZoo.AddAnimal(new Clownfish());
            fishZoo.AddAnimal(new Salmon());
            Console.WriteLine("This should be True: "+fishZoo.HasAnimal<Clownfish>());
        }        
        }
    }
    
    class Zoo<TAnimal> where  TAnimal : Animal
    {
        private TAnimal[] animals = new TAnimal[1];

        public bool HasAnimal<TSpecies>() where  TSpecies : TAnimal
        {
            if (animals is !TSpecies)
            {
                return false;
            }
            
        }

        public void AddAnimal(TAnimal animal)
        {
            Array.Resize(ref animals, animals.Length + 1);
            animals[^1] = animal;
        }
    }

    class Animal 
    {
        
    }
    
    class Mammal : Animal
    {
        
    }

    class Bear : Mammal
    {
        
    }

    class Donkey : Mammal
    {
        
    }

    class Lion : Mammal
    {
        
    }

    class Fish : Animal
    {
        
    }

    class Salmon : Fish
    {
        
    }

    class Clownfish : Fish
    {
        
    }

    class Student
    {
        
    }
}
