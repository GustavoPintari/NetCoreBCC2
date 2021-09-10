using Microsoft.EntityFrameworkCore.Migrations;

namespace WebCoreBCC2.Migrations
{
    public partial class ProfessorMapC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Professores_professorID",
                table: "Disciplinas");

            migrationBuilder.AlterColumn<int>(
                name: "idade",
                table: "Professores",
                type: "Int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "contato",
                table: "Professores",
                type: "Int",
                maxLength: 12,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Professores_professorID",
                table: "Disciplinas",
                column: "professorID",
                principalTable: "Professores",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disciplinas_Professores_professorID",
                table: "Disciplinas");

            migrationBuilder.AlterColumn<int>(
                name: "idade",
                table: "Professores",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "Int");

            migrationBuilder.AlterColumn<int>(
                name: "contato",
                table: "Professores",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "Int",
                oldMaxLength: 12);

            migrationBuilder.AddForeignKey(
                name: "FK_Disciplinas_Professores_professorID",
                table: "Disciplinas",
                column: "professorID",
                principalTable: "Professores",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
