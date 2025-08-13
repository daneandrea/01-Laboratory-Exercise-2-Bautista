using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T arg1, T arg2);
    internal class CalculatorClass
    {
        public Formula<String> formula;
        public double GetSum(double num1, double num2)
        {
            return (num1 + num2);
        }
        public double GetDifference(double num1, double num2)
        {
            return (num2 - num1);   
        }
        public double GetProduct(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double GetQoutient(double num1, double num2) 
        {
            return (num1 / num2);
        }
        public event Formula<double> CalculateEvent 
        {
            add { Console.WriteLine("Added the delegate " + value); }
            remove { Console.WriteLine("Removed the delegate " + value); }
        }
    }
}
