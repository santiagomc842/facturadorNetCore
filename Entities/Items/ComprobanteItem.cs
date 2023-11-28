
namespace Entities.Items
{
    public class ComprobanteItem
    {
        public int Id { get; set; }
        public DateTime? Fecha{ get; set; }
        public string? Estado { get; set; }
        public int Cae { get; set; }
        public int Numero { get; set; }
        public int Emisor { get; set; }
        public int Receptor { get; set; }
    }
}
