﻿using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Food_Menu.Migrations
{
    /// <inheritdoc />
    public partial class dbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<float>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "DishIngredients",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "int", nullable: false),
                    IngredientId = table.Column<int>(type: "int", nullable: false),
                    DishIngredientDishId = table.Column<int>(type: "int", nullable: true),
                    DishIngredientIngredientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishIngredients", x => new { x.DishId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_DishIngredients_DishIngredients_DishIngredientDishId_DishIng~",
                        columns: x => new { x.DishIngredientDishId, x.DishIngredientIngredientId },
                        principalTable: "DishIngredients",
                        principalColumns: new[] { "DishId", "IngredientId" });
                    table.ForeignKey(
                        name: "FK_DishIngredients_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DishIngredients_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "Id", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, "data:image/jpeg;base64,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", "Pizza", 7.59f });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tomato Sauce" },
                    { 2, "Mozzarella" }
                });

            migrationBuilder.InsertData(
                table: "DishIngredients",
                columns: new[] { "DishId", "IngredientId", "DishIngredientDishId", "DishIngredientIngredientId" },
                values: new object[,]
                {
                    { 1, 1, null, null },
                    { 1, 2, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishIngredients_DishIngredientDishId_DishIngredientIngredien~",
                table: "DishIngredients",
                columns: new[] { "DishIngredientDishId", "DishIngredientIngredientId" });

            migrationBuilder.CreateIndex(
                name: "IX_DishIngredients_IngredientId",
                table: "DishIngredients",
                column: "IngredientId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishIngredients");

            migrationBuilder.DropTable(
                name: "Dishes");

            migrationBuilder.DropTable(
                name: "Ingredients");
        }
    }
}
