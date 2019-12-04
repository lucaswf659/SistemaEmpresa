using SistemaDados;
using SistemaModelos;
using System;

namespace SistemaNegocio
{
    public class EmpresaNeg
    {
        public static bool CadastrarEmpresa(Empresa empresa)
        {
            try
            {
                return EmpresaDD.CadastrarEmpresa(empresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Empresa BuscarEmpresa(int idEmpresa)
        {
            try
            {
                return EmpresaDD.BuscarEmpresa(idEmpresa);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
