using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ORDINARIO_TEC_WEB.Models;

public partial class NuevaDbContext : DbContext
{
    public NuevaDbContext()
    {
    }

    public NuevaDbContext(DbContextOptions<NuevaDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedore> Proveedores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS; Database=NuevaDB; Trusted_Connection=True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCli).HasName("PK__clientes__398F67059B0BC6CE");

            entity.ToTable("clientes");

            entity.Property(e => e.IdCli).HasColumnName("idCli");
            entity.Property(e => e.DireccionCli)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("direccionCli");
            entity.Property(e => e.NombreCli)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreCli");
            entity.Property(e => e.TelfonoCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telfonoCli");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.IdProd).HasName("PK__producto__B41BB0CA33C688F2");

            entity.ToTable("productos");

            entity.Property(e => e.IdProd).HasColumnName("idProd");
            entity.Property(e => e.DescripcionProd)
                .IsUnicode(false)
                .HasColumnName("descripcionProd");
            entity.Property(e => e.NombreProd)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreProd");
            entity.Property(e => e.PrecioProd)
                .HasColumnType("smallmoney")
                .HasColumnName("precioProd");
            entity.Property(e => e.StockProd).HasColumnName("stockProd");
        });

        modelBuilder.Entity<Proveedore>(entity =>
        {
            entity.HasKey(e => e.IdProv).HasName("PK__proveedo__B41BB0D8E1792FF5");

            entity.ToTable("proveedores");

            entity.Property(e => e.IdProv).HasColumnName("idProv");
            entity.Property(e => e.CorreoProv)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("correoProv");
            entity.Property(e => e.DireccionProv)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("direccionProv");
            entity.Property(e => e.NombreProv)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombreProv");
            entity.Property(e => e.TelefonoProv)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("telefonoProv");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
