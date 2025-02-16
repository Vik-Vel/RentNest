using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentNest.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3a2a648-b4f0-4f06-b5f5-7d503bcb5ef9", "AQAAAAIAAYagAAAAENJ9MCnvuVh1kxevFsAy2SjkpSISk4bMRq8wnjs/M0boFzNHfR6koTAm5OU5VJFF8w==", "a1a40381-165d-470c-aade-86d5a5924094" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39f54956-eba2-4418-8f39-99aae30f5d93", "AQAAAAIAAYagAAAAEA/TvgkjmUig4mdbI1un2xWIrifchj1+nygnP4FKIluPNja8eclUpdV0aqs7jBYs5w==", "8a41da85-61de-42f1-8b57-7f934900ff8b" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00e76981-0a72-4e0b-b607-d70809e59c9a", "AQAAAAIAAYagAAAAEO0SKdompWJt8Vcj9GNOZw/qMrDx6xLyskSoBYzrCxzaOZWK291iZJU5CzbwQm/opg==", "c99529f2-c101-4db3-b078-3bb4313c61e8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "281259df-ddc8-4fe1-a809-1290b269df1b", "AQAAAAIAAYagAAAAEAyerSiU952OIgQKUxXn5iP5TaZpHw7xq11vXa0Hq1NPatL2ecKYdFnBtczfveyD8A==", "90bf2128-94cc-45a0-a0a0-a6046be92f20" });
        }
    }
}
