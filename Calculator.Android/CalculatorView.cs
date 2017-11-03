
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Calculator.Core.ViewModel;
using MvvmCross.Droid.Views;

namespace Calculator.Android
{
    [Activity(Label = "Numbers", MainLauncher = true)]
    public class CalculatorView : MvxActivity
    {
        public new CalculatorViewModel ViewModel
        {
            get { return (CalculatorViewModel)base.ViewModel; }
            set
            {
                base.ViewModel = value;
            }
        }

        protected override void OnViewModelSet()
        {
            SetContentView(Resource.Layout.Calculator_View);
        }
    }
}
