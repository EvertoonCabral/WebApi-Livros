using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApi_Livros.Migrations
{
    /// <inheritdoc />
    public partial class CriandoBancoDeDados : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AutorModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutorModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "LivrosModel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutorID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivrosModel", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LivrosModel_AutorModel_AutorID",
                        column: x => x.AutorID,
                        principalTable: "AutorModel",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LivrosModel_AutorID",
                table: "LivrosModel",
                column: "AutorID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LivrosModel");

            migrationBuilder.DropTable(
                name: "AutorModel");
        }
    }
}
