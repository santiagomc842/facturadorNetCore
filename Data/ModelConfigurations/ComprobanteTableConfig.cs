using Entities.Items;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Oracle.EntityFrameworkCore;

namespace Data.ModelConfigurations
{
    public class ComprobanteTableConfig:IEntityTypeConfiguration<ComprobanteItem>
    {
        public void Configure(EntityTypeBuilder<ComprobanteItem> e)
        {
            e.ToTable("COMPROBANTES");
            e.Property(e => e.Id).ValueGeneratedNever();
        }
    }
}