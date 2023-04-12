using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCBackend.Migrations
{
    /// <inheritdoc />
    public partial class ActualizacionColumnas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CC_Asistencia_CC_Trabajador_TrabajadorId",
                table: "CC_Asistencia");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Gastos_Proyecto_CC_Proyecto_ProyectoId",
                table: "CC_Gastos_Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Ingreso_Proyecto_CC_Proyecto_ProyectoId",
                table: "CC_Ingreso_Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Interesado_Proyecto_CC_Proyecto_ProyectoId",
                table: "CC_Interesado_Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Productos_CC_Comercio_ComercioId",
                table: "CC_Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Proyecto_CC_Client_ClienteId",
                table: "CC_Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Tareas_Proyecto_CC_Proyecto_ProyectoId",
                table: "CC_Tareas_Proyecto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CC_Client",
                table: "CC_Client");

            migrationBuilder.RenameTable(
                name: "CC_Client",
                newName: "CC_Cliente");

            migrationBuilder.RenameColumn(
                name: "ProyectoId",
                table: "CC_Tareas_Proyecto",
                newName: "Proyecto_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Tareas_Proyecto_ProyectoId",
                table: "CC_Tareas_Proyecto",
                newName: "IX_CC_Tareas_Proyecto_Proyecto_Id");

            migrationBuilder.RenameColumn(
                name: "TrabajadorId",
                table: "CC_Proyecto_Diario",
                newName: "Trabajador_Id");

            migrationBuilder.RenameColumn(
                name: "ProyectoId",
                table: "CC_Proyecto_Diario",
                newName: "Proyecto_Id");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "CC_Proyecto",
                newName: "Cliente_Id");

            migrationBuilder.RenameColumn(
                name: "Responsable",
                table: "CC_Proyecto",
                newName: "Interesado");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Proyecto_ClienteId",
                table: "CC_Proyecto",
                newName: "IX_CC_Proyecto_Cliente_Id");

            migrationBuilder.RenameColumn(
                name: "ComercioId",
                table: "CC_Productos",
                newName: "Comercio_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Productos_ComercioId",
                table: "CC_Productos",
                newName: "IX_CC_Productos_Comercio_Id");

            migrationBuilder.RenameColumn(
                name: "TrabajadorId",
                table: "CC_Pago",
                newName: "Trabajador_Id");

            migrationBuilder.RenameColumn(
                name: "Voucher",
                table: "CC_Pago",
                newName: "Comprobante");

            migrationBuilder.RenameColumn(
                name: "ProyectoId",
                table: "CC_Interesado_Proyecto",
                newName: "Proyecto_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Interesado_Proyecto_ProyectoId",
                table: "CC_Interesado_Proyecto",
                newName: "IX_CC_Interesado_Proyecto_Proyecto_Id");

            migrationBuilder.RenameColumn(
                name: "ProyectoId",
                table: "CC_Ingreso_Proyecto",
                newName: "Proyecto_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Ingreso_Proyecto_ProyectoId",
                table: "CC_Ingreso_Proyecto",
                newName: "IX_CC_Ingreso_Proyecto_Proyecto_Id");

            migrationBuilder.RenameColumn(
                name: "ProyectoId",
                table: "CC_Gastos_Proyecto",
                newName: "Proyecto_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Gastos_Proyecto_ProyectoId",
                table: "CC_Gastos_Proyecto",
                newName: "IX_CC_Gastos_Proyecto_Proyecto_Id");

            migrationBuilder.RenameColumn(
                name: "TrabajadorId",
                table: "CC_Asistencia",
                newName: "Trabajador_Id");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Asistencia_TrabajadorId",
                table: "CC_Asistencia",
                newName: "IX_CC_Asistencia_Trabajador_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Sueldo",
                table: "CC_Trabajador",
                type: "int",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "real");

            migrationBuilder.AlterColumn<string>(
                name: "Ciclo_Pago",
                table: "CC_Trabajador",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo_Pago",
                table: "CC_Pago",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated_At",
                table: "CC_Asistencia",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CC_Cliente",
                table: "CC_Cliente",
                column: "Cliente_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Asistencia_CC_Trabajador_Trabajador_Id",
                table: "CC_Asistencia",
                column: "Trabajador_Id",
                principalTable: "CC_Trabajador",
                principalColumn: "Trabajador_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Gastos_Proyecto_CC_Proyecto_Proyecto_Id",
                table: "CC_Gastos_Proyecto",
                column: "Proyecto_Id",
                principalTable: "CC_Proyecto",
                principalColumn: "Proyecto_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Ingreso_Proyecto_CC_Proyecto_Proyecto_Id",
                table: "CC_Ingreso_Proyecto",
                column: "Proyecto_Id",
                principalTable: "CC_Proyecto",
                principalColumn: "Proyecto_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Interesado_Proyecto_CC_Proyecto_Proyecto_Id",
                table: "CC_Interesado_Proyecto",
                column: "Proyecto_Id",
                principalTable: "CC_Proyecto",
                principalColumn: "Proyecto_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Productos_CC_Comercio_Comercio_Id",
                table: "CC_Productos",
                column: "Comercio_Id",
                principalTable: "CC_Comercio",
                principalColumn: "Comercio_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Proyecto_CC_Cliente_Cliente_Id",
                table: "CC_Proyecto",
                column: "Cliente_Id",
                principalTable: "CC_Cliente",
                principalColumn: "Cliente_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Tareas_Proyecto_CC_Proyecto_Proyecto_Id",
                table: "CC_Tareas_Proyecto",
                column: "Proyecto_Id",
                principalTable: "CC_Proyecto",
                principalColumn: "Proyecto_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CC_Asistencia_CC_Trabajador_Trabajador_Id",
                table: "CC_Asistencia");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Gastos_Proyecto_CC_Proyecto_Proyecto_Id",
                table: "CC_Gastos_Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Ingreso_Proyecto_CC_Proyecto_Proyecto_Id",
                table: "CC_Ingreso_Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Interesado_Proyecto_CC_Proyecto_Proyecto_Id",
                table: "CC_Interesado_Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Productos_CC_Comercio_Comercio_Id",
                table: "CC_Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Proyecto_CC_Cliente_Cliente_Id",
                table: "CC_Proyecto");

            migrationBuilder.DropForeignKey(
                name: "FK_CC_Tareas_Proyecto_CC_Proyecto_Proyecto_Id",
                table: "CC_Tareas_Proyecto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CC_Cliente",
                table: "CC_Cliente");

            migrationBuilder.RenameTable(
                name: "CC_Cliente",
                newName: "CC_Client");

            migrationBuilder.RenameColumn(
                name: "Proyecto_Id",
                table: "CC_Tareas_Proyecto",
                newName: "ProyectoId");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Tareas_Proyecto_Proyecto_Id",
                table: "CC_Tareas_Proyecto",
                newName: "IX_CC_Tareas_Proyecto_ProyectoId");

            migrationBuilder.RenameColumn(
                name: "Trabajador_Id",
                table: "CC_Proyecto_Diario",
                newName: "TrabajadorId");

            migrationBuilder.RenameColumn(
                name: "Proyecto_Id",
                table: "CC_Proyecto_Diario",
                newName: "ProyectoId");

            migrationBuilder.RenameColumn(
                name: "Cliente_Id",
                table: "CC_Proyecto",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Interesado",
                table: "CC_Proyecto",
                newName: "Responsable");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Proyecto_Cliente_Id",
                table: "CC_Proyecto",
                newName: "IX_CC_Proyecto_ClienteId");

            migrationBuilder.RenameColumn(
                name: "Comercio_Id",
                table: "CC_Productos",
                newName: "ComercioId");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Productos_Comercio_Id",
                table: "CC_Productos",
                newName: "IX_CC_Productos_ComercioId");

            migrationBuilder.RenameColumn(
                name: "Trabajador_Id",
                table: "CC_Pago",
                newName: "TrabajadorId");

            migrationBuilder.RenameColumn(
                name: "Comprobante",
                table: "CC_Pago",
                newName: "Voucher");

            migrationBuilder.RenameColumn(
                name: "Proyecto_Id",
                table: "CC_Interesado_Proyecto",
                newName: "ProyectoId");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Interesado_Proyecto_Proyecto_Id",
                table: "CC_Interesado_Proyecto",
                newName: "IX_CC_Interesado_Proyecto_ProyectoId");

            migrationBuilder.RenameColumn(
                name: "Proyecto_Id",
                table: "CC_Ingreso_Proyecto",
                newName: "ProyectoId");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Ingreso_Proyecto_Proyecto_Id",
                table: "CC_Ingreso_Proyecto",
                newName: "IX_CC_Ingreso_Proyecto_ProyectoId");

            migrationBuilder.RenameColumn(
                name: "Proyecto_Id",
                table: "CC_Gastos_Proyecto",
                newName: "ProyectoId");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Gastos_Proyecto_Proyecto_Id",
                table: "CC_Gastos_Proyecto",
                newName: "IX_CC_Gastos_Proyecto_ProyectoId");

            migrationBuilder.RenameColumn(
                name: "Trabajador_Id",
                table: "CC_Asistencia",
                newName: "TrabajadorId");

            migrationBuilder.RenameIndex(
                name: "IX_CC_Asistencia_Trabajador_Id",
                table: "CC_Asistencia",
                newName: "IX_CC_Asistencia_TrabajadorId");

            migrationBuilder.AlterColumn<float>(
                name: "Sueldo",
                table: "CC_Trabajador",
                type: "real",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Ciclo_Pago",
                table: "CC_Trabajador",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "Tipo_Pago",
                table: "CC_Pago",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<DateTime>(
                name: "Updated_At",
                table: "CC_Asistencia",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_CC_Client",
                table: "CC_Client",
                column: "Cliente_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Asistencia_CC_Trabajador_TrabajadorId",
                table: "CC_Asistencia",
                column: "TrabajadorId",
                principalTable: "CC_Trabajador",
                principalColumn: "Trabajador_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Gastos_Proyecto_CC_Proyecto_ProyectoId",
                table: "CC_Gastos_Proyecto",
                column: "ProyectoId",
                principalTable: "CC_Proyecto",
                principalColumn: "Proyecto_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Ingreso_Proyecto_CC_Proyecto_ProyectoId",
                table: "CC_Ingreso_Proyecto",
                column: "ProyectoId",
                principalTable: "CC_Proyecto",
                principalColumn: "Proyecto_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Interesado_Proyecto_CC_Proyecto_ProyectoId",
                table: "CC_Interesado_Proyecto",
                column: "ProyectoId",
                principalTable: "CC_Proyecto",
                principalColumn: "Proyecto_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Productos_CC_Comercio_ComercioId",
                table: "CC_Productos",
                column: "ComercioId",
                principalTable: "CC_Comercio",
                principalColumn: "Comercio_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Proyecto_CC_Client_ClienteId",
                table: "CC_Proyecto",
                column: "ClienteId",
                principalTable: "CC_Client",
                principalColumn: "Cliente_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CC_Tareas_Proyecto_CC_Proyecto_ProyectoId",
                table: "CC_Tareas_Proyecto",
                column: "ProyectoId",
                principalTable: "CC_Proyecto",
                principalColumn: "Proyecto_Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
