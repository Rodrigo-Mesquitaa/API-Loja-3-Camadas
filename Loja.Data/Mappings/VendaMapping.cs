using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Loja.Data.Mappings
{

    public class VendaMapping : IEntityTypeConfiguration<Venda>
    {

        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(v => v.Id);

            builder.Property(p => p.Observacoes)
                .HasColumnType("varchar(500)");
        }
    }
}