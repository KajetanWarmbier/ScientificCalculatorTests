using System;

namespace MyFirstConsoleCalculator
{
    public class BasicOperation
    {
        public static double Addition(double num1, double num2)
        {
           double result = num1 + num2;
            return result;
        }
        public double Subtraction(double num1, double num2)
        {
            double result = num1 - num2;
            return result;
        }
        public double Multiplication(double num1, double num2)
        {
            double result = num1 * num2;
            return result;
        }
        public double Division(double num1, double num2)
        {
            if (num2 == 0)
            {
                throw new ArgumentException();
            }

            double result = num1 / num2;
            return result;
        }
        public double Modulo(double num1, double num2)
        {
            double result = num1 % num2;
            return result;
        }
        public double Exp(int num1, int num2)
        {
            double result = num1 ^ num2;
            return result;
        }
    }
}
    