using System;

namespace ZooSO
{

    class Program
    { 
        
        static void Main(string[] args)
        {
            
        }
        
        class Zoo <AnimalT> where AnimalT : Animal
        { 
            Animal [] zooanimals = {};

            
            public bool HasAnimal<AnimalT>()
            {
    
                // retunera något annat än true
                return true;
            }

            public void AddAnimal(AnimalT animal)
            { 
                Array.Resize<Animal>(ref zooanimals, zooanimals.Length + 1);
                //zooanimals[zooanimals.Length - 1] = animal;
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
    
}
