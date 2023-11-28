using API.Facturador.IServices;
using Entities.Items;
using Entities.Models;
using Logic.ILogic;

namespace API.Facturador.Services
{
    public class ComprobanteService : IComprobanteService
    {
        private readonly IComprobanteLogic _comprobanteLogic;

        public ComprobanteService(IComprobanteLogic comprobanteLogic)
        {
            _comprobanteLogic = comprobanteLogic;
        }

        public List<ComprobanteItem> GetAllComprobantes()
        {
            return _comprobanteLogic.GetAllComprobantes();
        }

        public int RegisterNewComprobante(ComprobanteRequest newComprobanteRequest)
        {
            ComprobanteItem newComprobante = newComprobanteRequest.ToComprobanteItem();
            newComprobante.Id = _comprobanteLogic.GetLastID() +1;
            return _comprobanteLogic.InsertComprobante(newComprobante);       
        }

        public int UpdateComprobante(ComprobanteRequest newComprobanteRequest)
        {
            ComprobanteItem newComprobante = newComprobanteRequest.ToComprobanteItem();

            return _comprobanteLogic.UpdateComprobante(newComprobante);
        }

        public int DeleteComprobante(ComprobanteRequest newComprobanteRequest)
        {
            ComprobanteItem newComprobante = newComprobanteRequest.ToComprobanteItem();
            return _comprobanteLogic.DeleteComprobante(newComprobante);
        }
    }
}
