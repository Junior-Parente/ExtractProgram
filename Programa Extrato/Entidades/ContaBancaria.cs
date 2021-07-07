using System.Globalization;

namespace Programa_Extrato.Entidades
{
    class ContaBancaria
    {
        public int Numero { get; private set; }
        public string Titular { get; private set; }
        public double ContaCorrente { get; private set; }
        public double ContaPoupanca { get; private set; }

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
