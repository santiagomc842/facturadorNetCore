using API.Facturador.IServices;
using Entities.Items;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Facturador.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ComprobanteController : ControllerBase
    {
        private readonly IComprobanteService _comprobanteService;
        public ComprobanteController(IComprobanteService comprobanteService)
        {
            _comprobanteService = comprobanteService;
        }

        [HttpPost(Name = "InsertarComprobante")]
        public int InsertarComprobante(ComprobanteRequest newComprobanteRequest)
        {
            return _comprobanteService.RegisterNewComprobante(newComprobanteRequest);
        }
        [HttpPut(Name = "UpdateComprobante")]
        public int UpdateComprobante(ComprobanteRequest newComprobanteRequest)
        {
            return _comprobanteService.UpdateComprobante(newComprobanteRequest);
        }
        [HttpDelete(Name = "DeleteComprobante")]
        public int DeleteComprobante(ComprobanteRequest newComprobanteRequest)
        {
            return _comprobanteService.DeleteComprobante(newComprobanteRequest);
        }
        [HttpGet(Name = "GetAllComprobantes")]
        public List<ComprobanteItem> GetAllComprobantes()
        {
            return _comprobanteService.GetAllComprobantes();
        }
    }
}
