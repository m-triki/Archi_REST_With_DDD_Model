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
    using System;

    class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", IdentityContext.DEFAULT_SCHEMA);

            builder.HasKey(o => o.Id);

            builder
                .Property<string>("firstName")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("FirstName")
                .IsRequired();

            builder
                .Property<string>("lastName")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("LastName")
                .IsRequired();

            builder
                .Property<string>("email")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Email")
                .IsRequired();

            builder
                .Property<string>("jwt")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Jwt")
                .IsRequired();

            builder
                .Property<string>("username")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Username")
                .IsRequired();

            builder
                .Property<string>("password")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("Password")
                .IsRequired();

            builder
                .Property<Guid>("roleId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("RoleId")
                .IsRequired(true);

            builder
                .Property<int>("statusId")
                .UsePropertyAccessMode(PropertyAccessMode.Field)
                .HasColumnName("StatusId")
                .IsRequired();

            builder.HasOne<Role>()
                .WithMany()
                .IsRequired(true)
                .HasForeignKey("roleId");

            builder.HasOne(o => o.Status)
                .WithMany()
                .HasForeignKey("statusId");

            builder.HasIndex("Id")
              .IsUnique(true);
        }
    }
}
