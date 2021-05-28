using System;

namespace Fundamentals
{
    public class Program
    {
        static void Main(string[] args)
        {
            ConsoleWrapper consoleWrapper = new ConsoleWrapper("n");
            consoleWrapper.StartCalculator();
        }
    }


        public class ConsoleWrapper
    {
        public double NumInput1 { set; get; }
        public double NumInput2 { set; get; }
        public string Operation { set; get; }
        public string SimbolOut { set; get; }

        public ConsoleWrapper(string simbolOut)
        {
            NumInput1 = double.NaN;
            NumInput2 = double.NaN;
            Operation = "";
            SimbolOut = simbolOut;
        }
        public static string GetConsoleRead()
        {
            string input = Console.ReadLine();
            if (input != "") return input;
            else return "";
        }
        public double GetNumInput() 
        { 
            // Ask the user to type the number.
            Console.Write("Type a number, and then press Enter: ");
            string numInput1 = ConsoleWrapper.GetConsoleRead();
            double cleanNum1 = 0;
            while (!double.TryParse(numInput1, out cleanNum1))
            {
                Console.Write("This is not valid input. Please enter an integer value: ");
                numInput1 = ConsoleWrapper.GetConsoleRead();
                if (numInput1 == SimbolOut) return double.NaN;
                else break;
            }
            return cleanNum1;
        }
        public double CalculateResult()
        {
            NumInput1 = this.GetNumInput();
            NumInput2 = this.GetNumInput();
            double result = 0;

            // Ask the user to choose an operator.
            Console.WriteLine("Choose an operator from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            Operation = ConsoleWrapper.GetConsoleRead();
            result = Calculator.DoOperation(NumInput1, NumInput2, Operation);
            return result;

        }
        public void StartCalculator()
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                

                try
                {
                    double result=this.CalculateResult();
                    
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press "+SimbolOut+" and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == SimbolOut) endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        

    }

    }
}
