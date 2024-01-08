using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "author",
                columns: table => new
                {
                    id_author = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_author", x => x.id_author);
                });

            migrationBuilder.CreateTable(
                name: "city",
                columns: table => new
                {
                    id_city = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    day_delivery = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_city", x => x.id_city);
                });

            migrationBuilder.CreateTable(
                name: "genre",
                columns: table => new
                {
                    id_genre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genre", x => x.id_genre);
                });

            migrationBuilder.CreateTable(
                name: "stage",
                columns: table => new
                {
                    id_stage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stage", x => x.id_stage);
                });

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id_user = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    surname = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    id_city = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_user", x => x.id_user);
                    table.ForeignKey(
                        name: "FK_user_city_CityId",
                        column: x => x.CityId,
                        principalTable: "city",
                        principalColumn: "id_city",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "book",
                columns: table => new
                {
                    id_book = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_author = table.Column<int>(type: "int", nullable: false),
                    id_genre = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    amount = table.Column<int>(type: "int", nullable: false),
                    price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book", x => x.id_book);
                    table.ForeignKey(
                        name: "FK_book_author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "author",
                        principalColumn: "id_author",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_book_genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "genre",
                        principalColumn: "id_genre",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    id_order = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    id_user = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.id_order);
                    table.ForeignKey(
                        name: "FK_order_user_id_user",
                        column: x => x.id_user,
                        principalTable: "user",
                        principalColumn: "id_user",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "book_order",
                columns: table => new
                {
                    id_book_order = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_book = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    id_order = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_book_order", x => x.id_book_order);
                    table.ForeignKey(
                        name: "FK_book_order_book_BookId",
                        column: x => x.BookId,
                        principalTable: "book",
                        principalColumn: "id_book",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_book_order_order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "order",
                        principalColumn: "id_order",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_stage",
                columns: table => new
                {
                    id_order_stage = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_order = table.Column<int>(type: "int", nullable: false),
                    id_stage = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    StageId = table.Column<int>(type: "int", nullable: false),
                    date_step_beg = table.Column<DateTime>(type: "datetime2", nullable: false),
                    date_step_end = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderStageId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_stage", x => x.id_order_stage);
                    table.ForeignKey(
                        name: "FK_order_stage_order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "order",
                        principalColumn: "id_order",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_stage_order_stage_OrderStageId",
                        column: x => x.OrderStageId,
                        principalTable: "order_stage",
                        principalColumn: "id_order_stage");
                    table.ForeignKey(
                        name: "FK_order_stage_stage_StageId",
                        column: x => x.StageId,
                        principalTable: "stage",
                        principalColumn: "id_stage",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_book_AuthorId",
                table: "book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_book_GenreId",
                table: "book",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_book_order_BookId",
                table: "book_order",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_book_order_OrderId",
                table: "book_order",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_order_id_user",
                table: "order",
                column: "id_user");

            migrationBuilder.CreateIndex(
                name: "IX_order_stage_OrderId",
                table: "order_stage",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_order_stage_OrderStageId",
                table: "order_stage",
                column: "OrderStageId");

            migrationBuilder.CreateIndex(
                name: "IX_order_stage_StageId",
                table: "order_stage",
                column: "StageId");

            migrationBuilder.CreateIndex(
                name: "IX_user_CityId",
                table: "user",
                column: "CityId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "book_order");

            migrationBuilder.DropTable(
                name: "order_stage");

            migrationBuilder.DropTable(
                name: "book");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "stage");

            migrationBuilder.DropTable(
                name: "author");

            migrationBuilder.DropTable(
                name: "genre");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "city");
        }
    }
}
