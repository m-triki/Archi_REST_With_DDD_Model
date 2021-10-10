//-----------------------------------------------------------------
// <copyright file="UserEntityTypeConfiguration.cs" company="Smart Solution">
// Copyright (c) Suez. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

namespace Identity.Infrastructure
{
    using Identity.Domain;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    class RoleEntityTypeConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role", IdentityContext.DEFAULT_SCHEMA);

            builder.HasKey(o => o.Id);
            
            builder.Property<string>("label")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Label")
                .IsRequired();

            builder.Property<string>("description")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Description")
                .IsRequired();

            builder.HasIndex("Id")
              .IsUnique(true);

        }
    }
}
