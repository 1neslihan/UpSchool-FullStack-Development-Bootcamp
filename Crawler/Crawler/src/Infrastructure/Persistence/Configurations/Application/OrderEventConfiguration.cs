﻿using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistence.Configurations.Application
{
    public class OrderEventConfiguration : IEntityTypeConfiguration<OrderEvent>
    {
        public void Configure(EntityTypeBuilder<OrderEvent> builder)
        {
            //Id 
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            //OrderEventId
            //builder.HasKey(x => x.OrderId);
            //builder.Property(x => x.OrderId).IsRequired();

            //Order Status
            builder.Property(x => x.Status)
                .HasConversion<int>();

            //CreatedOn
            builder.Property(x => x.CreatedOn).IsRequired();

            //ModifiedOn
            builder.Property(x => x.ModifiedOn).IsRequired(false);

            //DeletedOn
            builder.Property(x => x.DeletedOn).IsRequired(false);

            //IsDeleted
            builder.Property(x => x.IsDeleted).IsRequired();
            builder.Property(x => x.IsDeleted).HasDefaultValueSql("0");
            builder.HasIndex(x => x.IsDeleted);

            builder.ToTable("OrderEvents");

        }
    }
}