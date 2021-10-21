using System;
using System.Collections.Generic;
using System.Linq;

namespace ZooSO
{

    class Program
    { 
        
        static void Main(string[] args)
        {
            Zoo<Fish> fishZoo = new Zoo<Fish>();
            fishZoo.AddAnimal(new Salmon());
            fishZoo.AddAnimal(new Salmon());
            Console.WriteLine("This should be False: "+fishZoo.HasAnimal<Clownfish>());
        }
        
        class Zoo <AnimalT> where AnimalT : Animal
        {
            //private Animal[] _zooanimals = new Animal[0];

            private List<AnimalT> _animals = new List<AnimalT>();


            public bool HasAnimal<TSpecies>() where TSpecies : AnimalT
            {
                for (int i = 0; i < _animals.Count(); i++)
                   if (_animals[i] is TSpecies)
                   {
                       return true;
                   }

                return false;
            }

            public void AddAnimal(AnimalT animal)
            { 
                //Array.Resize<Animal>(ref _zooanimals, _zooanimals.Length + 1);
               // _zooanimals[^1] = animal; 
               this._animals.Add(animal);

            }
        }

        class Animal {}

        class Mammal : Animal{}
        
        class Bear : Mammal{}
        
        class Donkey : Mammal{}
        
        class Lion : Mammal{}
        
        class Fish : Animal{}
      
        class Salmon : Fish{}

        class Clownfish : Fish{}
        
        class Student{}
       
        
        
        
    }
    
}
