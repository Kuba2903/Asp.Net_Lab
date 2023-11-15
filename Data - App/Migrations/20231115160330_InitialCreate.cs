using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data___App.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Model = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Producent = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    PojemnoscSilnika = table.Column<decimal>(type: "TEXT", nullable: false),
                    Moc = table.Column<int>(type: "INTEGER", nullable: false),
                    RodzajSilnika = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    NrRejestracyjny = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Wlasciciel = table.Column<string>(type: "TEXT", maxLength: 75, nullable: false),
                    Priorytet = table.Column<byte>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Moc", "Model", "NrRejestracyjny", "PojemnoscSilnika", "Priorytet", "Producent", "RodzajSilnika", "Wlasciciel" },
                values: new object[] { 1, 2, "Octavia", "TNB", 2m, (byte)2, "Skoda", "tdi", "Wlasciciel" });

            migrationBuilder.InsertData(
                table: "cars",
                columns: new[] { "Id", "Moc", "Model", "NrRejestracyjny", "PojemnoscSilnika", "Priorytet", "Producent", "RodzajSilnika", "Wlasciciel" },
                values: new object[] { 2, 3, "Astra", "KDA", 2m, (byte)2, "Opel", "tdi", "Wlasciciel2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cars");
        }
    }
}
