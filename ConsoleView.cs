using System;

namespace Calculator.View
{
    // user input
    public class ConsoleView
    {
        public string GetInput()
        {
            //show prompt to user
            Console.Write("Enter an RPN Expression <return> (empty string = exit:) ");
            string input = Console.ReadLine(); //read user input

            return input;
        }
         //display calcs
        public void ShowResult(double result)
        {
            Console.WriteLine($"Result: {result:F1}");
        }
        // display error
        public void ShowError(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        // display exit message when quit
        public void ShowExitMessage()
        {
            Console.WriteLine("The user exited the application");
        }

        //display message fro wrong command line 
        public void ShowUsageMessage()
        {
            Console.WriteLine("Syntax: Calculator [source destination]");
        }    
    } 
}
