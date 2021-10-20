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
        public void AddAnimal()
        {
            Animal animal = new Animal();
        }

        public void HasAnimal()
        {
            
        }
        
        
        
    }
    
    class Zoo<T> where  T : Animal
    {
        
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
