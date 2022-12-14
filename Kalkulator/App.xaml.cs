using Kalkulator.models;

namespace Kalkulator;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        DependencyService.Register<ICalculatorData, CalculatorData>();

        MainPage = new AppShell();
    }
}
