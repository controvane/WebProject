using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace appCoreMVCFinalIntelyGentes.Models.Datos
{
    public partial class rrhhContext : DbContext
    {
        public rrhhContext()
        {
        }

        public rrhhContext(DbContextOptions<rrhhContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<DeptoEmp> DeptoEmp { get; set; }
        public virtual DbSet<DeptoJefe> DeptoJefe { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Sueldos> Sueldos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-49HA4QV;Initial Catalog=rrhh;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => new { e.EmpleadoEmpNo, e.Cargo1, e.FechaIni })
                    .HasName("pk_cargo");

                entity.ToTable("cargo");

                entity.Property(e => e.EmpleadoEmpNo).HasColumnName("empleado_emp_no");

                entity.Property(e => e.Cargo1)
                    .HasColumnName("cargo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.HasOne(d => d.EmpleadoEmpNoNavigation)
                    .WithMany(p => p.Cargo)
                    .HasForeignKey(d => d.EmpleadoEmpNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_cargo_empleado");
            });

            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.DeptoNo)
                    .HasName("PK__departam__7A16B9617A404A92");

                entity.ToTable("departamento");

                entity.Property(e => e.DeptoNo)
                    .HasColumnName("depto_no")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DeptoNombre)
                    .HasColumnName("depto_nombre")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DeptoEmp>(entity =>
            {
                entity.HasKey(e => new { e.DepartamentoDeptoNo, e.EmpleadoEmpNo, e.FechaIni })
                    .HasName("pk_depto_emp");

                entity.ToTable("depto_emp");

                entity.Property(e => e.DepartamentoDeptoNo)
                    .HasColumnName("departamento_depto_no")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.EmpleadoEmpNo).HasColumnName("empleado_emp_no");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("date");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.HasOne(d => d.DepartamentoDeptoNoNavigation)
                    .WithMany(p => p.DeptoEmp)
                    .HasForeignKey(d => d.DepartamentoDeptoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_depto_no");

                entity.HasOne(d => d.EmpleadoEmpNoNavigation)
                    .WithMany(p => p.DeptoEmp)
                    .HasForeignKey(d => d.EmpleadoEmpNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_emp_no");
            });

            modelBuilder.Entity<DeptoJefe>(entity =>
            {
                entity.HasKey(e => new { e.EmpleadoEmpNo, e.DepartamentoDeptoNo })
                    .HasName("pk_depto_jefe");

                entity.ToTable("depto_jefe");

                entity.Property(e => e.EmpleadoEmpNo).HasColumnName("empleado_emp_no");

                entity.Property(e => e.DepartamentoDeptoNo)
                    .HasColumnName("departamento_depto_no")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("date");

                entity.HasOne(d => d.DepartamentoDeptoNoNavigation)
                    .WithMany(p => p.DeptoJefe)
                    .HasForeignKey(d => d.DepartamentoDeptoNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_depto_jefe_d");

                entity.HasOne(d => d.EmpleadoEmpNoNavigation)
                    .WithMany(p => p.DeptoJefe)
                    .HasForeignKey(d => d.EmpleadoEmpNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_depto_jefe_e");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("PK__empleado__129850FA3BF50A89");

                entity.ToTable("empleado");

                entity.Property(e => e.EmpNo)
                    .HasColumnName("emp_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.FechaContrato)
                    .HasColumnName("fecha_contrato")
                    .HasColumnType("date");

                entity.Property(e => e.FechaNacimiento)
                    .HasColumnName("fecha_nacimiento")
                    .HasColumnType("date");

                entity.Property(e => e.Genero).HasColumnName("genero");

                entity.Property(e => e.Materno)
                    .HasColumnName("materno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(14)
                    .IsUnicode(false);

                entity.Property(e => e.Paterno)
                    .IsRequired()
                    .HasColumnName("paterno")
                    .HasMaxLength(16)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sueldos>(entity =>
            {
                entity.HasKey(e => new { e.EmpNo, e.DesdeFecha })
                    .HasName("pk_sueldos");

                entity.ToTable("sueldos");

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");

                entity.Property(e => e.DesdeFecha)
                    .HasColumnName("desde_fecha")
                    .HasColumnType("date");

                entity.Property(e => e.HastaFecha)
                    .HasColumnName("hasta_fecha")
                    .HasColumnType("date");

                entity.Property(e => e.Sueldo).HasColumnName("sueldo");

                entity.HasOne(d => d.EmpNoNavigation)
                    .WithMany(p => p.Sueldos)
                    .HasForeignKey(d => d.EmpNo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_sueldo_empleado");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
