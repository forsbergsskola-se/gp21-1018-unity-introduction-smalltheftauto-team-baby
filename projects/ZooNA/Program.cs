using System;
using System.Collections.Generic;

namespace ZooNA
{
    class Program{
        static void Main(){

            Zoo<Fish> fishZoo = new Zoo<Fish>();
            Zoo<Mammal> mammalZoo = new Zoo<Mammal>();
            Zoo<Donkey> donkeyZoo = new Zoo<Donkey>();
            fishZoo.AddAnimal(new Salmon());
            mammalZoo.AddAnimal(new Bear());
            donkeyZoo.AddAnimal(new Donkey());

            Console.WriteLine("This should be False: "+fishZoo.HasAnimal<Clownfish>());
            Console.WriteLine("This should be True: "+mammalZoo.HasAnimal<Bear>());
        }

    }

    public class Zoo<AnimalT> where AnimalT : Animal{

        List<AnimalT> animals = new List<AnimalT>();

        public void AddAnimal(AnimalT animal){
            animals.Add(animal);
        }

        public bool HasAnimal<AnimalB>(){
            foreach (var hasanimal in animals){
                if (hasanimal is AnimalB) {
                    return true;
                }       
            }
            return false;
        }

    }

    public class Animal{
    }

    public class Mammal : Animal{
    }

    public class Bear : Mammal{
    }

    public class Donkey : Mammal{
    }

    public class Lion : Mammal{
    }
    
    public class Fish : Animal{
    }

    public class Salmon : Fish{
    }

    public class Clownfish : Fish{
    }

    public class Student{
    }

}
