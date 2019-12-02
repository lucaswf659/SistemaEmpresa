using System;

namespace SistemaModelos
{
    public class Fornecedor
    {
        Empresa empresa { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }
        public DateTime DtCadastro { get; set; }
        public string Telefone { get; set; }
    }
}
