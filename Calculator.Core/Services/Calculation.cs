using System;
namespace Calculator.Core.Services
{
    public class Calculation : ICalculation
    {
        public Calculation()
        {
        }

        public double Operation(double firstNumber, double secondNumber, string Operand)
        {
            switch (Operand)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "*":
                    return firstNumber * secondNumber;
                case "/":
                    return firstNumber / secondNumber;
                default:
                    return firstNumber + secondNumber;
            }
        }
    }
}
