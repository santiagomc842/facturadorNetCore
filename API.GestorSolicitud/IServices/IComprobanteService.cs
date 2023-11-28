using Entities.Items;
using Entities.Models;

namespace API.Facturador.IServices
{
    public interface IComprobanteService
    {
        int RegisterNewComprobante(ComprobanteRequest newComprobanteRequest);
        int UpdateComprobante(ComprobanteRequest newComprobanteRequest);
        int DeleteComprobante(ComprobanteRequest newComprobanteRequest);
        List<ComprobanteItem> GetAllComprobantes();
    }
}
