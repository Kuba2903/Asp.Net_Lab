using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data___App.Migrations
{
    public partial class _1212232 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "c3ca414d-4692-4825-aabf-1611a21a0cbf", "c3ca414d-4692-4825-aabf-1611a21a0cbf", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f1edf7f8-94ae-4bed-9c6b-c19af393d2f6", "f1edf7f8-94ae-4bed-9c6b-c19af393d2f6", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "aac7100b-24d4-4b0c-a0a1-0b069fb9fbba", 0, "2ac902f1-007f-4880-ad41-7b8ae12237a9", "karolina@wsei.edu.pl", true, false, null, "KAROLINA@WSEI.EDU.PL", "KAROLINA", "AQAAAAEAACcQAAAAEKmr8xIVA34uXthZZVyAQGsQxkabYw40A6Vc/8+7wb/cNwK3TIyLokchq5YPAXcAKA==", null, false, "b671b99b-c5b7-4234-9fc8-152e1817e8ad", false, "karolina" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "cb32d5f3-6137-4c9b-bf62-b6f5f45d9d01", 0, "912f278c-4c12-425b-b9e8-7babe7bd4398", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADAM", "AQAAAAEAACcQAAAAEAtw383g4dkgtJR4Ki2Yq9G5yWvLPICD1FRnETsnBn1oqDtBaj2T/QFff3D73DyEOQ==", null, false, "531386d5-09aa-434c-aea3-1ebc1c21d8e4", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c3ca414d-4692-4825-aabf-1611a21a0cbf", "aac7100b-24d4-4b0c-a0a1-0b069fb9fbba" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "f1edf7f8-94ae-4bed-9c6b-c19af393d2f6", "cb32d5f3-6137-4c9b-bf62-b6f5f45d9d01" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3ca414d-4692-4825-aabf-1611a21a0cbf", "aac7100b-24d4-4b0c-a0a1-0b069fb9fbba" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f1edf7f8-94ae-4bed-9c6b-c19af393d2f6", "cb32d5f3-6137-4c9b-bf62-b6f5f45d9d01" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3ca414d-4692-4825-aabf-1611a21a0cbf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f1edf7f8-94ae-4bed-9c6b-c19af393d2f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aac7100b-24d4-4b0c-a0a1-0b069fb9fbba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cb32d5f3-6137-4c9b-bf62-b6f5f45d9d01");

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
    }
}
