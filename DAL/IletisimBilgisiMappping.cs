using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL
{
    public class IletisimBilgisiMappping : IEntityTypeConfiguration<IletisimBilgisi>
    {
        public void Configure(EntityTypeBuilder<IletisimBilgisi> builder)
        {
            builder.ToTable("IletisimBilgileri");
            builder.HasKey(y => y.PersonelID);
            builder.Property(y=> y.Eposta).HasColumnType("nvarchar").HasMaxLength(75);
            builder.Property(y=> y.Telefon).HasColumnType("varchar").HasMaxLength(15);
            builder.Property(y=> y.Adres).HasMaxLength(255);
            builder.Property(y => y.TestString);
        }
    }
}
