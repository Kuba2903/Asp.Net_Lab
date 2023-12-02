using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data___App.Migrations
{
    public partial class FourthMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "57d91c4b-be48-4ede-88e9-dcc0c6a42efc", "4422f57c-2ed4-452e-bd4e-74e46054d5a9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0551b7f5-d146-47ec-9eb3-0e62febc3d6a", "50114480-82c4-4521-a217-d260a2510954" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0551b7f5-d146-47ec-9eb3-0e62febc3d6a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "57d91c4b-be48-4ede-88e9-dcc0c6a42efc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4422f57c-2ed4-452e-bd4e-74e46054d5a9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50114480-82c4-4521-a217-d260a2510954");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51ec80cc-1aa0-447d-a11b-d79ef9d8d246", "51ec80cc-1aa0-447d-a11b-d79ef9d8d246", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bb359dfe-7087-4fb9-ad2a-b646613c5a07", "bb359dfe-7087-4fb9-ad2a-b646613c5a07", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "79606311-49ed-4abd-8f01-27f580f217fe", 0, "dad166e0-33db-45ae-b28a-7613f051a322", "karolina@wsei.edu.pl", true, false, null, "karolina@wsei.edu.pl", "KAROLINA", "AQAAAAEAACcQAAAAEHq5cGqU3/QabzfxA6pRODqe+TKm1KXTRA30v21W2nYIzz5V69+5n2TR3UxNaq9k8w==", null, false, "55fb0b81-bb94-4363-bcba-276165d2fd2f", false, "karolina" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b03bee7a-f912-4ff3-a991-8d332e2150a0", 0, "806db565-cbca-4763-8706-e45a750493f3", "adam@wsei.edu.pl", true, false, null, "adam@wsei.edu.pl", "ADAM", "AQAAAAEAACcQAAAAEMBL4jO5Y5WlYi+C/m3nZjMo3+vpAul1JRsfzZje+MOmWPl3xsLVR4rlGgsom1I5jg==", null, false, "cfecc988-003d-4500-a540-7b910388999b", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "51ec80cc-1aa0-447d-a11b-d79ef9d8d246", "79606311-49ed-4abd-8f01-27f580f217fe" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bb359dfe-7087-4fb9-ad2a-b646613c5a07", "b03bee7a-f912-4ff3-a991-8d332e2150a0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "51ec80cc-1aa0-447d-a11b-d79ef9d8d246", "79606311-49ed-4abd-8f01-27f580f217fe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bb359dfe-7087-4fb9-ad2a-b646613c5a07", "b03bee7a-f912-4ff3-a991-8d332e2150a0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51ec80cc-1aa0-447d-a11b-d79ef9d8d246");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bb359dfe-7087-4fb9-ad2a-b646613c5a07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "79606311-49ed-4abd-8f01-27f580f217fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b03bee7a-f912-4ff3-a991-8d332e2150a0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "0551b7f5-d146-47ec-9eb3-0e62febc3d6a", "0551b7f5-d146-47ec-9eb3-0e62febc3d6a", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "57d91c4b-be48-4ede-88e9-dcc0c6a42efc", "57d91c4b-be48-4ede-88e9-dcc0c6a42efc", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4422f57c-2ed4-452e-bd4e-74e46054d5a9", 0, "53b83b68-db60-4d54-93ee-27984878e19a", "karolina@wsei.edu.pl", true, false, null, null, "KAROLINA", "AQAAAAEAACcQAAAAEJDkdP8Ven5sEFK0RwsF2pxUY5eA3O0vpCrJXlIQlED9XS+BNfTX32eOtL0X7QSDBQ==", null, false, "ba9ee8c4-76da-4f1b-954f-5a2b2d60cbb8", false, "karolina" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "50114480-82c4-4521-a217-d260a2510954", 0, "6956fd82-f35b-4f49-b625-7eb81e42c84e", "adam@wsei.edu.pl", true, false, null, null, "ADMIN", "AQAAAAEAACcQAAAAEN1DFlaQ0hsTGC61AE9RxYX8QRmZjKNubEEM1Je0WSnzZPnyEdYu+tUhvLKc/XuZVQ==", null, false, "5ff1bf27-ec82-4565-832c-feafa4fd7040", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "57d91c4b-be48-4ede-88e9-dcc0c6a42efc", "4422f57c-2ed4-452e-bd4e-74e46054d5a9" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0551b7f5-d146-47ec-9eb3-0e62febc3d6a", "50114480-82c4-4521-a217-d260a2510954" });
        }
    }
}
