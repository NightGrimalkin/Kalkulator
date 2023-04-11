using Kalkulator.models;
using Microsoft.Maui.Controls;
using org.mariuszgromada.math.mxparser;
using System.Collections.ObjectModel;

namespace Kalkulator;

public partial class HistoryPage : ContentPage
{
    public ICalculatorData CalculatorData = DependencyService.Get<ICalculatorData>();

   
    public HistoryPage()
	{
		InitializeComponent();
        HistoryList.ItemsSource = CalculatorData.operation; 

    }
    
     public void HistoryGoBack(object sender, EventArgs e)
	{
        ICalculatorData tempHis = HistoryList.SelectedItem as ICalculatorData;

       
	}

    
}