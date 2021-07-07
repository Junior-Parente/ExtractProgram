using System;
using Programa_Extrato.Entidades;

     
namespace Programa_Extrato
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaBancaria contaprimo = new ContaBancaria (1,"Robson Alves", 1000.00, 0.0);

            Console.WriteLine(contaprimo);

        }
    }
}
