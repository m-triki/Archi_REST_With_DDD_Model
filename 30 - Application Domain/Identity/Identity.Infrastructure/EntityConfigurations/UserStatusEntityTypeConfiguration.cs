//-----------------------------------------------------------------
// <copyright file="UserStatusEntityTypeConfiguration.cs" company="Smart Solution">
// Copyright (c) Suez. All rights reserved.
// </copyright>
//-----------------------------------------------------------------

using Identity.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Identity.Infrastructure
{
    class UserStatusEntityTypeConfiguration : IEntityTypeConfiguration<UserStatus>
    {
        public void Configure(EntityTypeBuilder<UserStatus> builder)
        {
            builder.ToTable("UserStatus", IdentityContext.DEFAULT_SCHEMA);

            builder.HasKey(o => o.Id);

            builder.Property(o => o.Id)
                .HasDefaultValue(1)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(o => o.Name)
                .HasMaxLength(200)
                .IsRequired();
        }
    }
}
