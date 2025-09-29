using System;
using Calculator.Model;
using Calculator.View;

namespace Calculator.Controller
{
    public class CalculatorController
    {
        //counter with rpn calcs
        private RpnCalculator calculator;
        private ConsoleView consoleView;

        //constructor
        public CalculatorController()
        {
            calculator = new RpnCalculator();
            consoleView = new ConsoleView();
        }

        //main method
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

        //console mode - keeps asking for input until quit
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

        // runs file mode - read from input file, writes to output
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