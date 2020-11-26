using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class MyCalculatorClass
    {
        // private member
        /// <summary>
        /// 
        /// </summary>
        char[] _supportedOperations = new char[] { '+', '-', '*', '/','^' };


        public MyCalculatorClass()
        {

        }

        /// <summary>
        /// please comment the function
        /// </summary>
        /// <returns></returns>
        public string SupportedOperations()
        {
            string text = string.Empty;
            for (int i = 0; i < _supportedOperations.Length; i++)
            {
                text = text + _supportedOperations[i] + " ";
            }
            return text;
        }

        public double Calculate(double Number1,double Number2,char operation)
        {
            double Result = 0.0;
            switch (operation)
            {
                case '+': Result = Add(Number1, Number2); break;
                //case '-': Result = Sub(Number1, Number2); break;
            }

            return Result;
        }

        // ADD
        /// <summary>
        /// please comment the function 
        /// </summary>
        /// <param name="Number1"></param>
        /// <param name="Number2"></param>
        /// <returns></returns>
        private double Add(double Number1, double Number2)
        {
            double result = Number1 + Number2;
            return result;
        }

        // SUB
        // MULTI
        // DIV
    }
}
