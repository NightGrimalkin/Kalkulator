namespace Kalkulator.models
{
    public class CalculatorData : ICalculatorData
    {
        public List<CalculatorSingleData> operation { get; set; } = new List<CalculatorSingleData>();
    }
}
