using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPTest.Models
{
    public class MainModel :IModel
    {
        public uint FirstNumber { get; set; }
        public uint SecondNumber { get; set; }
        public uint Result { get; set; } = 0;
        public MainModel(uint firstNumber, uint secondNumber)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
        }
        public void Div()
        {
            Result = DividerUint.Divider.Div(FirstNumber, SecondNumber);
        }
    }
}
