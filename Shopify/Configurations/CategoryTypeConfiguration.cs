using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Shopify.Configrations
{
    public class CategoryTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Name).IsRequired();
            builder.Property(p => p.Name).HasMaxLength(50);
            builder.Property(p => p.CreatedOn).HasDefaultValueSql("GETDATE()");  
        }
    }
}
