using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Configuration
{
    public class CustomerPurchaseConfiguration : IEntityTypeConfiguration<CustomerPurchase>
    {
        public void Configure(EntityTypeBuilder<CustomerPurchase> builder)
        {
            builder.ToTable("CUSTOMER_PURCHASE");

            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("CUSTOMER_PURCHASE_ID");

            builder.Property(x => x.CustomerId)
                .IsRequired()
                .HasColumnName("CUSTOMER_ID");

            builder.Property(x => x.ItemId)
                .IsRequired()
                .HasColumnName("ITEM_ID");

            builder.Property(x => x.PurchaseDate)
                .IsRequired()
                .HasColumnName("PURCHASE_DATE");


        }
    }
}
