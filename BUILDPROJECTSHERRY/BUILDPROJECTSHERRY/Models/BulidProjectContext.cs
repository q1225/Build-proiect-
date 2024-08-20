using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BUILDPROJECTSHERRY.Models;

public partial class BulidProjectContext : DbContext
{
    public BulidProjectContext()
    {
    }

    public BulidProjectContext(DbContextOptions<BulidProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<HealthCareProvider> HealthCareProviders { get; set; }

    public virtual DbSet<HealthCareProviderRole> HealthCareProviderRoles { get; set; }

    public virtual DbSet<Hospital> Hospitals { get; set; }

    public virtual DbSet<MedicalClaim> MedcialClaims { get; set; }

    public virtual DbSet<Patient> Patients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-OGKSQ2L\\SHERRY;Initial Catalog=BULID_PROJECT;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HealthCareProvider>(entity =>
        {
            entity.ToTable("HealthCareProvider");

            entity.Property(e => e.Adress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Dob).HasColumnName("DOB");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Npi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NPI");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIP");

            entity.HasOne(d => d.Hospital).WithMany(p => p.HealthCareProviders)
                .HasForeignKey(d => d.HospitalId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_HealthCareProvider_Hospital");
        });

        modelBuilder.Entity<HealthCareProviderRole>(entity =>
        {
            entity.ToTable("HealthCareProviderRole");

            entity.Property(e => e.RoleName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Hospital>(entity =>
        {
            entity.ToTable("Hospital");

            entity.Property(e => e.Adress)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.HospitalName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Zip)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ZIP");
        });

        modelBuilder.Entity<MedicalClaim>(entity =>
        {
            entity.ToTable("MEDCIAL_CLAIM");

            entity.Property(e => e.DaysSupply)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Days_Supply");
            entity.Property(e => e.HealthCareProvider)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Health_Care_Provider");
            entity.Property(e => e.Ndc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("NDC");
            entity.Property(e => e.Patient)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.PrescritonNumber)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("Prescriton_number");
            entity.Property(e => e.TotalAmount).HasColumnName("Total_Amount");
        });

        modelBuilder.Entity<Patient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("patient");

            entity.Property(e => e.Dob)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DOB");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("First_name");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.HospitalId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("hospitalID ");
            entity.Property(e => e.InsuranceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("InsuranceID");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Last_name");
            entity.Property(e => e.Mrn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MRN");
            entity.Property(e => e.Ssn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SSN ");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
