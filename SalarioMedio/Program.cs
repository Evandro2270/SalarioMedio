using System;
using System.Globalization;
using System.Net.Http.Headers;
namespace Programa
{
    class Program
    {
        static void Main(string[] args)
        {
            {

                CultureInfo CI = CultureInfo.InvariantCulture;

                string nome1, nome2;
                double salario1, salario2, media;
                Console.WriteLine("Dados do primeiro funcionario: ");
               
                Console.Write("Nome: ");
                nome1 = Console.ReadLine();
                Console.Write("Salario: ");
                salario1 = double.Parse(Console.ReadLine(), CI);
                
                Console.WriteLine("Dados do segundo funcionario: ");
                Console.Write("Nome: ");
                nome2 = Console.ReadLine();
                Console.Write("Salario: ");
                salario2 = double.Parse(Console.ReadLine(), CI);

                media = (salario1 + salario2) / 2;
                Console.WriteLine("Salario medio do funcionarios: " + nome1 + " e " + nome2 + " é de " + media.ToString("F2", CI));
             }
        }
    }
}