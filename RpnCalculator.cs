using System;
using System.Collections.Generic;
using Calculator.Model.Tokens;
using Calculator.Model.Exceptions;
using InvalidOperationException = Calculator.Model.Exceptions.InvalidOperationException;
namespace Calculator.Model
{
    // handles RPN calc
    public class RpnCalculator
    {
        // stack to store tokens
        private IStack<Token> stack;

        //constructor creates calc with empty stack
        public RpnCalculator()
        {
            // creates new instance
            stack = new Stack<Token>();
        }

        //takes rpn string and returns results
        public double Calculate(string rpnExpression)
        {
            if(string.IsNullOrWhiteSpace(rpnExpression))
            {
                throw new InvalidTokenException("Empty expression");
            }

            //split string into induvial token and convert token objects
            Token[] tokens = ParseTokens(rpnExpression);

            //push all tokens onto stack
            foreach (Token token in tokens)
            {
                stack.Push(token);
            }

            //process tokens using RPN
            double result = ProcessTokens();
            return result;
        }

        // split RPN string to tokens
        private Token[] ParseTokens(string expression)
        {
            string[] parts = expression.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Token[] tokens = new Token[parts.Length];

            // convert each string part to the right token
            for(int i = 0; i < parts.Length; i++)
            {
                tokens[i] = CreateToken(parts[i]);
            }
            return tokens;   
        }

        // Convert string to token
        private Token CreateToken(string tokenString)
        {
            // try parse as number
            if(double.TryParse(tokenString, out double number))
            {
                return new Operand(number);
            }

            //check if its a valid operator
            switch(tokenString)
            {
                case "+":
                return new SumOperator();

                case "-":
                return new SubtractOperator();

                case "*":
                return new MultiplyOperator();

                case "/":
                return new DivideOperator();

                case "%":
                return new ModulusOperator();

                default:
                throw new InvalidTokenException(tokenString);
            }
        }

        //process token using RPN Algorithm
        private double ProcessTokens()
        {
            // Create a separate stack for values
            IStack<double> valueStack = new Stack<double>();

            // Get all tokens back 
            Token[] tokensInOrder = GetTokensInOriginalOrder();

            // Process each token 
            foreach (Token token in tokensInOrder)
            {
                if (token is Operand operand)
                {
                    // Push operand value onto value stack 
                    valueStack.Push(operand.Value);
                }
                else if (token is Operator op)
                {
                    // Need at least 2 values 
                    if (valueStack.Count < 2)
                    {
                        throw new InvalidOperationException();
                    }

                    // Pop two values
                    double right = valueStack.Pop();
                    double left = valueStack.Pop();

                    // Calculate and push result back
                    double result = op.Calculate(left, right);
                    valueStack.Push(result);
                }
            }
            if (valueStack.Count != 1)
            {
                throw new InvalidOperationException();
            }

            return valueStack.Pop();
        }

        // Helper method to get tokens in original left-to-right order
        private Token[] GetTokensInOriginalOrder()
        {

            List<Token> tokenList = new List<Token>();

            // Pop all tokens 
            while (!stack.IsEmpty)
            {
                tokenList.Add(stack.Pop());
            }

            // Reverse the list to get original order
            tokenList.Reverse();

            return tokenList.ToArray();
        }
    }
}