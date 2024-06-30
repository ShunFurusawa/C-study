using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraySample
{
    class Program
    {
        static void Main(string[] args) 
        {
            int[] numbers = new int[5];
            int count = 0, maximum, minimum = 0;

            Console.WriteLine("Pleas enter the number");
            //五回入力させる
            foreach (int i in numbers)
            {
                Console.Write("{0}times Left : ", 5 - count);

                numbers[count] = Convert.ToInt32(Console.ReadLine());
                count++;
            }
          
            //ソートしなくても最大最小求めれるメソッドあるの知らなかった
            maximum = numbers.Max(); minimum = numbers.Min();
            Console.Write("Entered numbers : ");
           
            //一覧表示
            foreach (int i in numbers)
            {
                Console.Write("{0}, ", i);
            }
         
            Console.WriteLine("\n\nMaximum value : " +  maximum);
            Console.WriteLine("Minimum value : " + minimum);
        }
    }
}