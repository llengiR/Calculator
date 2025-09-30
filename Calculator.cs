using System;
using Calculator.Controller;

namespace Calculator
{
    /// <summary>
    /// Application starting point.
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// main entry point for the application.
        /// </summary>
        /// <param name="args">Optional command-line arguments passed to the calculator.
        /// these are forwarded to <see cref="CalculatorController.Run(String[])"/>.</param>
        static void Main(string[] args)
        {
            CalculatorController controller = new CalculatorController();
            controller.Run(args);
        }
    }
}
