using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookShopApi.Migrations
{
    /// <inheritdoc />
    public partial class AddRestriction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_author_AuthorId",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_genre_GenreId",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_order_book_BookId",
                table: "book_order");

            migrationBuilder.DropForeignKey(
                name: "FK_book_order_order_OrderId",
                table: "book_order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_stage_order_OrderId",
                table: "order_stage");

            migrationBuilder.DropForeignKey(
                name: "FK_order_stage_order_stage_OrderStageId",
                table: "order_stage");

            migrationBuilder.DropForeignKey(
                name: "FK_order_stage_stage_StageId",
                table: "order_stage");

            migrationBuilder.DropForeignKey(
                name: "FK_user_city_CityId",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_CityId",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_order_stage_OrderId",
                table: "order_stage");

            migrationBuilder.DropIndex(
                name: "IX_order_stage_OrderStageId",
                table: "order_stage");

            migrationBuilder.DropIndex(
                name: "IX_order_stage_StageId",
                table: "order_stage");

            migrationBuilder.DropIndex(
                name: "IX_book_order_BookId",
                table: "book_order");

            migrationBuilder.DropIndex(
                name: "IX_book_order_OrderId",
                table: "book_order");

            migrationBuilder.DropIndex(
                name: "IX_book_AuthorId",
                table: "book");

            migrationBuilder.DropIndex(
                name: "IX_book_GenreId",
                table: "book");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "user");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "order_stage");

            migrationBuilder.DropColumn(
                name: "OrderStageId",
                table: "order_stage");

            migrationBuilder.DropColumn(
                name: "StageId",
                table: "order_stage");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "book_order");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "book_order");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "book");

            migrationBuilder.DropColumn(
                name: "GenreId",
                table: "book");

            migrationBuilder.CreateIndex(
                name: "IX_user_id_city",
                table: "user",
                column: "id_city");

            migrationBuilder.CreateIndex(
                name: "IX_order_stage_id_order",
                table: "order_stage",
                column: "id_order");

            migrationBuilder.CreateIndex(
                name: "IX_order_stage_id_stage",
                table: "order_stage",
                column: "id_stage");

            migrationBuilder.CreateIndex(
                name: "IX_book_order_id_book",
                table: "book_order",
                column: "id_book");

            migrationBuilder.CreateIndex(
                name: "IX_book_order_id_order",
                table: "book_order",
                column: "id_order");

            migrationBuilder.CreateIndex(
                name: "IX_book_id_author",
                table: "book",
                column: "id_author");

            migrationBuilder.CreateIndex(
                name: "IX_book_id_genre",
                table: "book",
                column: "id_genre");

            migrationBuilder.AddForeignKey(
                name: "FK_book_author_id_author",
                table: "book",
                column: "id_author",
                principalTable: "author",
                principalColumn: "id_author",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_genre_id_genre",
                table: "book",
                column: "id_genre",
                principalTable: "genre",
                principalColumn: "id_genre",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_order_book_id_book",
                table: "book_order",
                column: "id_book",
                principalTable: "book",
                principalColumn: "id_book",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_order_order_id_order",
                table: "book_order",
                column: "id_order",
                principalTable: "order",
                principalColumn: "id_order",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_stage_order_id_order",
                table: "order_stage",
                column: "id_order",
                principalTable: "order",
                principalColumn: "id_order",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_stage_stage_id_stage",
                table: "order_stage",
                column: "id_stage",
                principalTable: "stage",
                principalColumn: "id_stage",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_city_id_city",
                table: "user",
                column: "id_city",
                principalTable: "city",
                principalColumn: "id_city",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_book_author_id_author",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_genre_id_genre",
                table: "book");

            migrationBuilder.DropForeignKey(
                name: "FK_book_order_book_id_book",
                table: "book_order");

            migrationBuilder.DropForeignKey(
                name: "FK_book_order_order_id_order",
                table: "book_order");

            migrationBuilder.DropForeignKey(
                name: "FK_order_stage_order_id_order",
                table: "order_stage");

            migrationBuilder.DropForeignKey(
                name: "FK_order_stage_stage_id_stage",
                table: "order_stage");

            migrationBuilder.DropForeignKey(
                name: "FK_user_city_id_city",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_user_id_city",
                table: "user");

            migrationBuilder.DropIndex(
                name: "IX_order_stage_id_order",
                table: "order_stage");

            migrationBuilder.DropIndex(
                name: "IX_order_stage_id_stage",
                table: "order_stage");

            migrationBuilder.DropIndex(
                name: "IX_book_order_id_book",
                table: "book_order");

            migrationBuilder.DropIndex(
                name: "IX_book_order_id_order",
                table: "book_order");

            migrationBuilder.DropIndex(
                name: "IX_book_id_author",
                table: "book");

            migrationBuilder.DropIndex(
                name: "IX_book_id_genre",
                table: "book");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "user",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "order_stage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderStageId",
                table: "order_stage",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StageId",
                table: "order_stage",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "book_order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "book_order",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenreId",
                table: "book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_user_CityId",
                table: "user",
                column: "CityId");

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
                name: "IX_book_order_BookId",
                table: "book_order",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_book_order_OrderId",
                table: "book_order",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_book_AuthorId",
                table: "book",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_book_GenreId",
                table: "book",
                column: "GenreId");

            migrationBuilder.AddForeignKey(
                name: "FK_book_author_AuthorId",
                table: "book",
                column: "AuthorId",
                principalTable: "author",
                principalColumn: "id_author",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_genre_GenreId",
                table: "book",
                column: "GenreId",
                principalTable: "genre",
                principalColumn: "id_genre",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_order_book_BookId",
                table: "book_order",
                column: "BookId",
                principalTable: "book",
                principalColumn: "id_book",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_book_order_order_OrderId",
                table: "book_order",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "id_order",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_stage_order_OrderId",
                table: "order_stage",
                column: "OrderId",
                principalTable: "order",
                principalColumn: "id_order",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_order_stage_order_stage_OrderStageId",
                table: "order_stage",
                column: "OrderStageId",
                principalTable: "order_stage",
                principalColumn: "id_order_stage");

            migrationBuilder.AddForeignKey(
                name: "FK_order_stage_stage_StageId",
                table: "order_stage",
                column: "StageId",
                principalTable: "stage",
                principalColumn: "id_stage",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_user_city_CityId",
                table: "user",
                column: "CityId",
                principalTable: "city",
                principalColumn: "id_city",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
