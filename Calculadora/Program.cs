using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Calculadora");
                Console.WriteLine("Informe o primeiro número: ");
                decimal n1 = Console.ReadLine().ToDecimal();

                Console.WriteLine("Informe o segundo número: ");
                decimal n2 = Console.ReadLine().ToDecimal();

                Console.WriteLine("Informe a operação matemática");
                Console.WriteLine(" + Somar \n - Subtrair \n * Multiplicação \n / Divisão \n % Resto divisão");
                string operacao = Console.ReadLine();
                Console.WriteLine("");

                Console.WriteLine("Resultado: " + Calcular(n1, n2, operacao));
                Console.ReadLine();
            }           
            catch(Exception erro)
            {
                Console.WriteLine("Operação ou valor informados inválido. \n" + erro);
            }

        }

        public static decimal Calcular(decimal valor1, decimal valor2, string operacao)
        {
            if (operacao.Equals("+"))
            {
                return valor1 + valor2;
            } else if (operacao.Equals("-"))
            {
                return valor1 - valor2;
            } else if (operacao.Equals("*"))
            {
                return valor1 * valor2;
            } else if (operacao.Equals("/"))
            {   
                if (valor2 != 0)
                {
                    return valor1 / valor2;
                }
                else
                {
                    return 0;
                }
                
            } else
            {
                if (valor2 != 0)
                {
                    return (valor1 % valor2);
                }
                else
                {
                    return 0;
                }
                
            }
        }



        
    }
    internal static class StringExtensions
    {
        internal static decimal ToDecimal(this string valor)
        {
            return decimal.Parse(valor);
        }
    }
}
