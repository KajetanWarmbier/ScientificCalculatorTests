namespace MyFirstConsoleCalculator
{
    public  class Validation
    {
        public string NumberCheck(string check)
        {
            //one can use the method below whereby the value is declared earlier.: 
            //double value = 0;
            //string result;
            //if (double.TryParse(check, out value) == true)

            double value = 0;
            string result = "";
            bool isCheckValid = double.TryParse(check, out value);
            if (isCheckValid)
            {
                result = value.ToString();
            }
            else
            {
                result = "Invalid input";
            }

            return result;
            //string result;
            //if (double.TryParse(check, out double value) == true)
            //{
            //    result = value.ToString();
            //}
            //else
            //{
            //    result = "Invalid input";
            //}

            //return result;
        }

        public string SignCheck(string sign)
        {
            string result;
            if (sign != "+" && sign != "-" && sign != "*" && sign != "/" && sign != "%"&& sign != "!" && sign != "exp" && sign != "sq" && sign != "sqrt" && sign != "cube" && sign != "cbrt" && sign != "log"&& sign != "sin" && sign != "cos" && sign != "tan" && sign != "sin(deg)" && sign != "cos(deg)" && sign != "tan(deg)" && sign != "Asin" && sign != "Acos" && sign != "Atan" && sign != "Asin(deg)" && sign != "Acos(deg)" && sign != "Atan(deg)")
            {
                result = "Invalid input";
            }
            else
            {
                result = sign;
            }
            return result.Trim();
        }

    }
    }
