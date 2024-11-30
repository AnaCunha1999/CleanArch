using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Configuration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("CUSTOMER");

            builder.HasKey(x => x.Customer_Id);
            builder.Property(x => x.Customer_Id)
                .IsRequired()
                .HasColumnName("CUSTOMER_ID");

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("NAME");
            
            builder.Property(x => x.Email)
                .IsRequired()
                .HasColumnName("EMAIL");
            
            builder.Property(x => x.Phone)
                .IsRequired()
                .HasColumnName("PHONE");
            
            builder.Property(x => x.Adress)
                .IsRequired()
                .HasColumnName("ADRESS");
            
            builder.Property(x => x.City)
                .IsRequired()
                .HasColumnName("CITY");
        }
    }
}
