using System;
using System.Collections.Generic;

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
        //private TAnimal[] animals = new TAnimal[1];
        private List<TAnimal> animals = new List<TAnimal>();
        

        public bool HasAnimal<TSpecies>() where  TSpecies : TAnimal
        {
            {
                for (int i = 0; i < animals.Count(); i++)
                    if (animals[i] is TSpecies)
                    {
                        return true;
                    }

                return false;
            }
            
        }

        public void AddAnimal(TAnimal animal)
        {
            // Array.Resize(ref animals, animals.Length + 1);
            // animals[^1] = animal;
            animals.Add(animal);
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
