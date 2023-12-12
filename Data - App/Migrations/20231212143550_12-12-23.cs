using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data___App.Migrations
{
    public partial class _121223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "8c2f9092-7473-4234-8611-93da3e2befc1", "8c2f9092-7473-4234-8611-93da3e2befc1", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b21ea45a-81fb-4f65-9990-0fef41a76e14", "b21ea45a-81fb-4f65-9990-0fef41a76e14", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "959beeb9-cb31-44d8-99fa-f195ac1ac7d5", 0, "20c4819b-627f-467d-91aa-d9651985a9bd", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEFfGKxAssBP/O3YUvAjli4ZTNTy+ypFLb5GQ6ARZNmbifJFkQFZaAnkVJTyr3g2NFQ==", null, false, "ab5e7235-2a4a-4e1e-87e2-4680830e2c97", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c7b3c0c0-af04-4295-aefa-ce900df58d71", 0, "09a64f27-ca69-4bc0-b59b-5141213d3171", "karolina@wsei.edu.pl", true, false, null, "KAROLINA@WSEI.EDU.PL", "KAROLINA", "AQAAAAEAACcQAAAAEJJSg3XC/pW9cjXYF7vZNDOZp/eAADnKzEyI+CzmgIPKD6lj8NN43FnXl9UiZa5T0Q==", null, false, "c9a826ff-5a0c-4757-ba09-1335e79b1712", false, "karolina" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8c2f9092-7473-4234-8611-93da3e2befc1", "959beeb9-cb31-44d8-99fa-f195ac1ac7d5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b21ea45a-81fb-4f65-9990-0fef41a76e14", "c7b3c0c0-af04-4295-aefa-ce900df58d71" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c2f9092-7473-4234-8611-93da3e2befc1", "959beeb9-cb31-44d8-99fa-f195ac1ac7d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b21ea45a-81fb-4f65-9990-0fef41a76e14", "c7b3c0c0-af04-4295-aefa-ce900df58d71" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c2f9092-7473-4234-8611-93da3e2befc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b21ea45a-81fb-4f65-9990-0fef41a76e14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "959beeb9-cb31-44d8-99fa-f195ac1ac7d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7b3c0c0-af04-4295-aefa-ce900df58d71");

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
    }
}
