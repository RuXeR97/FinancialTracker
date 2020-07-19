using FinancialTracker.Core.Services;
using FinancialTracker.Core.ViewModels;
using MvvmCross;
using MvvmCross.ViewModels;

namespace FinancialTracker.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            Mvx.IoCProvider.RegisterType<ICalculationService, CalculationService>();

            RegisterAppStart<TipViewModel>();
        }
    }
}
