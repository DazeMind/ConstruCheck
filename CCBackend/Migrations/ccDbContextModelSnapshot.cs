﻿// <auto-generated />
using System;
using CCBackend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CCBackend.Migrations
{
    [DbContext(typeof(ccDbContext))]
    partial class ccDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CCBackend.Modelos.AsistenciaModel", b =>
                {
                    b.Property<int>("AsistenciaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Asistencia_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AsistenciaId"));

                    b.Property<string>("Condicion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_Inicio");

                    b.Property<DateTime?>("FechaTermino")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_Termino");

                    b.Property<int?>("TotalHoras")
                        .HasColumnType("int")
                        .HasColumnName("Total_Horas");

                    b.Property<int>("TrabajadorId")
                        .HasColumnType("int")
                        .HasColumnName("Trabajador_Id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("AsistenciaId");

                    b.HasIndex("TrabajadorId");

                    b.ToTable("CC_Asistencia");
                });

            modelBuilder.Entity("CCBackend.Modelos.ClienteModel", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Cliente_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("Ciudad")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("ClientApellido")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Cliente_Apellido");

                    b.Property<string>("ClienteNombre")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Cliente_Nombre");

                    b.Property<string>("Compania")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Correo")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<string>("Direccion")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Estado")
                        .HasColumnType("int");

                    b.Property<string>("Membresia")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int?>("NoTelefono")
                        .HasColumnType("int")
                        .HasColumnName("No_Telefono");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("ClienteId");

                    b.ToTable("CC_Cliente");
                });

            modelBuilder.Entity("CCBackend.Modelos.ComercioModel", b =>
                {
                    b.Property<int>("ComercioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Comercio_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ComercioId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("NombreComercio")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Nombre_Comercio");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("ComercioId");

                    b.ToTable("CC_Comercio");
                });

            modelBuilder.Entity("CCBackend.Modelos.CotizacionModel", b =>
                {
                    b.Property<int>("CotizacionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Cotizacion_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CotizacionId"));

                    b.Property<string>("Adjunto")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<DateTime?>("Date")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_Inicio");

                    b.Property<string>("RateName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Nombre_Cotizacion");

                    b.Property<string>("Responsable")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.Property<int?>("Valor")
                        .HasColumnType("int");

                    b.HasKey("CotizacionId");

                    b.ToTable("CC_Cotizacion");
                });

            modelBuilder.Entity("CCBackend.Modelos.GastosProyectoModel", b =>
                {
                    b.Property<int>("GastosProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Gastos_Proyecto_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GastosProyectoId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int")
                        .HasColumnName("Proyecto_Id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("GastosProyectoId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("CC_Gastos_Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.IngresoProyectoModel", b =>
                {
                    b.Property<int>("IngresoProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Ingreso_Proyecto_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IngresoProyectoId"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int")
                        .HasColumnName("Proyecto_Id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("IngresoProyectoId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("CC_Ingreso_Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.InteresadoProyectoModel", b =>
                {
                    b.Property<int>("InteresadoProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Interesado_Proyecto_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InteresadoProyectoId"));

                    b.Property<string>("CorreoResponsable")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Correo_Responsable");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<int?>("NoTelefono")
                        .HasColumnType("int")
                        .HasColumnName("No_Telefono");

                    b.Property<string>("NombreResponsable")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Nombre_Responsable");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int")
                        .HasColumnName("Proyecto_Id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("InteresadoProyectoId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("CC_Interesado_Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.PagoModel", b =>
                {
                    b.Property<int>("PagoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Pago_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PagoId"));

                    b.Property<string>("Comentarios")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Comprobante")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Fecha")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("Monto")
                        .HasColumnType("int");

                    b.Property<string>("TipoPago")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Tipo_Pago");

                    b.Property<int>("TrabajadorId")
                        .HasColumnType("int")
                        .HasColumnName("Trabajador_Id");

                    b.Property<int?>("TrabajadoresTrabajadorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("PagoId");

                    b.HasIndex("TrabajadoresTrabajadorId");

                    b.ToTable("CC_Pago");
                });

            modelBuilder.Entity("CCBackend.Modelos.ProductoModel", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Producto_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductoId"));

                    b.Property<int>("ComercioId")
                        .HasColumnType("int")
                        .HasColumnName("Comercio_Id");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<string>("DescripcionProducto")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Descripcion_Producto");

                    b.Property<string>("Link")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NombreProducto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Nombre_Producto");

                    b.Property<int?>("Precio")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("ProductoId");

                    b.HasIndex("ComercioId");

                    b.ToTable("CC_Productos");
                });

            modelBuilder.Entity("CCBackend.Modelos.ProyectoDiarioModel", b =>
                {
                    b.Property<int>("ProyectoDiarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Proyecto_Diario_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProyectoDiarioId"));

                    b.Property<int>("Asistencia")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<string>("DescripcionAvanzada")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Descripcion_Avanzada");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int")
                        .HasColumnName("Proyecto_Id");

                    b.Property<int?>("ProyectosProyectoId")
                        .HasColumnType("int");

                    b.Property<int>("TrabajadorId")
                        .HasColumnType("int")
                        .HasColumnName("Trabajador_Id");

                    b.Property<int?>("TrabajadoresTrabajadorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("ProyectoDiarioId");

                    b.HasIndex("ProyectosProyectoId");

                    b.HasIndex("TrabajadoresTrabajadorId");

                    b.ToTable("CC_Proyecto_Diario");
                });

            modelBuilder.Entity("CCBackend.Modelos.ProyectoModel", b =>
                {
                    b.Property<int>("ProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Proyecto_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProyectoId"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("Cliente_Id");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<string>("DescripcionProyecto")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Descripcion_Proyecto");

                    b.Property<string>("DocumentacionRelacionada")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)")
                        .HasColumnName("Documentacion_Relacionada");

                    b.Property<string>("Estado")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_Inicio");

                    b.Property<DateTime?>("FechaTermino")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_Termino");

                    b.Property<string>("Gastos")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Interesado")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("MetersTrabajados")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Metros_Trabajados");

                    b.Property<int?>("Metros")
                        .HasColumnType("int")
                        .HasColumnName("Metros");

                    b.Property<string>("NombreProyecto")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Nombre_Proyecto");

                    b.Property<string>("Presupuesto")
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<string>("Ubicacion")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.Property<int?>("ValorTotal")
                        .HasColumnType("int")
                        .HasColumnName("Valor_Total");

                    b.HasKey("ProyectoId");

                    b.HasIndex("ClienteId");

                    b.ToTable("CC_Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.SemanaProyectoModel", b =>
                {
                    b.Property<int>("SemanaProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Semana_Proyecto_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SemanaProyectoId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<int>("MetrosAvanzados")
                        .HasColumnType("int")
                        .HasColumnName("Metros_Avanzados");

                    b.Property<int>("Semana")
                        .HasColumnType("int");

                    b.Property<int>("TareasRealizadas")
                        .HasColumnType("int")
                        .HasColumnName("Tareas_Realizadas");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("SemanaProyectoId");

                    b.ToTable("CC_Semana_Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.TareaProyectoModel", b =>
                {
                    b.Property<int>("TareaProyectoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Tarea_Proyecto_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TareaProyectoId"));

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Descripcion");

                    b.Property<string>("EstadoTarea")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Estado_Tarea");

                    b.Property<DateTime?>("FechaInicio")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_Inicio");

                    b.Property<DateTime?>("FechaTermino")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_Termino");

                    b.Property<string>("NombreTarea")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Nombre_Tarea");

                    b.Property<int>("ProyectoId")
                        .HasColumnType("int")
                        .HasColumnName("Proyecto_Id");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("TareaProyectoId");

                    b.HasIndex("ProyectoId");

                    b.ToTable("CC_Tareas_Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.TrabajadorModel", b =>
                {
                    b.Property<int>("TrabajadorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Trabajador_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TrabajadorId"));

                    b.Property<string>("AFP")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("AFP");

                    b.Property<string>("Banco")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Cargas")
                        .HasColumnType("int");

                    b.Property<string>("CicloPago")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Ciclo_Pago");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2")
                        .HasColumnName("Fecha_Nacimiento");

                    b.Property<string>("Funcion")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("NoCuenta")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("No_Cuenta");

                    b.Property<string>("NombreTrabajador")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Nombre_Trabajador");

                    b.Property<string>("PrestacionSalud")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Prestacion_Salud");

                    b.Property<string>("Rut")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("Sueldo")
                        .HasColumnType("int");

                    b.Property<int>("Talla")
                        .HasMaxLength(2)
                        .HasColumnType("int");

                    b.Property<string>("TipoCuenta")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Tipo_Cuenta");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("TrabajadorId");

                    b.ToTable("CC_Trabajador");
                });

            modelBuilder.Entity("CCBackend.Modelos.UsuarioModel", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Usuario_Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UsuarioId"));

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("nvarchar(45)");

                    b.Property<DateTime>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Created_At");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("Nombre_Usuario");

                    b.Property<string>("Rut")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("datetime2")
                        .HasColumnName("Updated_At");

                    b.HasKey("UsuarioId");

                    b.ToTable("CC_Usuario");
                });

            modelBuilder.Entity("CCBackend.Modelos.AsistenciaModel", b =>
                {
                    b.HasOne("CCBackend.Modelos.TrabajadorModel", "Trabajador")
                        .WithMany()
                        .HasForeignKey("TrabajadorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Trabajador");
                });

            modelBuilder.Entity("CCBackend.Modelos.GastosProyectoModel", b =>
                {
                    b.HasOne("CCBackend.Modelos.ProyectoModel", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.IngresoProyectoModel", b =>
                {
                    b.HasOne("CCBackend.Modelos.ProyectoModel", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.InteresadoProyectoModel", b =>
                {
                    b.HasOne("CCBackend.Modelos.ProyectoModel", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.PagoModel", b =>
                {
                    b.HasOne("CCBackend.Modelos.TrabajadorModel", "Trabajadores")
                        .WithMany()
                        .HasForeignKey("TrabajadoresTrabajadorId");

                    b.Navigation("Trabajadores");
                });

            modelBuilder.Entity("CCBackend.Modelos.ProductoModel", b =>
                {
                    b.HasOne("CCBackend.Modelos.ComercioModel", "Comercio")
                        .WithMany("Productos")
                        .HasForeignKey("ComercioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Comercio");
                });

            modelBuilder.Entity("CCBackend.Modelos.ProyectoDiarioModel", b =>
                {
                    b.HasOne("CCBackend.Modelos.ProyectoModel", "Proyectos")
                        .WithMany()
                        .HasForeignKey("ProyectosProyectoId");

                    b.HasOne("CCBackend.Modelos.TrabajadorModel", "Trabajadores")
                        .WithMany()
                        .HasForeignKey("TrabajadoresTrabajadorId");

                    b.Navigation("Proyectos");

                    b.Navigation("Trabajadores");
                });

            modelBuilder.Entity("CCBackend.Modelos.ProyectoModel", b =>
                {
                    b.HasOne("CCBackend.Modelos.ClienteModel", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("CCBackend.Modelos.TareaProyectoModel", b =>
                {
                    b.HasOne("CCBackend.Modelos.ProyectoModel", "Proyecto")
                        .WithMany()
                        .HasForeignKey("ProyectoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Proyecto");
                });

            modelBuilder.Entity("CCBackend.Modelos.ComercioModel", b =>
                {
                    b.Navigation("Productos");
                });
#pragma warning restore 612, 618
        }
    }
}
