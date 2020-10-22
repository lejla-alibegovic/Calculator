using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class CalculationModel
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public long Result { get; set; } = 0;
        public Operation Operations {get;set;}
    }
    public enum Operation
    {
        Add,
        Substract,
        Multiply
    }
}
