using Microsoft.EntityFrameworkCore;
using AspNETProj.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace AspNETProj.DatabaseContext;


public class CustomerConfiguration: IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("Customers", "dbo", option => option.HasComment("Customer Table"));
        
        builder.Property("Id")
        .HasComment("Id Field");

        builder.HasKey("Id");

        builder.Property("NationalCode")
        .IsRequired();

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
        builder.ToTable("Phone");
        builder.HasKey("Id");
        builder.HasOne<Customer>(g => g.customer)
        .WithMany(g => g.Phones)
        .HasForeignKey(f => f.CustomerId);
    }
}