﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CommunityApp.Models;
using Microsoft.Identity.Client;

namespace CommunityApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    public DbSet<City> Cities { get; set; }
    public DbSet<Province> Provinces { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);

    builder.Entity<Province>().HasMany(p => p.Cities).WithOne(c => c.Province).HasForeignKey(c => c.ProvinceCode);

    builder.Entity<City>().ToTable("City");
    builder.Entity<Province>().ToTable("Province");

    builder.Seed();
} 
}
