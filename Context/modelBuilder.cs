using Microsoft.EntityFrameworkCore;
using AspNETProj.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AspNETProj.DatabaseContext;


public class CustomerConfiguration: IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers", option => option.HasComment("Customers Table"));
        builder.HasKey(c => c.Id);
       
        builder.Property(c => c.NationalCode)
        .IsRequired()
        .HasMaxLength(10);

        builder.HasMany<Phone>(c => c.Phones)
        .WithOne(ph => ph.customer)
        .HasForeignKey(f => f.CustomerId)
        .OnDelete(DeleteBehavior.Cascade);
        
    }
}


public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
{
    public void Configure(EntityTypeBuilder<Phone> builder)
    {
        builder.ToTable("Phones");
        builder.HasKey(c => c.Id);
        builder.HasOne<Customer>(g => g.customer)
        .WithMany(g => g.Phones)
        .HasForeignKey(f => f.CustomerId);
    }
}