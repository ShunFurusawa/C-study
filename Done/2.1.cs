using System;

namespace CustomException
{
    class NegativeNumberException : Exception
    {
        public NegativeNumberException(string msg) : base(msg) 
        {            
        }
    }

    class BigNumberException : Exception
    {
        public BigNumberException(string msg) : base(msg)
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a positive number: ");
                int number = Convert.ToInt32(Console.ReadLine());
                
                if (number < 0)
                {
                    throw new NegativeNumberException("Number is not positive.");
                }
                else if (number >= 10) 
                {
                    throw new BigNumberException("Number is bigger than 10.");
                }
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (BigNumberException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally { Console.WriteLine("End"); }
        }
    }

   
}