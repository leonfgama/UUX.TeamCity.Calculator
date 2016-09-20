using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUX.TeamCity.BusinessLogic;

namespace UUX.TeamCity.UI.CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma operação");
            Console.WriteLine("Soma [+] \nSubtração [-] \nMultiplicação [x]\nDivisão [/] :");
            string operation = Console.ReadLine();

            Console.WriteLine("Digite o primeiro valor: ");
            decimal firstValue = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            decimal secondValue = Convert.ToDecimal(Console.ReadLine());

            decimal result = Operator.ResolveOperation(operation, firstValue, secondValue);
            Console.WriteLine("O resultado é: {0} \n", result);

            Console.WriteLine("Para sair pressione alguma tecla...");
            Console.ReadLine();
        }        
    }
}
