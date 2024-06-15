using System;
using System.Collections.Generic;
using System.Linq;

namespace ListSample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Console.WriteLine("Pleas enter the number");
            //五回入力させる
            for (int count = 0; count < 5; count++)
            {
                Console.Write("{0}times Left : ", 5 - count);

                numbers.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.Write("Entered numbers : ");
            DisplayNumbers(numbers);
            AddNumber(ref numbers);
            ContainAndRemove(ref numbers);
            
            Console.Write("消去後の要素");
            DisplayNumbers(numbers);
        }

        private static void DisplayNumbers(List<int> numbers)
        {
           
            //一覧表示とソート
            foreach (int number in numbers)
            {              
                Console.Write("{0}, ", number);
            }
        }

        private static void AddNumber(ref List<int> numbers)
        {
            Console.WriteLine("\n\n加える値を入力してください");
            int num = Convert.ToInt32(Console.ReadLine());
            numbers.Add(num);
            Console.WriteLine($"{num}を末尾に加えました");            
        }

        private static void ContainAndRemove(ref List<int> numbers)
        {
            Console.WriteLine("消去したい値を入力してください");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (numbers.Contains(num))
            {
                numbers.Remove(num);
                Console.WriteLine($"要素{num}を消去しました。");
            }
            else
            {
                Console.WriteLine($"要素{num}は存在しません。");
            }
        }
    }
}