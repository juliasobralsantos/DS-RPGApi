using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RPGApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_HABILIDADES",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_HABILIDADES", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_PERSONAGENS_HABILIDADES",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PERSONAGENS_HABILIDADES", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_HABILIDADES_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "TB_HABILIDADES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TB_PERSONAGENS_HABILIDADES_TB_PERSONAGENS_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "TB_PERSONAGENS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "TB_HABILIDADES",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 222, 194, 2, 140, 178, 132, 101, 64, 221, 177, 242, 34, 35, 82, 83, 95, 253, 110, 171, 57, 116, 11, 221, 22, 58, 110, 178, 102, 90, 57, 18, 226, 166, 126, 245, 229, 133, 98, 42, 95, 203, 136, 62, 46, 152, 21, 77, 183, 105, 0, 116, 123, 141, 206, 123, 217, 66, 227, 63, 26, 39, 175, 68, 193 }, new byte[] { 193, 39, 174, 129, 137, 189, 94, 236, 162, 218, 93, 4, 18, 13, 154, 89, 164, 27, 198, 97, 130, 100, 42, 61, 33, 190, 47, 91, 168, 197, 142, 136, 103, 100, 80, 139, 138, 83, 64, 41, 89, 96, 66, 228, 176, 80, 192, 203, 172, 137, 138, 16, 127, 133, 10, 66, 36, 83, 60, 69, 160, 185, 206, 19, 192, 59, 119, 35, 170, 251, 117, 209, 229, 174, 182, 96, 35, 111, 26, 214, 10, 115, 199, 73, 123, 17, 120, 108, 98, 33, 30, 64, 167, 52, 111, 126, 40, 194, 239, 214, 5, 222, 134, 188, 7, 174, 49, 28, 52, 168, 172, 21, 225, 98, 157, 94, 191, 72, 204, 91, 148, 180, 98, 123, 191, 190, 111, 135 } });

            migrationBuilder.InsertData(
                table: "TB_PERSONAGENS_HABILIDADES",
                columns: new[] { "HabilidadeId", "PersonagemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 3 },
                    { 3, 3 },
                    { 3, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 3, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_PERSONAGENS_HABILIDADES_HabilidadeId",
                table: "TB_PERSONAGENS_HABILIDADES",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TB_PERSONAGENS_HABILIDADES");

            migrationBuilder.DropTable(
                name: "TB_HABILIDADES");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 18, 4, 249, 119, 121, 17, 44, 197, 222, 53, 142, 44, 220, 108, 146, 120, 87, 221, 50, 240, 19, 162, 201, 15, 251, 213, 11, 152, 11, 131, 26, 128, 49, 5, 24, 51, 160, 22, 107, 60, 81, 75, 95, 48, 81, 130, 152, 161, 18, 186, 68, 160, 243, 226, 225, 144, 163, 219, 193, 94, 226, 19, 169, 248 }, new byte[] { 54, 1, 255, 245, 241, 81, 13, 121, 21, 19, 216, 0, 15, 190, 139, 108, 91, 230, 162, 211, 248, 103, 188, 112, 49, 0, 226, 30, 97, 139, 71, 11, 52, 201, 197, 67, 229, 193, 41, 208, 0, 101, 247, 144, 18, 174, 20, 173, 191, 199, 131, 228, 196, 107, 141, 28, 119, 19, 251, 191, 233, 151, 37, 219, 113, 197, 250, 193, 134, 61, 149, 94, 115, 211, 218, 133, 235, 154, 102, 192, 18, 193, 135, 118, 40, 36, 13, 63, 28, 96, 129, 207, 254, 233, 193, 252, 23, 113, 133, 9, 239, 136, 217, 223, 8, 133, 110, 30, 251, 253, 153, 240, 90, 17, 32, 34, 119, 102, 217, 192, 1, 32, 87, 12, 49, 167, 2, 216 } });
        }
    }
}
