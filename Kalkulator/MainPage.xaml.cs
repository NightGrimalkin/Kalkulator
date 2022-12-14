using Kalkulator.models;
using org.mariuszgromada.math.mxparser;
using System.Text.RegularExpressions;

namespace Kalkulator;

[QueryProperty(nameof(resultFromHistory), "result")]
public partial class MainPage : ContentPage
{
    public string resultFromHistory
    {
        set
        {
            string equation = value;
            Expression expression = new Expression(equation);
            double result = expression.calculate();
            EquationView.Text = result.ToString();
        }
    }
    ICalculatorData CalculatorData = DependencyService.Get<ICalculatorData>();

    public MainPage()
    {
        InitializeComponent();
    }

    private void AnyMathOperator_Clicked(object sender, EventArgs e)
    {
        string clickedOperator = (sender as Button).Text;
        string equation = EquationView.Text;
        string lastChar = equation.Substring(equation.Length - 1);
        Regex regex = new Regex(@"\d");
        string[] operatorArr = { "+", "-", "*", "/", ".", " " };

        //Jesli ostatni to znak i klikniety to nie znak
        if ((operatorArr.Contains(lastChar) && !operatorArr.Contains(clickedOperator)) || (!operatorArr.Contains(lastChar) && operatorArr.Contains(clickedOperator)) || regex.IsMatch(clickedOperator))
        {
            equation += (sender as Button).Text;
            EquationView.Text = equation;
        }

    }

    private void Clear(object sender, EventArgs e)
    {
        EquationView.Text = " ";
    }

    private void Calcualte(object sender, EventArgs e)
    {
        double result;
        string equation = EquationView.Text;
        Expression expression = new Expression(equation);
        result = expression.calculate();
        EquationView.Text = result.ToString();

        CalculatorSingleData calculatorSingleData = new CalculatorSingleData(equation + " = " + result.ToString());

        CalculatorData.operation.Add(calculatorSingleData);
    }
}

