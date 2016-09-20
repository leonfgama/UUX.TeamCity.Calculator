using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UUX.TeamCity.BusinessLogic
{
    public static class Operator
    {
        public static decimal Sum(decimal firstValue, decimal secondValue)
        {
            return firstValue + secondValue;
        }

        public static decimal Subtraction(decimal firstValue, decimal secondValue)
        {
            return firstValue - secondValue;
        }

        public static decimal Multiplication(decimal firstValue, decimal secondValue)
        {
            return firstValue * secondValue;
        }

        public static decimal Division(decimal firstValue, decimal secondValue)
        {
            return firstValue / secondValue;
        }

        public static decimal ResolveOperation(string operation, decimal firstValue, decimal secondValue)
        {
            if (string.IsNullOrWhiteSpace(operation))
            {
                throw new Exception("Operação Inválida!");
            }


            switch (operation)
            {
                case "+":
                    return Sum(firstValue, secondValue);
                case "-":
                    return Subtraction(firstValue, secondValue);
                case "x":
                    return Multiplication(firstValue, secondValue);
                case "/":
                    return Division(firstValue, secondValue);
                default:
                    return 0;
            }
        }
    }
}
