using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPGApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "TB_PERSONAGENS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "TB_ARMAS",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 1,
                column: "PersonagemId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 2,
                column: "PersonagemId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 3,
                column: "PersonagemId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 4,
                column: "PersonagemId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 5,
                column: "PersonagemId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 6,
                column: "PersonagemId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "TB_ARMAS",
                keyColumn: "Id",
                keyValue: 7,
                column: "PersonagemId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_PERSONAGENS",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 18, 4, 249, 119, 121, 17, 44, 197, 222, 53, 142, 44, 220, 108, 146, 120, 87, 221, 50, 240, 19, 162, 201, 15, 251, 213, 11, 152, 11, 131, 26, 128, 49, 5, 24, 51, 160, 22, 107, 60, 81, 75, 95, 48, 81, 130, 152, 161, 18, 186, 68, 160, 243, 226, 225, 144, 163, 219, 193, 94, 226, 19, 169, 248 }, new byte[] { 54, 1, 255, 245, 241, 81, 13, 121, 21, 19, 216, 0, 15, 190, 139, 108, 91, 230, 162, 211, 248, 103, 188, 112, 49, 0, 226, 30, 97, 139, 71, 11, 52, 201, 197, 67, 229, 193, 41, 208, 0, 101, 247, 144, 18, 174, 20, 173, 191, 199, 131, 228, 196, 107, 141, 28, 119, 19, 251, 191, 233, 151, 37, 219, 113, 197, 250, 193, 134, 61, 149, 94, 115, 211, 218, 133, 235, 154, 102, 192, 18, 193, 135, 118, 40, 36, 13, 63, 28, 96, 129, 207, 254, 233, 193, 252, 23, 113, 133, 9, 239, 136, 217, 223, 8, 133, 110, 30, 251, 253, 153, 240, 90, 17, 32, 34, 119, 102, 217, 192, 1, 32, 87, 12, 49, 167, 2, 216 } });

            migrationBuilder.CreateIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS",
                column: "PersonagemId",
                principalTable: "TB_PERSONAGENS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ARMAS_TB_PERSONAGENS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropIndex(
                name: "IX_TB_ARMAS_PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "TB_PERSONAGENS");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "TB_ARMAS");

            migrationBuilder.UpdateData(
                table: "TB_USUARIOS",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 94, 218, 62, 246, 203, 206, 102, 223, 210, 177, 171, 28, 172, 121, 60, 23, 107, 170, 42, 253, 105, 17, 193, 49, 176, 197, 97, 138, 99, 152, 111, 200, 69, 239, 250, 151, 87, 225, 107, 142, 71, 91, 186, 239, 213, 149, 237, 141, 83, 139, 178, 95, 193, 120, 41, 196, 167, 132, 42, 133, 155, 19, 135, 110 }, new byte[] { 197, 176, 88, 230, 19, 168, 108, 254, 235, 182, 142, 203, 38, 65, 48, 239, 241, 1, 125, 168, 241, 186, 239, 197, 30, 112, 181, 103, 29, 172, 163, 174, 188, 205, 174, 176, 96, 126, 156, 242, 143, 72, 161, 7, 83, 161, 170, 211, 76, 30, 35, 169, 231, 84, 75, 62, 82, 64, 60, 229, 134, 25, 75, 40, 207, 184, 191, 88, 131, 15, 216, 92, 52, 44, 136, 180, 198, 155, 248, 213, 200, 110, 80, 247, 161, 190, 94, 29, 206, 33, 35, 183, 228, 206, 195, 156, 251, 64, 25, 26, 2, 145, 106, 74, 82, 211, 223, 0, 42, 131, 18, 99, 87, 200, 162, 226, 164, 22, 229, 212, 47, 65, 118, 141, 114, 145, 97, 56 } });
        }
    }
}
