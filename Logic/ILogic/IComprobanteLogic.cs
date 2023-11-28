using Entities.Items;


namespace Logic.ILogic
{
    public interface IComprobanteLogic
    {
        int InsertComprobante(ComprobanteItem comprobanteItem);
        List<Entities.Items.ComprobanteItem> GetAllComprobantes();
        int UpdateComprobante(ComprobanteItem newComprobante);
        int DeleteComprobante(ComprobanteItem newComprobante);
        int GetLastID();
    }
}
