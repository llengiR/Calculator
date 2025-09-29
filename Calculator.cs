using System;
using Calculator.Controller;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            CalculatorController controller = new CalculatorController();
            controller.Run(args);
        }
    }
}