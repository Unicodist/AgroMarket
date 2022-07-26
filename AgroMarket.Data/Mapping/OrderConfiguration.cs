﻿using AgroMarket.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroMarket.Data.Mapping
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            _ = builder.ToTable("order");
            _ = builder.HasKey(a => a.Id);
            _ = builder.Property(a => a.Id).HasColumnName("order_id");
            _ = builder.Property(a => a.Date).HasColumnName("order_date");
            _ = builder.Property(a => a.OrderedByUserId).HasColumnName("order_orderbyuserid");
            
            _ = builder.HasOne(a => a.OrderedBy).WithMany().HasForeignKey(a=>a.OrderedByUserId);
        }
    }
}
