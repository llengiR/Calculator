using System;
using Calculator.Model;
using Calculator.View;

namespace Calculator.Controller
{
    /// <summsary>
    /// Makes the app able to read inputs, run the calculator and show outputs.
    /// </summary>
    public class CalculatorController
    {
        //counter with rpn calcs
        private RpnCalculator calculator;
        private ConsoleView consoleView;

        /// <summary>
        /// Constructs a controller with a calculator and console view.
        /// </summary>
        public CalculatorController()
        {
            calculator = new RpnCalculator();
            consoleView = new ConsoleView();
        }

        /// <summary>
        /// start point of the app. No args = interactive mode.
        /// two args = file mode.
        /// </summary>
        /// <param name="args">Command-line args, no args for console or two for file mode.</param>
        public void Run(string[] args)
        {
            // no args = interacvtive console mode
            if(args.Length == 0)
            {
                RunConsoleMode();
            }
            //two args = file mode
            else if(args.Length == 2)
            {
                RunFileMode(args[0], args[1]);
            }
            else
            {
                consoleView.ShowUsageMessage();
            }
        }

        /// <summary>
        /// Console mode - keeps asking for input until quit.
        /// </summary>
        private void RunConsoleMode()
        {
            while(true)
            {
                //ask for rpn expression
                string input = consoleView.GetInput();

                // if enter is pressed without typing 
                if(string.IsNullOrEmpty(input))
                {
                    consoleView.ShowExitMessage();
                    break;
                }
                //try calculate
                try
                {
                    double result = calculator.Calculate(input);
                    consoleView.ShowResult(result);
                }
                catch(Exception ex)
                {
                    consoleView.ShowError(ex);
                }
            }
        }

        /// <summary>
        /// runs file mode - read from input file, writes to output
        /// </summary>
        /// <param name="inputFilePath">Path to input file with RPN expressions.</param>
        /// <param name="outputFilePath">Path to output file where outputs and errors are written.</param>
        private void RunFileMode(string inputFilePath, string outputFilePath)
        {
            //create file handler with inout and output
            FileView fileView = new FileView(inputFilePath, outputFilePath);

            try
            {
                //read all line from input file
                string[] expressions = fileView.GetAllInputs();
                //go through each line
                foreach(string expression in expressions)
                {
                    try
                    {
                        //calulate and write result to output
                        double result = calculator.Calculate(expression);
                        fileView.WriteResult(result);
                    }
                    //if calclution fail = write error to output
                    catch(Exception ex)
                    {
                        fileView.WriteError(ex);
                    }
                }
            }
            // if cant be read
            catch(Exception ex)
            {
                consoleView.ShowError(ex);
            }
        }
    }
}
