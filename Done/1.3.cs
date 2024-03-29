using System;

namespace BasicClass
{
    class Animal
    {
        public string? name;
        public int age; 

        public void Speak()
        {
            Console.WriteLine(name + " says: Hello! i'm "+ age + "years old!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new Animal();
            myAnimal.name = "tomo";
            myAnimal.age = 20;
            myAnimal.Speak();
        }
    }
}