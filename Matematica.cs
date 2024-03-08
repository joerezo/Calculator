using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4_2Calculator
{
    internal interface IMath
    {
        double Add(double num1, double num2);
        double Subtract(double num1, double num2);
        double Multiply(double num1, double num2);
        double Divide(double num1, double num2);
    }


    public delegate double AddingOperations(double val1, double val2);
    public delegate double SubtractingOperations(double val1, double val2);
    public delegate double DividingOperations(double val1, double val2);
    public delegate double MultiplicationOperations(double val1, double val2);

    public delegate double UrnaryOperations(double val);
    public class Matematica : IMath
    {
        public double numericValue { get; set; }

        public double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

        public double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }



        public double Square(double num1)
        {
            return num1 * num1;
        }
        public double SquRoot(double num1)
        {
            return Math.Sqrt(num1);
        }

    }
}
