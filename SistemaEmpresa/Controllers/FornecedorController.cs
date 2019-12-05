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
        public HttpResponseMessage CadastrarFornecedor([FromBody]Fornecedor fornecedor)
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

        [HttpPost]
        public HttpResponseMessage BuscarFornecedorList([FromBody]FornecedorFiltro fornecedorFiltro)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, FornecedorNeg.BuscarFornecedorList(fornecedorFiltro));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}