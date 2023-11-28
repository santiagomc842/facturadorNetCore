using Entities.Items;

namespace Entities.Models
{
    public class ComprobanteRequest
    {
        //public int Id { get; set; }
        public DateTime? Fecha { get; set; }
        public string? Estado { get; set; }
        public int Cae { get; set; }
        public int Numero { get; set; }
        public int Emisor { get; set; }
        public int Receptor { get; set; }


        public ComprobanteItem ToComprobanteItem()
        { 
            var comprobanteItem = new ComprobanteItem();
            //comprobanteItem.Id = Id;
            comprobanteItem.Fecha = Fecha;
            comprobanteItem.Estado = Estado;
            comprobanteItem.Cae = Cae;
            comprobanteItem.Numero = Numero;
            comprobanteItem.Emisor = Emisor;
            comprobanteItem.Receptor = Receptor;
            
            return comprobanteItem;

        }
    }
}
