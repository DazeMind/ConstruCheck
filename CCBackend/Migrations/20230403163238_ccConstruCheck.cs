using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCBackend.Migrations
{
    /// <inheritdoc />
    public partial class ccConstruCheck : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CC_Users",
                columns: table => new
                {
                    User_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre_Usuario = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Rut = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Job_Position = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(45)", maxLength: 45, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CC_Users", x => x.User_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CC_Users");
        }
    }
}
