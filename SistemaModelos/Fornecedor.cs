using System;

namespace SistemaModelos
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string RG { get; set; }
        public DateTime? DtCadastro { get; set; }
        public DateTime? DtNascimento { get; set; }
        public string Telefone { get; set; }
    }
}
