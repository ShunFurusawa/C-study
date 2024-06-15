using System;

namespace BasicClass
{
    class Animal
    {
        //正確にはこの書き方の方がよさそう
        public string? name { set; get; }        
        public int age { set; get; }

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
