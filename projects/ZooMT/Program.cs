using System;

namespace ZooMT
{
    
    
    class Progam
    {
        public void Main()
        {
            {
                Zoo<Fish> fishZoo = new Zoo<Fish>();
                fishZoo.AddAnimal(new Fish()); 
                fishZoo.AddAnimal(new Clownfish()); 
            }
        }
    }
    
    class Zoo<TAnimal> where  TAnimal : Animal
    {
        private Animal[] animalZoo = new Animal[1];

        // public Zoo<Fish> fishZoo = new Zoo<Fish>();
        // public Zoo<Mammal> mammalZoo = new Zoo<Mammal>();
        

        public bool HasAnimal<TAnimal>()
        {
            if (animalZoo is Animal)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddAnimal(TAnimal animal)
        {
            Array.Resize(ref animalZoo, animalZoo.Length + 1);
            animalZoo[animalZoo.Length - 1] = animal;
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
