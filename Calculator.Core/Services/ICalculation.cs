using System;
namespace Calculator.Core.Services
{
    public interface ICalculation
    {
        double Operation(double FirstNumber, double SecondNumber, string Operand);
    }
}
