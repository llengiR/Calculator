using System;
using System.IO;

namespace Calculator.View
{
    /// <summary>
    /// Reads RPN expressions from a file and writes the result in another file.
    /// </summary>
    public class FileView
    {
        /// <summary>
        /// Input file path
        /// </summary>
        public string InputFilePath { get; }

        /// <summary>
        /// Output file path
        /// </summary>
        public string OutputFilePath{ get; }

        /// <summary>
        /// Constructor for input and output paths.
        /// </summary>
        /// <param name="inputFilePath">Where to read input expressions from.</param>
        /// <param name="outputFilePath">Where to write output (results or errors).</param>
        public FileView(string inputFilePath, string outputFilePath)
        {
            InputFilePath = inputFilePath;
            OutputFilePath = outputFilePath;
        }

        /// <summary>
        /// Read RPN expressions from file.
        /// </summary>
        /// <returns>Array of lines from file.</returns>
        /// <exception cref="Exception">Thrown if the file cant be read.</exception>
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

        /// <summary>
        /// Write result to output.txt
        /// </summary>
        /// <param name="result">The result to write in the output file.</param>
        /// <exception cref="Exception">Thrown if the output file can't be written.</exception>
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

        /// <summary>
        /// Write error message to output.txt
        /// </summary>
        /// <param name="exception">The error to write.</param>
        /// <exception cref="Exception">Thrown if the file can't be written.</exception>
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
