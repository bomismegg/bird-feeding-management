using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BusinessObject.Models;

public partial class BirdfoodmgrContext : DbContext
{
    public BirdfoodmgrContext()
    {
    }

    public BirdfoodmgrContext(DbContextOptions<BirdfoodmgrContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Bird> Birds { get; set; }

    public virtual DbSet<BirdFood> BirdFoods { get; set; }

    public virtual DbSet<Cage> Cages { get; set; }

    public virtual DbSet<CageFood> CageFoods { get; set; }

    public virtual DbSet<Food> Foods { get; set; }

    public virtual DbSet<History> Histories { get; set; }

    public virtual DbSet<Image> Images { get; set; }

    public virtual DbSet<Plan> Plans { get; set; }

    public virtual DbSet<PlanFood> PlanFoods { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=(local); Database=birdfoodmgr; Uid=sa; Pwd=12345; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Bird>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Bird__3213E83F68B5C43D");

            entity.ToTable("Bird");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.AgePeriod)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("agePeriod");
            entity.Property(e => e.IsDisable).HasColumnName("isDisable");
            entity.Property(e => e.IsFeathering).HasColumnName("isFeathering");
            entity.Property(e => e.IsPregnant).HasColumnName("isPregnant");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");

            entity.HasOne(d => d.Cage).WithMany(p => p.Birds)
                .HasForeignKey(d => d.Cageid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKBird72166");
        });

        modelBuilder.Entity<BirdFood>(entity =>
        {
            entity.HasKey(e => new { e.Birdid, e.Foodid });

            entity.ToTable("Bird_Food");

            entity.HasOne(d => d.Bird).WithMany(p => p.BirdFoods)
                .HasForeignKey(d => d.Birdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKBird_Food274987");

            entity.HasOne(d => d.Food).WithMany(p => p.BirdFoods)
                .HasForeignKey(d => d.Foodid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKBird_Food181673");
        });

        modelBuilder.Entity<Cage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cage__3213E83F88EFDF35");

            entity.ToTable("Cage");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.IsAutomatic).HasColumnName("isAutomatic");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        modelBuilder.Entity<CageFood>(entity =>
        {
            entity.HasKey(e => new { e.Cageid, e.Foodid }).HasName("PK__Cage_Foo__517A5089E1E37781");

            entity.ToTable("Cage_Food");

            entity.Property(e => e.Capacity).HasColumnName("capacity");
            entity.Property(e => e.Remaining).HasColumnName("remaining");

            entity.HasOne(d => d.Cage).WithMany(p => p.CageFoods)
                .HasForeignKey(d => d.Cageid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKCage_Food383381");

            entity.HasOne(d => d.Food).WithMany(p => p.CageFoods)
                .HasForeignKey(d => d.Foodid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKCage_Food226094");
        });

        modelBuilder.Entity<Food>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Food__3213E83F788DAEA1");

            entity.ToTable("Food");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
        });

        modelBuilder.Entity<History>(entity =>
        {
            entity.HasKey(e => new { e.Birdid, e.Foodid, e.Timestamp });

            entity.ToTable("History");

            entity.Property(e => e.Timestamp).HasColumnName("timestamp");
            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Bird).WithMany(p => p.Histories)
                .HasForeignKey(d => d.Birdid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_History_Bird");

            entity.HasOne(d => d.Food).WithMany(p => p.Histories)
                .HasForeignKey(d => d.Foodid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_History_Food");
        });

        modelBuilder.Entity<Image>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Image__3213E83F3367DC6A");

            entity.ToTable("Image");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Path)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("path");

            entity.HasOne(d => d.Bird).WithMany(p => p.Images)
                .HasForeignKey(d => d.Birdid)
                .HasConstraintName("FKImage826225");

            entity.HasOne(d => d.Cage).WithMany(p => p.Images)
                .HasForeignKey(d => d.Cageid)
                .HasConstraintName("FKImage762252");
        });

        modelBuilder.Entity<Plan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Plan__3213E83F3B99E8E5");

            entity.ToTable("Plan");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Description)
                .HasMaxLength(500)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.FromDate)
                .HasColumnType("date")
                .HasColumnName("fromDate");
            entity.Property(e => e.IsAutomatic).HasColumnName("isAutomatic");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.ToDate)
                .HasColumnType("date")
                .HasColumnName("toDate");

            entity.HasOne(d => d.Cage).WithMany(p => p.Plans)
                .HasForeignKey(d => d.Cageid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKPlan491606");
        });

        modelBuilder.Entity<PlanFood>(entity =>
        {
            entity.HasKey(e => new { e.Planid, e.Foodid }).HasName("PK__Plan_Foo__5D1385E4FE4E4019");

            entity.ToTable("Plan_Food");

            entity.Property(e => e.Quantity).HasColumnName("quantity");

            entity.HasOne(d => d.Food).WithMany(p => p.PlanFoods)
                .HasForeignKey(d => d.Foodid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKPlan_Food325224");

            entity.HasOne(d => d.Plan).WithMany(p => p.PlanFoods)
                .HasForeignKey(d => d.Planid)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FKPlan_Food237997");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3213E83F449C5A66");

            entity.ToTable("User");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Dob)
                .HasColumnType("date")
                .HasColumnName("dob");
            entity.Property(e => e.Email)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Gender).HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Role).HasColumnName("role");
            entity.Property(e => e.Status).HasColumnName("status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
