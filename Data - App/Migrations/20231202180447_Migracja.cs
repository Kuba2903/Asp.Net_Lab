using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data___App.Migrations
{
    public partial class Migracja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "7ddad46b-f708-4ec5-b0d0-cc5f586f3100", "7ddad46b-f708-4ec5-b0d0-cc5f586f3100", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "85174cec-84d7-4d20-9234-12e9171f6d28", "85174cec-84d7-4d20-9234-12e9171f6d28", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3a240411-4711-4b80-9dbd-5d22c9798a76", 0, "c10aca48-87e2-4bc5-8f4f-401ff8499403", "adam@wsei.edu.pl", true, false, null, "adam@wsei.edu.pl", "ADAM", "AQAAAAEAACcQAAAAECx+niiBuqxBwCBn7uaEegOkicX7A5B8tQyeMB0XxwLwRQIe1xz6l86viQU2VCVQtA==", null, false, "86c459c7-5f93-46eb-9e2e-b7bf37cb3887", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "7e428264-eb9c-4118-b818-febddbe76718", 0, "1401377c-c5a2-480a-91b8-991fa895cc78", "karolina@wsei.edu.pl", true, false, null, "karolina@wsei.edu.pl", "KAROLINA", "AQAAAAEAACcQAAAAEDuk7BkhnwOgDH9y0MYYTKBxUKkg/38ZEwzpPxMkg5NNapDjNZfkHebj4w0UhIymPA==", null, false, "7bddb19e-df50-4930-bef1-28452b4c7365", false, "karolina" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "85174cec-84d7-4d20-9234-12e9171f6d28", "3a240411-4711-4b80-9dbd-5d22c9798a76" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "7ddad46b-f708-4ec5-b0d0-cc5f586f3100", "7e428264-eb9c-4118-b818-febddbe76718" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "85174cec-84d7-4d20-9234-12e9171f6d28", "3a240411-4711-4b80-9dbd-5d22c9798a76" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "7ddad46b-f708-4ec5-b0d0-cc5f586f3100", "7e428264-eb9c-4118-b818-febddbe76718" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7ddad46b-f708-4ec5-b0d0-cc5f586f3100");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "85174cec-84d7-4d20-9234-12e9171f6d28");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a240411-4711-4b80-9dbd-5d22c9798a76");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e428264-eb9c-4118-b818-febddbe76718");

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
    }
}
