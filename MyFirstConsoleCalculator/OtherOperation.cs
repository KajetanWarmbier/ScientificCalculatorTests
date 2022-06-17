using System;

namespace MyFirstConsoleCalculator
{
    public class OtherOperation
    {
         public double Exponential(double number)
        {
            double result = Math.Exp(number);
            return result;
        }
        public double Square(double number)
        {
            double result = Math.Pow(number, 2);
            return result;
        }

        public double SquareRoot(double number)
        {
            double result = Math.Sqrt(number);
            return result;
        }

        public double Cube(double number)
        {
            double result = Math.Pow(number, 3);
            return result;
        }
        public double CubeRoot(double number)
        {
            double result = Math.Cbrt(number);
            return result;
        }

        public double Logarithm(double number)
        {
            double result = Math.Log10(number);
            return result;
        }

        public double Factorial(double number)
        {
            double result = 1;

            if (number < 1)
            {
                throw new ArgumentOutOfRangeException();

            } 
            else
            {
                for (int i = 1; i <= number; i++)
                {
                    result *= i;
                }
                return result;
            }       
        }
    }
}