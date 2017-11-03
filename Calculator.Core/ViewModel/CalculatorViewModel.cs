using System;
using System.Collections.Generic;
using System.Windows.Input;
using Calculator.Core.Services;
using MvvmCross.Core.ViewModels;

namespace Calculator.Core.ViewModel
{
    public class CalculatorViewModel : MvxViewModel
    {
        ICalculation calculation;
        public CalculatorViewModel(ICalculation calculation)
        {
            this.calculation = calculation;
        }

        public override void Start()
        {
            FirstNum = 10;
            SecondNum = 10;
            ReCalculate();
            base.Start();
        }

        double firstNum;
        public double FirstNum
        {
            get { return firstNum; }
            set
            {
                firstNum = value;
                RaisePropertyChanged(() => FirstNum);
                ReCalculate();
            }
        }


        double secondNum;
        public double SecondNum
        {
            get { return secondNum; }
            set
            {
                secondNum = value;
                RaisePropertyChanged(() => SecondNum);
                ReCalculate();
            }
        }

        double answer;
        public double Answer
        {
            get { return answer; }
            set
            {
                answer = value;
                RaisePropertyChanged(() => Answer);
            }
        }

        private List<String> _arithmeticOperations = new List<string>(new String[] {
            "+", "-", "*", "/"
        });
        public List<String> ArithmeticOperations
        {
            get
            {
                return _arithmeticOperations;
            }
        }

        private string _arithmeticOperation;
        public string ArithmeticOperation
        {
            get { return _arithmeticOperation; }
            set
            {
                _arithmeticOperation = value;
                RaisePropertyChanged(() => ArithmeticOperation);
                ReCalculate();
            }
        }

        public void ReCalculate()
        {
            Answer = calculation.Operation(FirstNum, SecondNum, ArithmeticOperation);
        }

        public ICommand NegateCommand
        {
            get
            {
                return new MvxCommand(() => FirstNum *= -1);
            }
        }

        public ICommand NegateCommandB
        {
            get
            {
                return new MvxCommand(() => SecondNum *= -1);
            }
        }

        public ICommand Square
        {
            get
            {
                return new MvxCommand(() => Answer *= Answer);
            }
        }

        public ICommand SquareRoot
        {
            get
            {
                return new MvxCommand(() => Answer = Math.Sqrt(Answer));
            }
        }



    }
}
