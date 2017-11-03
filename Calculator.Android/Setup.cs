using Android.Content;
using Calculator.Core;
using MvvmCross.Core.ViewModels;
using MvvmCross.Droid.Platform;

namespace Calculator.Android
{
    public class Setup : MvxAndroidSetup
    {
        public Setup(Context applicationContext) : base(applicationContext)
        {
        }

        protected override IMvxApplication CreateApp()
        {
            return new App();
        }
    }
}
