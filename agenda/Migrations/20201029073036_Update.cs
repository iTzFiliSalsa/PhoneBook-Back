using Microsoft.EntityFrameworkCore.Migrations;

namespace agenda.Migrations
{
    public partial class Update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Agenda",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Agenda",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Agenda",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Agenda",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(100)");

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", nullable: false),
                    Nombre = table.Column<string>(type: "varchar(100)", nullable: true),
                    Cargo = table.Column<string>(type: "varchar(100)", nullable: true),
                    Telefono = table.Column<string>(type: "varchar(100)", nullable: true),
                    Url = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Agenda",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Agenda",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Agenda",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Agenda",
                type: "varchar(100)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);
        }
    }
}
