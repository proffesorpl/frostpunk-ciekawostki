using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace frostpunk2_ciekawostki.Migrations
{
    /// <inheritdoc />
    public partial class Kategorie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ZdjeciaURL",
                table: "Ciekawostki",
                newName: "ZdjecieURL");

            migrationBuilder.AddColumn<int>(
                name: "KategoriaID",
                table: "Ciekawostki",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Kategorie",
                columns: table => new
                {
                    KategoriaID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nazwa = table.Column<string>(type: "TEXT", nullable: false),
                    Opis = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategorie", x => x.KategoriaID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ciekawostki_KategoriaID",
                table: "Ciekawostki",
                column: "KategoriaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Ciekawostki_Kategorie_KategoriaID",
                table: "Ciekawostki",
                column: "KategoriaID",
                principalTable: "Kategorie",
                principalColumn: "KategoriaID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ciekawostki_Kategorie_KategoriaID",
                table: "Ciekawostki");

            migrationBuilder.DropTable(
                name: "Kategorie");

            migrationBuilder.DropIndex(
                name: "IX_Ciekawostki_KategoriaID",
                table: "Ciekawostki");

            migrationBuilder.DropColumn(
                name: "KategoriaID",
                table: "Ciekawostki");

            migrationBuilder.RenameColumn(
                name: "ZdjecieURL",
                table: "Ciekawostki",
                newName: "ZdjeciaURL");
        }
    }
}
