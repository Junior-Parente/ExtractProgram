using System.Globalization;
using Programa_Extrato.Servicos.Excecoes;

namespace Programa_Extrato.Entidades
{
    class ContaBancaria 
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double ContaCorrente { get; protected set; }
        public double ContaPoupanca { get; protected set; }

        public ContaBancaria()
        {
        }

        public ContaBancaria(int numero, string titular, double contacorrente)
        {
            Numero = numero;
            Titular = titular;
            ContaCorrente = contacorrente;
        }

        public ContaBancaria(int numero, string titular, double contacorrente, double contapoupanca) : this (numero,titular,contacorrente)
        {            
            ContaPoupanca = contapoupanca;
        }

        public void Deposito(double valor)
        {
            ContaCorrente += valor;
        }
        public void Saque(double valor)
        {
            ContaCorrente -= valor;
        }
        public void Investimento(double valor)
        {
                ContaCorrente -= valor;
                ContaPoupanca += valor;
        }
        public void Retirada(double valor)
        {
                ContaPoupanca -= valor;
                ContaCorrente += valor;
        }

        public override string ToString()
        {
            return "Conta "
                + Numero 
                + "\n Titular: "
                + Titular
                + "\n Saldo CC: $ "
                + ContaCorrente.ToString("F2", CultureInfo.InvariantCulture)
                + "\n Poupanca: $ "
                + ContaPoupanca.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
