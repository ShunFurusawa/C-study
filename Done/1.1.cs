using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("名前を入力してください。: ");
            string? name = Console.ReadLine();
            Console.WriteLine("Hello," + name + "!");
        }
    }
}