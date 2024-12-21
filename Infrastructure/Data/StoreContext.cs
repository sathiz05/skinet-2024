using System;
using Core.Entities;
using Infrastructure.Data.conifg;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data;

public class StoreContex(DbContextOptions options) : DbContext(options)
{
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProductConfiguration).Assembly);
    }
}
