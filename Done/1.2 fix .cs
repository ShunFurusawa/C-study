﻿using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 0, number2 = 0,  select = 0;
            bool exeption = false;
            do
            {
                exeption = TryConvert(ref number1, ref number2, ref select);
            } while (exeption == false);

            switch (select)
            {
                case 1:
                    int sum = number1 + number2;
                    Console.WriteLine("Sum: " + sum);
                    break;
                case 2:
                    int diff = number1 - number2;
                    Console.WriteLine("diff: " + diff);
                    break;
                case 3:
                    int prod = number1 * number2;
                    Console.WriteLine("prod: " + prod);
                    break;
                case 4:
                    int quot = number1 / number2;
                    int remain = number1 % number2;
                    Console.WriteLine("quot: " + quot + " remain: " + remain);
                    break;
            }
        }

        static bool TryConvert(ref int number1, ref int number2, ref int select)
        {
            try
            {
                Console.Write("Enter number 1: ");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                number2 = Convert.ToInt32(Console.ReadLine());
                    
                Console.WriteLine("addition:1, subtraction:2, multiplication:3, division:4 ");
                Console.Write("Select calculation to do : ");
                select = Convert.ToInt32(Console.ReadLine());
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine("何を四天王？");
               
                return false; 
            }
        }
    }
}