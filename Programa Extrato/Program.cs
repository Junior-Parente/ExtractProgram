using System;
using System.Globalization;
using Programa_Extrato.Entidades;
using Programa_Extrato.Servicos.Excecoes;

     
namespace Programa_Extrato
{
    class Program 
    {
        static void Main(string[] args)
        {
            ContaBancaria contaprimo = new ContaBancaria(1, "Robson Alves", 1000.00, 0.0);

            Console.Write("Selecione transacao que gostaria de efetuar \n 1- Saque \n 2- Deposito \n 3- Extrato \n 4- Transferir Poupanca \n 5- Retirar Poupanca \n 6- Sair\n\n");
            int opcao = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);                      

            while (opcao != 6)
            {
                while (opcao < 1 || opcao > 7)
                {
                    Console.WriteLine("Por favor digite uma das opcoes acima: ");
                    opcao = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
                try
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("\nDigite um valor para Saque: ");
                            double v1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            contaprimo.Saque(v1);
                            Console.WriteLine("Saque de " + v1 + " realizado, novo saldo: " + contaprimo.ContaCorrente);
                            break;

                        case 2:
                            Console.WriteLine("\nDigite um valor para o Deposito: ");
                            double v2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            contaprimo.Deposito(v2);
                            Console.WriteLine("Deposito de " + v2 + " realizado, novo saldo: " + contaprimo.ContaCorrente);
                            break;

                        case 3:
                            Console.WriteLine("\nSaldo Atual: \nSaldo Conta Corrente: " + contaprimo.ContaCorrente  + "\nSaldo Conta Poupanca: " + contaprimo.ContaPoupanca);
                            break;

                        case 4:
                            Console.WriteLine("\nDigite um valor a ser investido: ");
                            double v4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            contaprimo.Investimento(v4);
                            Console.WriteLine("Transferencia de " + v4 + " da conta corrente para a conta poupanca:\n" + "Conta Corrente: " + contaprimo.ContaCorrente + "\nContaPoupanca: " + contaprimo.ContaPoupanca);
                            break;

                        case 5:
                            Console.WriteLine("\nDigite um valor a ser Resgatado: ");
                            double v5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                            contaprimo.Retirada(v5);
                            Console.WriteLine("Transferencia de " + v5 + " da Conta Poupanca para a Conta Corrente:\n" + "Conta Corrente: " + contaprimo.ContaCorrente + "\nContaPoupanca: " + contaprimo.ContaPoupanca);
                            break;
                    }                              
                    Console.WriteLine("\nDeseja efetuar outra transacao? ");                  
                }              
                catch (ExcecoesServicos e)
                {
                    Console.WriteLine("Erro na solicitação " + e.Message);
                }
                opcao = int.Parse(Console.ReadLine());
            }
        }
    }
}
