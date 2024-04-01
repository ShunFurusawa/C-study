using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToList();
            Console.Write("Even numbers : ");
            foreach (var n in evenNumbers) 
            { 
                Console.Write("{0}, ", n);
            }
          
            Console.Write("\n\nmultiple of 3 : ");

            //LINQにより取得したデータをリストに変換。 配列なら.ToArray()
            //xはfor文のiとかｊみたいなもの？
            var multThree = numbers.Where(x => (x % 3) == 0).ToList();

            foreach (var x in multThree)
            {
                Console.Write("{0}, ", x);
            }
        }
    }
}
