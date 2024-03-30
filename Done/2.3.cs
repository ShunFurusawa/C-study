using System;
using System.Collections.Generic;

namespace SampleApplication
{
    //  static class DisplayHelper
    class MyClass
    {
        /// <summary>
        /// この場合1、2、3それぞれに乗数を5として乗算した合計を表示ってこと？
        /// </summary>
        /// <param name="multiplier">乗数？</param>
        /// <param name="Items"></param>


        //public static void ShowItems(int multiplier, List<string> items)
        public static void DisplayItems(int multiplier, List<string> Items)
        {
            ///<code>
            ///
            /// foreach (var item in items)
            /// {       
            ///     Console.WriteLine(Items[i] + " " + multiplier);
            /// }                            
            /// </code>
            for (int i = 0; i < Items.Count; i++)
            {
                Console.WriteLine(Items[i] + " " + multiplier);
            }

            int result = 0;     //たしかにこれいらないやん
                result = multiplier * 5;
            Console.WriteLine("result is " + result);
            //Result is : 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var numberList = new List<string>{ "one", "two", "three" };
            List<string> itemsList = new List<string> { "one", "two", "three" };
            MyClass.DisplayItems(5, itemsList);
        }
    }   
}