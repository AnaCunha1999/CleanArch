using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Configuration
{
    public class PurchaseItemConfiguration : IEntityTypeConfiguration<PurchaseItem>
    {
        public void Configure(EntityTypeBuilder<PurchaseItem> builder)
        {
            builder.ToTable("PURCHASE_ITEM");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id)
                .IsRequired()
                .HasColumnName("PURCHASE_ITEM_ID");
            
            builder.Property(x => x.ItemName)
                .IsRequired()
                .HasColumnName("ITEM_NAME");            
            
            builder.Property(x => x.ItemDescription)
                .IsRequired()
                .HasColumnName("ITEM_DESCRIPTION"); 
            
            builder.Property(x => x.ItemPrice)
                .IsRequired()
                .HasColumnName("ITEM_PRICE");
        }
    }
}
