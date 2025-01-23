using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RentNest.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Categories_CategoryId",
                table: "Houses");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "00e76981-0a72-4e0b-b607-d70809e59c9a", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAIAAYagAAAAEO0SKdompWJt8Vcj9GNOZw/qMrDx6xLyskSoBYzrCxzaOZWK291iZJU5CzbwQm/opg==", null, false, "c99529f2-c101-4db3-b078-3bb4313c61e8", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "281259df-ddc8-4fe1-a809-1290b269df1b", "agent@mail.com", false, false, null, "agent@mail.com", "agent@mail.com", "AQAAAAIAAYagAAAAEAyerSiU952OIgQKUxXn5iP5TaZpHw7xq11vXa0Hq1NPatL2ecKYdFnBtczfveyD8A==", null, false, "90bf2128-94cc-45a0-a0a0-a6046be92f20", false, "agent@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Cottage" },
                    { 2, "Single-Family" },
                    { 3, "Duplex" }
                });

            migrationBuilder.InsertData(
                table: "Agents",
                columns: new[] { "Id", "PhoneNumber", "UserId" },
                values: new object[] { 1, "+359888888888", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Houses",
                columns: new[] { "Id", "Address", "AgentId", "CategoryId", "Description", "ImageUrl", "PricePerMonth", "RenterId", "Title" },
                values: new object[,]
                {
                    { 1, "North London, UK (near the border)", 1, 3, "A big house for your whole family. Don't miss to buy a house with three bedrooms.", "https://www.luxury-architecture.net/wp-content/uploads/2017/12/1513217889-7597-FAIRWAYS-010.jpg", 2100.00m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "Big House Marina" },
                    { 2, "Near the Sea Garden in Burgas, Bulgaria", 1, 2, "It has the best comfort you will ever ask for. With two bedrooms, it is great for your family.", "https://cf.bstatic.com/xdata/images/hotel/max1024x768/179489660.jpg?k=2029f6d9589b49c95dcc9503a265e292c2cdfcb5277487a0050397c3f8dd545a&o=&hp=1", 1200.00m, null, "Family House Comfort" },
                    { 3, "Boyana Neighbourhood, Sofia, Bulgaria", 1, 2, "This luxurious house is everything you will need. It is just excellent.", "https://i.pinimg.com/originals/a6/f5/85/a6f5850a77633c56e4e4ac4f867e3c00.jpg", 2000.00m, null, "Grand House" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Categories_CategoryId",
                table: "Houses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses");

            migrationBuilder.DropForeignKey(
                name: "FK_Houses_Categories_CategoryId",
                table: "Houses");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Houses",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Agents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Agents_AgentId",
                table: "Houses",
                column: "AgentId",
                principalTable: "Agents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Houses_Categories_CategoryId",
                table: "Houses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
