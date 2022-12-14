using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator.models
{
    public class CalculatorSingleData
    {
        public string operation { get; set; }
        public CalculatorSingleData(string operation) { 
            this.operation = operation;
        }
    }
}
