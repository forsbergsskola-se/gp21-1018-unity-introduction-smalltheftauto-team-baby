using System;

namespace ZooNA
{
    class Program{
        static void Main(){
            Console.WriteLine("Hello World!");
        }
    }

    public class Zoo<T> where T : Animal{
        
    }

    public class Animal{
        public void Animal(){

        }
    }

        public class Mammal : Animal{
        public void Mammal(){

        }
    }

    public class Bear : Mammal{
        public void Bear(){
            
        }
    }

    public class Donkey : Mammal{
        public void Donkey(){
            
        }
    }

    public class Lion : Mammal{
        public void Lion(){
            
        }
    }
    
    public class Fish : Animal{
        public void Fish(){

        }
    }

    public class Salmon : Fish{
        public void Salmon(){
            
        }
    }

    public class Clownfish : Fish{
        public void Clownfish(){
            
        }
    }

    public class Student{
        public void Student(){
            
        }
    }

}
