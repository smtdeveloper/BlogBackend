using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Concrete.EntityFramework.Configurations
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.SecondaryId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.ArticleId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Content).IsRequired();
            builder.Property(p => p.IsApproved).IsRequired(false);

            builder.Property(p => p.IsDeleted).IsRequired().HasDefaultValue(false);
            builder.HasQueryFilter(p => p.IsDeleted == false);



        }

    }
}
