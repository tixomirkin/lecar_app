using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace lecar_app.database;

public partial class LecarAppContext : DbContext
{
    public LecarAppContext()
    {
    }

    public LecarAppContext(DbContextOptions<LecarAppContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Con> Cons { get; set; }

    public virtual DbSet<Illness> Illnesses { get; set; }

    public virtual DbSet<Medicament> Medicaments { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=C:\\Users\\user\\Documents\\curs\\LecarApp.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Con>(entity =>
        {
            entity.ToTable("con");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdIllnes).HasColumnName("id_illnes");
            entity.Property(e => e.IdMedicament).HasColumnName("id_medicament");
        });

        modelBuilder.Entity<Illness>(entity =>
        {
            entity.ToTable("illness");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name).HasColumnName("name");
            entity.Property(e => e.Recommendations).HasColumnName("recommendations");
            entity.Property(e => e.Symptoms).HasColumnName("symptoms");
        });

        modelBuilder.Entity<Medicament>(entity =>
        {
            entity.ToTable("medicaments");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ActiveSubstance).HasColumnName("active_substance");
            entity.Property(e => e.Count)
                .HasDefaultValue(0)
                .HasColumnName("count");
            entity.Property(e => e.Name).HasColumnName("name");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
