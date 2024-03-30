using System;

namespace DocumentationExample
{  
    /// <summary>
    ///加算と減算を行うクラス
    /// </summary>
    class Calculator
    {
        /// <summary>
        ///  加算を行うメソッド
        /// </summary>
        /// <param name="a">項１</param>
        /// <param name="b">項２</param>
        /// <returns><paramref name="a"/>と<paramref name="b"/>の和</returns>
        public int Add(int a, int b) 
        {
            return a + b;
        }
        /// <summary>
        /// 減算を行うメソッド
        /// </summary>
        /// <param name="a">項１</param>
        /// <param name="b">項２</param>
        /// <returns><paramref name="a"/>と<paramref name="b"/>の差</returns>
        public int Subtract(int a, int b)
        {             
            return a - b; 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Add(5, 3));
            Console.WriteLine(calc.Subtract(5, 3));
        }
    }   
}