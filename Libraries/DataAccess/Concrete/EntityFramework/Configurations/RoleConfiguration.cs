using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Configurations

{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.SecondaryId).IsRequired().ValueGeneratedOnAdd();
            builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
            builder.Property(p => p.IsDeleted).IsRequired().HasDefaultValue(false);
            builder.Property(p => p.CreatedAt).IsRequired();
            builder.Property(p => p.UpdatedAt).IsRequired(false);
            builder.Property(p => p.DeletedAt).IsRequired(false);

           
            builder.HasQueryFilter(p => p.IsDeleted == false);
        }
    }