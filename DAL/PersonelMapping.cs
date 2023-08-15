using DATA;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL
{
    public class PersonelMapping : IEntityTypeConfiguration<Personel>
    {
        public void Configure(EntityTypeBuilder<Personel> builder)
        {
            builder.ToTable("Personeller");

            builder.HasKey(x => x.PersonelID);

            builder.Property(x => x.Isim).IsRequired().HasMaxLength(30);
            builder.Property(x => x.Soyisim).IsRequired().HasMaxLength(50);
            builder.Property(x => x.TCKimlikNo).IsRequired().HasMaxLength(11).HasColumnType("char");
            builder.Property(x => x.DogumTarihi).HasColumnType("datetime2");
            builder.Property(x => x.Birim).IsRequired().HasMaxLength(20);

            builder.Ignore(x => x.IsimSoyisim);

            builder.HasOne(x => x.IletisimBilgisi).WithOne(x => x.Personel);
        }
    }
}
