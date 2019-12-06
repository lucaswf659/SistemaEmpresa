using SistemaModelos;
using SistemaNegocio;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SistemaEmpresa.Controllers
{
    public class EmpresaController : ApiController
    {
        [HttpPost]
        public HttpResponseMessage CadastrarEmpresa([FromBody]Empresa empresa)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, EmpresaNeg.CadastrarEmpresa(empresa));
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

       
    }
}