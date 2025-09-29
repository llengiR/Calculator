using System;
using System.IO;

namespace Calculator.View
{
    public class FileView
    {
        // input file path
        public string InputFilePath { get; }

        // output file path
        public string OutputFilePath{ get; }

        //constructor
        public FileView(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }

        // read rpn expressions
        public string[] GetAllInputs()
        {
            try
            {
                //read all lines from input
                string[] lines = File.ReadAllLines(InputFilePath);
                return lines;
            }
            catch (Exception ex)
            {
                // if file cant be read
                throw new Exception($"Could not read input file '{InputFilePath}': {ex.Message}");
            }
        }

        //write result to output.txt
        public void WriteResult(double result)
        {
            try
            {
                string resultLine = $"{result:F2}";
                File.AppendAllText(OutputFilePath, resultLine + Environment.NewLine);
            }
            catch (Exception ex)
            {
                //if file cant be written
                throw new Exception($"Could not write to output file '{OutputFilePath}': {ex.Message}");
            }
        }

        //write error message to output.txt
        public void WriteError(Exception exception)
        {
            try
            {
                File.AppendAllText(OutputFilePath, exception.Message + Environment.NewLine);
            }
            catch(Exception ex)
            {
                // if file cant be written
                throw new Exception($"Could not write to output file '{OutputFilePath}': {ex.Message}");
            }
        }
    }
}