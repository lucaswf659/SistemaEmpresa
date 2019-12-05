using SistemaModelos;
using SistemaNegocio;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaEmpresa.Controllers
{
    public class EmpresaFornecedorController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CadastrarEmpresaFornecedor([FromBody]EmpresaFornecedor empresaFornecedor)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, EmpresaFornecedorNeg.CadastrarEmpresaFornecedor(empresaFornecedor));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

    }
}