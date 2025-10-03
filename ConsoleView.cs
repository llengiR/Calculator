using System;

namespace Calculator.View
{
    /// <summary>
    /// Reads input from user and returns the result in the console.
    /// </summary>
    public class ConsoleView
    {
        /// <summary>
        /// Gets the RPN expression from the user.
        /// </summary>
        /// <returns>The line of text given by the user.</returns>
        public string GetInput()
        {
            //show prompt to user
            Console.Write("Enter an RPN Expression <return> (empty string = exit:) ");
            string input = Console.ReadLine(); //read user input

            return input;
        }
        /// <summary>
        /// Displays the calculated result.
        /// </summary>
        /// <param name="result">The number calculated that is displayed.</param>
        public void ShowResult(double result)
        {
            Console.WriteLine($"Result: {result:F1}");
        }
        /// <summary>
        /// Display error message.
        /// </summary>
        /// <param name="exception">The error being displayed.</param>
        public void ShowError(Exception exception)
        {
            Console.WriteLine(exception.Message);
        }

        /// <summary>
        /// Display exit message when quit
        /// </summary>
        public void ShowExitMessage()
        {
            Console.WriteLine("The user exited the application");
        }

        /// <summary>
        /// Display message from wrong command line 
        /// </summary>
        public void ShowUsageMessage()
        {
            Console.WriteLine("Syntax: Calculator [source destination]");
        }    
    } 
}
