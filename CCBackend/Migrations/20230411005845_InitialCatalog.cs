using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCBackend.Migrations
{
    /// <inheritdoc />
    public partial class InitialCatalog : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CC_Client",
                columns: table => new
                {
                    Cliente_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cliente_Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cliente_Apellido = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Compania = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Membresia = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    No_Telefono = table.Column<int>(type: "int", nullable: true),
                    Direccion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Ciudad = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estado = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Client", x => x.Cliente_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Comercio",
                columns: table => new
                {
                    Comercio_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Comercio = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Comercio", x => x.Comercio_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Cotizacion",
                columns: table => new
                {
                    Cotizacion_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Cotizacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Adjunto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Valor = table.Column<int>(type: "int", nullable: true),
                    Responsable = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Cotizacion", x => x.Cotizacion_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Semana_Proyecto",
                columns: table => new
                {
                    Semana_Proyecto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Semana = table.Column<int>(type: "int", nullable: false),
                    Metros_Avanzados = table.Column<int>(type: "int", nullable: false),
                    Tareas_Realizadas = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Semana_Proyecto", x => x.Semana_Proyecto_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Trabajador",
                columns: table => new
                {
                    Trabajador_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Trabajador = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Fecha_Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AFP = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Prestacion_Salud = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Cargas = table.Column<int>(type: "int", nullable: false),
                    Talla = table.Column<int>(type: "int", maxLength: 2, nullable: false),
                    Funcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Sueldo = table.Column<float>(type: "real", nullable: false),
                    Ciclo_Pago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Banco = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Tipo_Cuenta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    No_Cuenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Trabajador", x => x.Trabajador_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Usuario",
                columns: table => new
                {
                    Usuario_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Usuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Usuario", x => x.Usuario_Id);
                });

            migrationBuilder.CreateTable(
                name: "CC_Proyecto",
                columns: table => new
                {
                    Proyecto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteId = table.Column<int>(type: "int", nullable: false),
                    Nombre_Proyecto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion_Proyecto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Termino = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Metros = table.Column<int>(type: "int", nullable: true),
                    Metros_Trabajados = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Valor_Total = table.Column<int>(type: "int", nullable: true),
                    Ubicacion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Responsable = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Documentacion_Relacionada = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Presupuesto = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Gastos = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Proyecto", x => x.Proyecto_Id);
                    table.ForeignKey(
                        name: "FK_CC_Proyecto_CC_Client_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "CC_Client",
                        principalColumn: "Cliente_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Productos",
                columns: table => new
                {
                    Producto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Producto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Descripcion_Producto = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Precio = table.Column<int>(type: "int", nullable: true),
                    Link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ComercioId = table.Column<int>(type: "int", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Productos", x => x.Producto_Id);
                    table.ForeignKey(
                        name: "FK_CC_Productos_CC_Comercio_ComercioId",
                        column: x => x.ComercioId,
                        principalTable: "CC_Comercio",
                        principalColumn: "Comercio_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Asistencia",
                columns: table => new
                {
                    Asistencia_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrabajadorId = table.Column<int>(type: "int", nullable: false),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Termino = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Total_Horas = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Condicion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Asistencia", x => x.Asistencia_Id);
                    table.ForeignKey(
                        name: "FK_CC_Asistencia_CC_Trabajador_TrabajadorId",
                        column: x => x.TrabajadorId,
                        principalTable: "CC_Trabajador",
                        principalColumn: "Trabajador_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Pago",
                columns: table => new
                {
                    Pago_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrabajadorId = table.Column<int>(type: "int", nullable: false),
                    TrabajadoresTrabajadorId = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tipo_Pago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comentarios = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Voucher = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Pago", x => x.Pago_Id);
                    table.ForeignKey(
                        name: "FK_CC_Pago_CC_Trabajador_TrabajadoresTrabajadorId",
                        column: x => x.TrabajadoresTrabajadorId,
                        principalTable: "CC_Trabajador",
                        principalColumn: "Trabajador_Id");
                });

            migrationBuilder.CreateTable(
                name: "CC_Gastos_Proyecto",
                columns: table => new
                {
                    Gastos_Proyecto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    Monto = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Gastos_Proyecto", x => x.Gastos_Proyecto_Id);
                    table.ForeignKey(
                        name: "FK_CC_Gastos_Proyecto_CC_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "CC_Proyecto",
                        principalColumn: "Proyecto_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Ingreso_Proyecto",
                columns: table => new
                {
                    Ingreso_Proyecto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Ingreso_Proyecto", x => x.Ingreso_Proyecto_Id);
                    table.ForeignKey(
                        name: "FK_CC_Ingreso_Proyecto_CC_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "CC_Proyecto",
                        principalColumn: "Proyecto_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Interesado_Proyecto",
                columns: table => new
                {
                    Interesado_Proyecto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    Nombre_Responsable = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Correo_Responsable = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    No_Telefono = table.Column<int>(type: "int", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Interesado_Proyecto", x => x.Interesado_Proyecto_Id);
                    table.ForeignKey(
                        name: "FK_CC_Interesado_Proyecto_CC_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "CC_Proyecto",
                        principalColumn: "Proyecto_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CC_Proyecto_Diario",
                columns: table => new
                {
                    Proyecto_Diario_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    ProyectosProyectoId = table.Column<int>(type: "int", nullable: true),
                    TrabajadorId = table.Column<int>(type: "int", nullable: false),
                    TrabajadoresTrabajadorId = table.Column<int>(type: "int", nullable: true),
                    Asistencia = table.Column<int>(type: "int", nullable: false),
                    Descripcion_Avanzada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Proyecto_Diario", x => x.Proyecto_Diario_Id);
                    table.ForeignKey(
                        name: "FK_CC_Proyecto_Diario_CC_Proyecto_ProyectosProyectoId",
                        column: x => x.ProyectosProyectoId,
                        principalTable: "CC_Proyecto",
                        principalColumn: "Proyecto_Id");
                    table.ForeignKey(
                        name: "FK_CC_Proyecto_Diario_CC_Trabajador_TrabajadoresTrabajadorId",
                        column: x => x.TrabajadoresTrabajadorId,
                        principalTable: "CC_Trabajador",
                        principalColumn: "Trabajador_Id");
                });

            migrationBuilder.CreateTable(
                name: "CC_Tareas_Proyecto",
                columns: table => new
                {
                    Tarea_Proyecto_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProyectoId = table.Column<int>(type: "int", nullable: false),
                    Nombre_Tarea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Estado_Tarea = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Fecha_Inicio = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Fecha_Termino = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created_At = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated_At = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Tareas_Proyecto", x => x.Tarea_Proyecto_Id);
                    table.ForeignKey(
                        name: "FK_CC_Tareas_Proyecto_CC_Proyecto_ProyectoId",
                        column: x => x.ProyectoId,
                        principalTable: "CC_Proyecto",
                        principalColumn: "Proyecto_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CC_Asistencia_TrabajadorId",
                table: "CC_Asistencia",
                column: "TrabajadorId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Gastos_Proyecto_ProyectoId",
                table: "CC_Gastos_Proyecto",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Ingreso_Proyecto_ProyectoId",
                table: "CC_Ingreso_Proyecto",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Interesado_Proyecto_ProyectoId",
                table: "CC_Interesado_Proyecto",
                column: "ProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Pago_TrabajadoresTrabajadorId",
                table: "CC_Pago",
                column: "TrabajadoresTrabajadorId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Productos_ComercioId",
                table: "CC_Productos",
                column: "ComercioId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Proyecto_ClienteId",
                table: "CC_Proyecto",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Proyecto_Diario_ProyectosProyectoId",
                table: "CC_Proyecto_Diario",
                column: "ProyectosProyectoId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Proyecto_Diario_TrabajadoresTrabajadorId",
                table: "CC_Proyecto_Diario",
                column: "TrabajadoresTrabajadorId");

            migrationBuilder.CreateIndex(
                name: "IX_CC_Tareas_Proyecto_ProyectoId",
                table: "CC_Tareas_Proyecto",
                column: "ProyectoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CC_Asistencia");

            migrationBuilder.DropTable(
                name: "CC_Cotizacion");

            migrationBuilder.DropTable(
                name: "CC_Gastos_Proyecto");

            migrationBuilder.DropTable(
                name: "CC_Ingreso_Proyecto");

            migrationBuilder.DropTable(
                name: "CC_Interesado_Proyecto");

            migrationBuilder.DropTable(
                name: "CC_Pago");

            migrationBuilder.DropTable(
                name: "CC_Productos");

            migrationBuilder.DropTable(
                name: "CC_Proyecto_Diario");

            migrationBuilder.DropTable(
                name: "CC_Semana_Proyecto");

            migrationBuilder.DropTable(
                name: "CC_Tareas_Proyecto");

            migrationBuilder.DropTable(
                name: "CC_Usuario");

            migrationBuilder.DropTable(
                name: "CC_Comercio");

            migrationBuilder.DropTable(
                name: "CC_Trabajador");

            migrationBuilder.DropTable(
                name: "CC_Proyecto");

            migrationBuilder.DropTable(
                name: "CC_Client");
        }
    }
}
