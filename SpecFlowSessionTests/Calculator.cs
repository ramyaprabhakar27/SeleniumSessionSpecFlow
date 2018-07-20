using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowSessionTests
{
    public class Calculator
    {
        private int firstNumber;
        private int secondNumber;

        public int FirstNumber { get => firstNumber; set => firstNumber = value; }
        public int SecondNumber { get => secondNumber; set => secondNumber = value; }

        public int Add ()
        {
            return firstNumber + secondNumber;
        }

        public int Multiply()
        {
            return firstNumber * secondNumber;
        }
    }
}
