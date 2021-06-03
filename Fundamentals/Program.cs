using System;

namespace Fundamentals
{
    public class Program
    {
        public static IConsoleWrapper ConsoleWrapper { set; get; }= new ConsoleWrapper();
        
        public static void Main(string[] args)
        {
             bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";


                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = ConsoleWrapper.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = ConsoleWrapper.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = ConsoleWrapper.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = ConsoleWrapper.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = ConsoleWrapper.ReadLine();

                Console.WriteLine(Output(op, cleanNum1, cleanNum2));

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (ConsoleWrapper.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            return;
        }

        public static string Output(string operation,double cleanNum1,double cleanNum2)
        {
            string outLine = "";
            try
            {
                double result = Calculator.DoOperation(cleanNum1, cleanNum2, operation);
                if (double.IsNaN(result))
                {
                    outLine="This operation will result in a mathematical error.\n";
                }
                else outLine = "Your result: "+result+"\n";
                return outLine;
            }
            catch ()
            {
                return outLine="Oh no! An exception occurred trying to do the math.\n";
            }
        }
    }

    

}
