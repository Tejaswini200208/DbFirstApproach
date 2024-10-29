using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirstApproachWithOneTable.Models;

public partial class CountryTejuContext : DbContext
{
    public CountryTejuContext()
    {
    }

    public CountryTejuContext(DbContextOptions<CountryTejuContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TblCountry> TblCountries { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=DESKTOP-OC8K56H\\SQLSERVER2022;Database=Country_Teju;User Id=sa;Password = user123;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TblCountry>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__tbl_coun__7E8CD0551CEA753F");

            entity.ToTable("tbl_country");

            entity.Property(e => e.CountryId)
                .ValueGeneratedNever()
                .HasColumnName("country_id");
            entity.Property(e => e.CountryCapital)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country_capital");
            entity.Property(e => e.CountryContinent)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country_continent");
            entity.Property(e => e.CountryCurrency)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country_currency");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("country_name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
