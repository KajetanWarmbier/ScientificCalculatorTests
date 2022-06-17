using System;

namespace MyFirstConsoleCalculator
{
    public class Trigonometry
    {

        public double SineDegrees(double number)
        {
            double result = Math.Sin((number * (Math.PI)/180));
            return result;
        }

        public double CosDegrees(double number)
        {
            double result = Math.Cos((number * (Math.PI)/180));
            return result;
        }

        public double TanDegrees(double number)
        {
            double result = Math.Tan((number * (Math.PI) / 180));
            return result;
        }
        public double SineRadians(double number)
        {
            double result = Math.Sin(number);
            return result;
        }

        public double CosRadians(double number)
        {
            double result = Math.Cos(number);
            return result;
        }

        public double TanRadians(double number)
        {
            double result = Math.Tan(number);
            return result;
        }

        public double AsinRadians(double number)
        {
            double result = Math.Asin(number);
            return result;
        }

        public double AcosRadians(double number)
        {
            double result = Math.Acos(number);
            return result;
        }

        public double AtanRadians(double number)
        {
            double result = Math.Atan(number);
            return result;
        }

        public double AsinDegrees(double number)
        {
            double result = Math.Asin(number) * 180 / Math.PI;
            return result;
        }

        public double AcosDegrees(double number)
        {
            double result = Math.Acos(number) * 180 / Math.PI;
            return result;
        }

        public double AtanDegrees(double number)
        {
            double result = Math.Atan(number) * 180 / Math.PI;
            return result;
        }
    }
}
