using Microsoft.EntityFrameworkCore.Migrations;

namespace DatosPaciente.Data.Migrations
{
    public partial class AddPacientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pacientes",
                columns: table => new
                {
                    PacienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PacienteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ApellidoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CorreoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcompaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcompaApellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionPrimera = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DireccionSegunda = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CiudadPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PostalPaciente = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroTelefono = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AreaWhats = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroWhats = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pacientes", x => x.PacienteID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pacientes");
        }
    }
}
