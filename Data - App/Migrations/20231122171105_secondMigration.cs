using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data___App.Migrations
{
    public partial class secondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrganizationId",
                table: "cars",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Organizations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Tytul = table.Column<string>(type: "TEXT", nullable: false),
                    Region = table.Column<string>(type: "TEXT", nullable: false),
                    Nip = table.Column<string>(type: "TEXT", nullable: false),
                    Address_Miasto = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Ulica = table.Column<string>(type: "TEXT", nullable: true),
                    Address_KodPocztowy = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Region = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Organizations", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Nip", "Region", "Tytul", "Address_KodPocztowy", "Address_Miasto", "Address_Region", "Address_Ulica" },
                values: new object[] { 1, "83492384", "13424234", "WSEI", "31-150", "Kraków", "małopolskie", "Św. Filipa 17" });

            migrationBuilder.InsertData(
                table: "Organizations",
                columns: new[] { "Id", "Nip", "Region", "Tytul", "Address_KodPocztowy", "Address_Miasto", "Address_Region", "Address_Ulica" },
                values: new object[] { 2, "2498534", "0873439249", "Firma", "31-150", "Kraków", "małopolskie", "Krowoderska 45/6" });

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 1,
                column: "OrganizationId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "cars",
                keyColumn: "Id",
                keyValue: 2,
                column: "OrganizationId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_cars_OrganizationId",
                table: "cars",
                column: "OrganizationId");

            migrationBuilder.AddForeignKey(
                name: "FK_cars_Organizations_OrganizationId",
                table: "cars",
                column: "OrganizationId",
                principalTable: "Organizations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_cars_Organizations_OrganizationId",
                table: "cars");

            migrationBuilder.DropTable(
                name: "Organizations");

            migrationBuilder.DropIndex(
                name: "IX_cars_OrganizationId",
                table: "cars");

            migrationBuilder.DropColumn(
                name: "OrganizationId",
                table: "cars");
        }
    }
}
