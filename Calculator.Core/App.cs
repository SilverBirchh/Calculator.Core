using System;
using Calculator.Core.Services;
using Calculator.Core.ViewModel;
using MvvmCross.Core.ViewModels;
using MvvmCross.Platform;

namespace Calculator.Core
{
    public class App : MvxApplication
    {
        public App()
        {
            Mvx.RegisterType<ICalculation, Calculation>();
            Mvx.RegisterSingleton<IMvxAppStart>(new MvxAppStart<CalculatorViewModel>());
        }
    }
}
