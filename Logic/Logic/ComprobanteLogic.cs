using Entities.Items;
using Data;
using Logic.ILogic;

namespace Logic.Logic
{
    public class ComprobanteLogic : IComprobanteLogic
    {
        private readonly ServiceContext _serviceContext;
        public ComprobanteLogic(ServiceContext serviceContext)
        {
            _serviceContext = serviceContext;
        }

        public int DeleteComprobante(ComprobanteItem newComprobante)
        {
            _serviceContext.Comprobantes.Remove(newComprobante);
            _serviceContext.SaveChanges();
            return newComprobante.Id;
        }
        public int UpdateComprobante(ComprobanteItem newComprobante)
        {

            _serviceContext.Comprobantes.Update(newComprobante);
            _serviceContext.SaveChanges();
            return newComprobante.Id;
        }

        public List<ComprobanteItem> GetAllComprobantes()
        {
            return _serviceContext.Comprobantes.ToList();
        }

        public int InsertComprobante(ComprobanteItem comprobanteItem)
        {
            _serviceContext.Comprobantes.Add(comprobanteItem);
            _serviceContext.SaveChanges();
            return comprobanteItem.Id;
        }
        public int GetLastID()
        {
            return _serviceContext.Comprobantes.Max(ComprobanteItem => ComprobanteItem.Id);
        }
    }
}
