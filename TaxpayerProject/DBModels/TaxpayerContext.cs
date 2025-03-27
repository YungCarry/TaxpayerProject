using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TaxpayerProject.Models;

namespace TaxpayerProject.DBModels;

public partial class TaxpayerContext : DbContext
{
    public TaxpayerContext()
    {
    }

    public TaxpayerContext(DbContextOptions<TaxpayerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Taxpayers> taxpayer { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=taxpayer.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Taxpayers>(entity =>
        {
            entity
                //.HasNoKey()
                .ToTable("taxpayer");

            entity.Property(e => e.Amount)
                .HasColumnType("INT")
                .HasColumnName("amount");
            entity.Property(e => e.Email).HasColumnName("email");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.HasKey(e => e.Email);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
