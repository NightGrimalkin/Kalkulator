using Kalkulator.models;
using Microsoft.Maui.Controls;

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
