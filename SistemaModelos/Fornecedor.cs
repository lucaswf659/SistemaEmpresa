using System;

namespace SistemaModelos
{
    public class Fornecedor
    {
        int EmpresaID { get; set; }
        public string Nome { get; set; }
        public string Documento { get; set; }
        public string RG { get; set; }
        public DateTime DtCadastro { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Telefone { get; set; }
    }
}
