using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Dal.Models;

public partial class SiteContext : DbContext
{
    public SiteContext()
    {
    }

    public SiteContext(DbContextOptions<SiteContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Business> Businesses { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<HousingUnit> HousingUnits { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Project\\WayToTheWedding\\DB\\Database1.mdf;Integrated Security=True;Connect Timeout=30");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Business>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Business__3214EC07E8918BDA");

            entity.ToTable("Business");

            entity.Property(e => e.Adress).HasMaxLength(100);
            entity.Property(e => e.MoreInfo).HasMaxLength(300);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.OpeningHours).HasMaxLength(100);
            entity.Property(e => e.PhoneNum)
                .IsRequired()
                .HasMaxLength(10);

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
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cities__3214EC07D4D6EC32");

            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
        });

        modelBuilder.Entity<HousingUnit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HousingU__3214EC07123CC625");

            entity.Property(e => e.Adress)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(100);
            entity.Property(e => e.PhoneNum)
                .IsRequired()
                .HasMaxLength(10);

            entity.HasOne(d => d.City).WithMany(p => p.HousingUnits)
                .HasForeignKey(d => d.CityId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_CitiesHousingUnits");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
