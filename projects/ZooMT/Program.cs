using System;

namespace ZooMT
{
    
    
    class Progam
    {
        public void Main()
        {
            {
                Zoo<Animal> animalZoo = new Zoo<Animal>();
                animalZoo.AddAnimal(new Fish()); // OKAY
                animalZoo.AddAnimal(new Clownfish()); // OKAY
                animalZoo.AddAnimal(new Lion()); // OKAY
                animalZoo.AddAnimal(new Donkey()); // OKAY
            }
            
            
        }
        
        
    }
    
    class Zoo<TAnimal> where  TAnimal : Animal
    {
        private Animal[] zooanimals = {};
        
        public bool HasAnimal<TAnimal>()
        {
            return true;
        }

        public void AddAnimal(TAnimal animal)
        {
            Array.Resize(ref zooanimals, zooanimals.Length + 1);
            zooanimals[zooanimals.Length] = animal;
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
