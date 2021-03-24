using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaixaEtaria
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Exercício 2");
            Console.WriteLine("Informe sua data de nascimento - Formato DD/MM/YYYY - Dia(2), Mês(2), Ano(4)");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());
            int ano = dataNascimento.Year;
            Console.WriteLine("Ano de nascimento: " + dataNascimento.ToString("dd/MM/yyyy") + "\nVocê é um " + calcularIdade(ano));
            Console.ReadLine();
        }




        public static string calcularIdade(int ano)
        {
            int dataAtual = DateTime.Today.Year;
            int idade = dataAtual - ano;
            if(idade <= 19)
            {
                return "Jovem";
            } else if(idade > 19 && idade < 60)
            {
                return "Adulto";
            } else
            {
                return "Idoso";
            }
            
        }
    }
}
