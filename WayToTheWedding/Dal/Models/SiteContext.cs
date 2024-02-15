using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class SiteContext : DbContext
{
    public SiteContext(DbContextOptions<SiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Business> Businesses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<HousingUnit> HousingUnits { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Business>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Business__3214EC07E8918BDA");

            entity.ToTable("Business");

            entity.Property(e => e.Adress)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.MoreInfo)
                .HasMaxLength(300)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.OpeningHours)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PhoneNum)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.CategoryNavigation).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.Category)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CategoriesBusiness");

            entity.HasOne(d => d.City).WithMany(p => p.Businesses)
                .HasForeignKey(d => d.CityId)
                .HasConstraintName("FK_CitiesBusiness");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07AFD65F9C");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cities__3214EC07D4D6EC32");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
        });

        modelBuilder.Entity<HousingUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HousingU__3214EC07123CC625");

            entity.Property(e => e.Adress)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");
            entity.Property(e => e.PhoneNum)
                .HasMaxLength(10)
                .UseCollation("SQL_Latin1_General_CP1_CI_AS");

            entity.HasOne(d => d.City).WithMany(p => p.HousingUnits)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CitiesHousingUnits");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
