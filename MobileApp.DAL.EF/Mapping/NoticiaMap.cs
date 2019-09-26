using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MobileApp.Domain.Classes;

namespace MobileApp.DAL.EF.Mapping
{
    public class NoticiaMap : IEntityTypeConfiguration<Noticia>
    {
        public void Configure(EntityTypeBuilder<Noticia> builder)
        {
            builder.ToTable("sintalocas.noticia");

            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Titulo).HasColumnName("titulo");
            builder.Property(x => x.DataCadastro).HasColumnName("dtcad");
            builder.Property(x => x.DELETED).HasColumnName("deleted");
            builder.Property(x => x.Texto).HasColumnName("texto");

        }
    }
}
