using SistemaModelos;
using SistemaNegocio;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaEmpresa.Controllers
{
    public class FornecedorController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CadastrarFornecedor(Fornecedor fornecedor)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, FornecedorNeg.CadastrarFornecedor(fornecedor));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}