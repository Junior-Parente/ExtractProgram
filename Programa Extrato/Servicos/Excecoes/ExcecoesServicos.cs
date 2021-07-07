using System;

namespace Programa_Extrato.Servicos.Excecoes
{
    class ExcecoesServicos : ApplicationException
    {
        public ExcecoesServicos(string message) : base(message)
        {
        }
    }
}
