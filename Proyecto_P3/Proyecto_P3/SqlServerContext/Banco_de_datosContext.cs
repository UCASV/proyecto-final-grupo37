using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Proyecto_P3.SqlServerContext
{
    public partial class Banco_de_datosContext : DbContext
    {
        public Banco_de_datosContext()
        {
        }

        public Banco_de_datosContext(DbContextOptions options)
            : base(options)
        {
        }

        public virtual DbSet<Cabina> Cabinas { get; set; }
        public virtual DbSet<CabinaxEmpleado> CabinaxEmpleados { get; set; }
        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Ciudadano> Ciudadanos { get; set; }
        public virtual DbSet<Ciudadano1> Ciudadanos1 { get; set; }
        public virtual DbSet<EfectoSecundario> EfectoSecundarios { get; set; }
        public virtual DbSet<Empleado> Empleados { get; set; }
        public virtual DbSet<EmpleadoxCiudadano> EmpleadoxCiudadanos { get; set; }
        public virtual DbSet<Enfermedad> Enfermedads { get; set; }
        public virtual DbSet<Hora> Horas { get; set; }
        public virtual DbSet<Identificador> Identificadors { get; set; }
        public virtual DbSet<Lugar> Lugars { get; set; }
        public virtual DbSet<Tipo> Tipos { get; set; }
        public virtual DbSet<Vacunacion> Vacunacions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-D82P45T;Database=Banco_de_datos;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Cabina>(entity =>
            {
                entity.HasKey(e => e.IdCabina)
                    .HasName("PK__CABINA__CC13A1A04A85384E");

                entity.ToTable("CABINA");

                entity.Property(e => e.IdCabina).HasColumnName("ID_cabina");

                entity.Property(e => e.Correo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("direccion");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CabinaxEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdCabinaxempleado)
                    .HasName("PK__CABINAxE__36725A3BBA805E8B");

                entity.ToTable("CABINAxEMPLEADO");

                entity.Property(e => e.IdCabinaxempleado).HasColumnName("id_cabinaxempleado");

                entity.Property(e => e.IdCabina).HasColumnName("id_cabina");

                entity.Property(e => e.IdIdentificador).HasColumnName("id_Identificador");

                entity.HasOne(d => d.IdCabinaNavigation)
                    .WithMany(p => p.CabinaxEmpleados)
                    .HasForeignKey(d => d.IdCabina)
                    .HasConstraintName("FK_CABINAxEMPLEADO_id_cabina");

                entity.HasOne(d => d.IdIdentificadorNavigation)
                    .WithMany(p => p.CabinaxEmpleados)
                    .HasForeignKey(d => d.IdIdentificador)
                    .HasConstraintName("FK_CABINAxEMPLEADO_id_identificador");
            });

            modelBuilder.Entity<Cita>(entity =>
            {
                entity.HasKey(e => e.IdCita)
                    .HasName("PK__CITA__6A1686E91892CBC8");

                entity.ToTable("CITA");

                entity.Property(e => e.IdCita).HasColumnName("ID_cita");

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasColumnName("fecha");

                entity.Property(e => e.IdHora).HasColumnName("id_hora");

                entity.Property(e => e.IdIdentificador).HasColumnName("id_identificador");

                entity.Property(e => e.IdLugar).HasColumnName("id_lugar");

                entity.Property(e => e.IdentificadorCita).HasColumnName("identificador_cita");

                entity.HasOne(d => d.IdHoraNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdHora)
                    .HasConstraintName("FK_CITA_id_hora");

                entity.HasOne(d => d.IdIdentificadorNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdIdentificador)
                    .HasConstraintName("FK_CITA_id_identificador");

                entity.HasOne(d => d.IdLugarNavigation)
                    .WithMany(p => p.Cita)
                    .HasForeignKey(d => d.IdLugar)
                    .HasConstraintName("FK_CITA_id_lugar");
            });

            modelBuilder.Entity<Ciudadano>(entity =>
            {
                entity.HasKey(e => e.Dui)
                    .HasName("PK__CIUDADAN__D876F1BE4473192D");

                entity.ToTable("CIUDADANO");

                entity.Property(e => e.Dui)
                    .ValueGeneratedNever()
                    .HasColumnName("dui");

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("correo_electronico");

                entity.Property(e => e.DireccionDomicilio)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("direccion_domicilio");

                entity.Property(e => e.IdIdentificador).HasColumnName("Id_Identificador");

                entity.Property(e => e.IdVacunacion).HasColumnName("Id_vacunacion");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.Telefono)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("telefono");

                entity.HasOne(d => d.IdIdentificadorNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdIdentificador)
                    .HasConstraintName("FK_CIUDADANO_Id_Identificador");

                entity.HasOne(d => d.IdVacunacionNavigation)
                    .WithMany(p => p.Ciudadanos)
                    .HasForeignKey(d => d.IdVacunacion)
                    .HasConstraintName("FK_VACUNACION_Id_vacunacion");
            });

            modelBuilder.Entity<Ciudadano1>(entity =>
            {
                entity.HasKey(e => e.Dui);

                entity.ToTable("Ciudadanos");

                entity.Property(e => e.Cellphone).HasColumnName("cellphone");

                entity.Property(e => e.Direction).HasColumnName("direction");
            });

            modelBuilder.Entity<EfectoSecundario>(entity =>
            {
                entity.HasKey(e => e.IdSecundario)
                    .HasName("PK__EFECTO_S__299A1A87E2F9EEE2");

                entity.ToTable("EFECTO_SECUNDARIO");

                entity.Property(e => e.IdSecundario).HasColumnName("ID_secundario");

                entity.Property(e => e.EfectoSecundario1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Efecto_secundario");

                entity.Property(e => e.IdVacunacion).HasColumnName("ID_vacunacion");

                entity.HasOne(d => d.IdVacunacionNavigation)
                    .WithMany(p => p.EfectoSecundarios)
                    .HasForeignKey(d => d.IdVacunacion)
                    .HasConstraintName("FK_EFECTO_SECUNDARIO_Id_vacunacion");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdIdentificador)
                    .HasName("PK__EMPLEADO__579505C7B34FBA99");

                entity.ToTable("EMPLEADO");

                entity.Property(e => e.IdIdentificador).HasColumnName("id_identificador");

                entity.Property(e => e.Contasena)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("contasena");

                entity.Property(e => e.CorreoInstitucional)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("correo_institucional");

                entity.Property(e => e.DireccionVivienda)
                    .HasMaxLength(75)
                    .IsUnicode(false)
                    .HasColumnName("direccion_vivienda");

                entity.Property(e => e.IdTipo).HasColumnName("Id_tipo");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoNavigation)
                    .WithMany(p => p.Empleados)
                    .HasForeignKey(d => d.IdTipo)
                    .HasConstraintName("FK_EMPLEADO_ID_tipo");
            });

            modelBuilder.Entity<EmpleadoxCiudadano>(entity =>
            {
                entity.HasKey(e => e.IdEmpleadoxciudadano)
                    .HasName("PK__EMPLEADO__A93DC5D7DF5C06F7");

                entity.ToTable("EMPLEADOxCIUDADANO");

                entity.Property(e => e.IdEmpleadoxciudadano).HasColumnName("id_empleadoxciudadano");

                entity.Property(e => e.DuiCiudadano).HasColumnName("dui_ciudadano");

                entity.Property(e => e.IdIdentificador).HasColumnName("id_identificador");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.EmpleadoxCiudadanos)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .HasConstraintName("FK_EMPLEADOxCIUDADANO_dui_ciudadano");

                entity.HasOne(d => d.IdIdentificadorNavigation)
                    .WithMany(p => p.EmpleadoxCiudadanos)
                    .HasForeignKey(d => d.IdIdentificador)
                    .HasConstraintName("FK_EMPLEADOxCIUDADANO_id_identificador");
            });

            modelBuilder.Entity<Enfermedad>(entity =>
            {
                entity.HasKey(e => e.IdEnfermedad)
                    .HasName("PK__ENFERMED__5E79491D4AAF37C5");

                entity.ToTable("ENFERMEDAD");

                entity.Property(e => e.IdEnfermedad).HasColumnName("Id_enfermedad");

                entity.Property(e => e.DuiCiudadano).HasColumnName("dui_ciudadano");

                entity.Property(e => e.Enfermedad1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("enfermedad");

                entity.HasOne(d => d.DuiCiudadanoNavigation)
                    .WithMany(p => p.Enfermedads)
                    .HasForeignKey(d => d.DuiCiudadano)
                    .HasConstraintName("FK_ENFERMEDAD_dui_ciudadano");
            });

            modelBuilder.Entity<Hora>(entity =>
            {
                entity.HasKey(e => e.IdHora)
                    .HasName("PK__HORA__9F3E025D2C414B20");

                entity.ToTable("HORA");

                entity.Property(e => e.IdHora).HasColumnName("Id_hora");

                entity.Property(e => e.Hora1).HasColumnName("hora");
            });

            modelBuilder.Entity<Identificador>(entity =>
            {
                entity.HasKey(e => e.IdNumero)
                    .HasName("PK__IDENTIFI__B5F8DC960520E97E");

                entity.ToTable("IDENTIFICADOR");

                entity.Property(e => e.IdNumero).HasColumnName("ID_numero");

                entity.Property(e => e.NumeroIdentificador).HasColumnName("Numero_identificador");
            });

            modelBuilder.Entity<Lugar>(entity =>
            {
                entity.HasKey(e => e.IdLugar)
                    .HasName("PK__LUGAR__56BD46736DC87B6C");

                entity.ToTable("LUGAR");

                entity.Property(e => e.IdLugar).HasColumnName("Id_lugar");

                entity.Property(e => e.Lugar1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("lugar");
            });

            modelBuilder.Entity<Tipo>(entity =>
            {
                entity.HasKey(e => e.IdTipo)
                    .HasName("PK__TIPO__E151C9645A86E3BD");

                entity.ToTable("TIPO");

                entity.Property(e => e.IdTipo).HasColumnName("ID_tipo");

                entity.Property(e => e.Tipo1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("tipo");
            });

            modelBuilder.Entity<Vacunacion>(entity =>
            {
                entity.HasKey(e => e.IdVacunacion)
                    .HasName("PK__VACUNACI__14A59DADE8A03E6F");

                entity.ToTable("VACUNACION");

                entity.Property(e => e.IdVacunacion).HasColumnName("ID_vacunacion");

                entity.Property(e => e.FechaEntrada)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_Entrada");

                entity.Property(e => e.FechaSalida)
                    .HasColumnType("datetime")
                    .HasColumnName("Fecha_salida");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
