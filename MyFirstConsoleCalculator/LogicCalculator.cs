using System;

namespace MyFirstConsoleCalculator
{
    public  class LogicCalculator
    {
        public  static void Begin()
        {
            BasicOperation basicOperation = new BasicOperation();
            OtherOperation otherOperation = new OtherOperation();
            Trigonometry trigonometry = new Trigonometry();
           // Validation validation = new Validation();
            //MyCalculator myCalculator = new MyCalculator();

            bool check = true;
            while (check)
            {
            //BasicOperation basicOperation = new BasicOperation();
            //OtherOperation otherOperation = new OtherOperation();
            //Trigonometry trigonometry = new Trigonometry();
            Validation validation = new Validation();

            double num1;
            double num2;
            double result = 0;
            string operato;
            string checkNum1;
            string checkNum2;
            string checkNum;
            
            Console.WriteLine("\t\t\t\t\t\tSCIENTIFIC CALCULATOR\n");

            Console.WriteLine("FOR BASIC OPERATION, ENTER ANY SIGN : (+, -, *, /, %, ^)\n");
            Console.WriteLine("FOR TRIGONOMETRIC FUNCTIONS, ENTER ANY SIGN :(sin, cos, tan, sin(deg),\n \ncos(deg), tan(deg), Asin, Acos, Atan, Asin(deg), Acos(deg), Atan(deg))\n");
            Console.WriteLine("FOR OTHER OPERATION, ENTER ANY SIGN : (exp, sq, sqrt, cube, cuberoot, log)\n");
            Console.Write("insert your operator:  ");
            operato = Console.ReadLine();
            
            
            while(validation.SignCheck(operato) == "Invalid input")
            {
                Console.Write("Sorry, invalid input! \nPlease, enter valid operator: ");
                operato = Console.ReadLine();
            }

            if (operato == "+" || operato == "-" || operato == "*" || operato == "/" || operato == "%")
            {
                Console.Write("insert your first number:  ");
                checkNum1 = Console.ReadLine();
                
                while(validation.NumberCheck(checkNum1)=="Invalid input")
                {
                    Console.Write("Invalid input! \nPlease, enter first number again: ");
                    checkNum1 = Console.ReadLine();
                }
                num1 = Convert.ToDouble(checkNum1);

                Console.Write("insert your second number:  ");
                checkNum2 = Console.ReadLine();
               
                while(validation.NumberCheck(checkNum2)== "Invalid input")
                {
                    Console.Write("Invalid input! \nPlease, enter second number again.");
                    checkNum2 = Console.ReadLine();
                }

                num2 = Convert.ToDouble(checkNum2);

                switch (operato)
                {
                    case "+":
                         result = BasicOperation.Addition(num1, num2);
                        break;

                    case "-":
                        result = basicOperation.Subtraction(num1, num2);
                        break;

                    case "*":
                        result = basicOperation.Multiplication(num1, num2);
                        break;

                    case "/":
                        result = basicOperation.Division(num1, num2);

                        break;

                    case "%":
                        result = basicOperation.Modulo(num1, num2);
                        break;

                    default:
                        Console.WriteLine("wrong input!");
                        break;
                }

                Console.WriteLine("The result is :" + " " + result);
            }

            else if (operato == "!" || operato == "exp" || operato == "sq" || operato == "sqrt" || operato == "cube" || operato == "cbrt" || operato == "log")
            {

                Console.Write("Enter a number:  ");
                checkNum = Console.ReadLine();

                while (validation.NumberCheck(checkNum) == "Invalid input")
                {
                    Console.Write("Invalid input! \nPlease, enter number again: ");
                    checkNum = Console.ReadLine();
                }
                double number = Convert.ToDouble(checkNum);


                switch (operato)
                {
                    case "!":
                        result = otherOperation.Factorial(number);

                        break;

                    case "exp":
                        result = otherOperation.Exponential(number);

                        break;

                    case "sq":
                        result = otherOperation.Square(number);

                        break;

                    case "sqrt":
                        result = otherOperation.SquareRoot(number);

                        break;

                    case "cube":
                        result = otherOperation.Cube(number);
                        break;

                    case "cbrt":
                        result = otherOperation.CubeRoot(number);
                        break;


                    case "log":
                        result = otherOperation.Logarithm(number);

                        break;


                    default:
                        Console.WriteLine("wrong input!");

                        break;
                }
                Console.WriteLine("The result is :" + " " + result);
            }

            else if (operato == "sin" || operato == "cos" || operato == "tan" || operato == "sin(deg)" || operato == "cos(deg)" || operato == "tan(deg)" || operato == "Asin" || operato == "Acos" || operato == "Atan" || operato == "Asin(deg)" || operato == "Acos(deg)" || operato == "Atan(deg)" || operato == "log")
            {
                Console.Write("Enter a number:  ");
                checkNum = Console.ReadLine();

                while (validation.NumberCheck(checkNum) == "Invalid input")
                {
                    Console.Write("Invalid input! \nPlease, enter number again: ");
                    checkNum = Console.ReadLine();
                }
                double number = Convert.ToDouble(checkNum);

                switch (operato)
                {
                    case "sin":
                        result = trigonometry.SineRadians(number);
                        break;

                    case "cos":
                        result = trigonometry.CosRadians(number);
                        break;

                    case "tan":
                        result = trigonometry.TanRadians(number);
                        break;

                    case "sin(deg)":
                        result = trigonometry.SineDegrees(number);
                        break;

                    case "cos(deg)":
                        result = trigonometry.CosDegrees(number);
                        break;

                    case "tan(deg)":
                        result = trigonometry.TanDegrees(number);
                        break;

                    case "Asin":
                        result = trigonometry.AsinRadians(number);
                        break;

                    case "Acos":
                        result = trigonometry.AcosRadians(number);
                        break;

                    case "Atan":
                        result = trigonometry.AtanRadians(number);
                        break;

                    case "Asin(deg)":
                        result = trigonometry.AsinDegrees(number);
                        break;

                    case "Acos(deg)":
                        result = trigonometry.AcosDegrees(number);
                        break;

                    case "Atan(deg)":
                        result = trigonometry.AtanDegrees(number);
                        break;

                    default:
                        Console.WriteLine("wrong input!");

                        break;
                }
                Console.WriteLine("The result is :" + " " + result);
                }

            Ask:
                Console.WriteLine("Will you like to continue, yes or no ?");
            string checkme = Console.ReadLine();
                //checkme = checkme.ToLower(); to make it case-sensitive
                if(checkme == "yes")
                {
                    Console.Clear();
                    continue;
                   
                }
                else if(checkme == "no")
                {
                    //Console.Clear();
                    break;
                }
                else if(checkme != "yes" && checkme != "no")
                {
                    
                    Console.WriteLine("Your selection is invalid");
                    goto Ask;
                    
                }
            }
        }
    }
}
