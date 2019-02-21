using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Vavatech.EFCore.DbServices.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 50, nullable: true),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Color = table.Column<string>(nullable: true),
                    Weight = table.Column<float>(nullable: true),
                    Duration = table.Column<TimeSpan>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    CustomerId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ItemId = table.Column<int>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "FirstName", "IsDeleted", "LastName" },
                values: new object[,]
                {
                    { 1, "Betsy", true, "Batz" },
                    { 73, "Sharon", false, "Ullrich" },
                    { 72, "Shannon", true, "Blick" },
                    { 71, "Derrick", true, "Moen" },
                    { 70, "Alex", true, "Gerhold" },
                    { 69, "May", true, "Hoppe" },
                    { 68, "Alton", true, "Smitham" },
                    { 67, "Mathew", false, "Kunze" },
                    { 66, "Kelley", false, "Bogisich" },
                    { 65, "Edgar", true, "Buckridge" },
                    { 64, "Lewis", false, "Marvin" },
                    { 63, "Bill", true, "Jacobi" },
                    { 62, "Marcella", false, "Smitham" },
                    { 61, "Kathleen", true, "Kilback" },
                    { 60, "Mike", true, "Haley" },
                    { 59, "Elsa", true, "Heaney" },
                    { 58, "Ruth", false, "Brakus" },
                    { 57, "Daryl", true, "Mohr" },
                    { 56, "Dixie", true, "Spencer" },
                    { 55, "George", true, "Klocko" },
                    { 54, "Pamela", false, "Langosh" },
                    { 53, "Daryl", true, "Buckridge" },
                    { 74, "Dwayne", true, "Rippin" },
                    { 52, "Shane", true, "Greenfelder" },
                    { 75, "Lila", true, "Daniel" },
                    { 77, "Alfredo", false, "Jaskolski" },
                    { 98, "Marie", false, "Lindgren" },
                    { 97, "Sonya", true, "Abshire" },
                    { 96, "Leland", true, "Schuppe" },
                    { 95, "Jacquelyn", true, "Kiehn" },
                    { 94, "Kerry", true, "Littel" },
                    { 93, "Elena", true, "Trantow" },
                    { 92, "Preston", true, "Murazik" },
                    { 91, "Lindsay", true, "Lemke" },
                    { 90, "Fannie", true, "Stiedemann" },
                    { 89, "Jack", true, "Donnelly" },
                    { 88, "Alma", true, "Metz" },
                    { 87, "Rudolph", true, "Kuvalis" },
                    { 86, "Sandra", true, "Von" },
                    { 85, "Devin", true, "Schmidt" },
                    { 84, "Guillermo", false, "Ruecker" },
                    { 83, "Kristi", true, "White" },
                    { 82, "Naomi", false, "Kuhn" },
                    { 81, "Lora", true, "Corwin" },
                    { 80, "Ross", true, "Watsica" },
                    { 79, "Sonja", true, "Paucek" },
                    { 78, "Rene", true, "Heidenreich" },
                    { 76, "Katie", true, "Auer" },
                    { 51, "Corey", true, "Hartmann" },
                    { 50, "Beatrice", true, "Zulauf" },
                    { 49, "Sam", false, "Braun" },
                    { 22, "Erma", true, "Moen" },
                    { 21, "Agnes", true, "Gottlieb" },
                    { 20, "Penny", true, "Von" },
                    { 19, "Stephanie", false, "Blanda" },
                    { 18, "Sonja", false, "Huel" },
                    { 17, "Bryant", true, "Nienow" },
                    { 16, "Jamie", true, "Zemlak" },
                    { 15, "Victor", true, "Reichel" },
                    { 14, "Alton", true, "Fahey" },
                    { 13, "Ruben", true, "Herzog" },
                    { 12, "Larry", false, "Purdy" },
                    { 11, "Bethany", false, "Goyette" },
                    { 10, "Moses", true, "Jast" },
                    { 9, "Nathan", false, "Wisozk" },
                    { 8, "Jana", true, "Mertz" },
                    { 7, "Erick", true, "Prosacco" },
                    { 6, "Donna", true, "Kuvalis" },
                    { 5, "Delores", true, "Kertzmann" },
                    { 4, "Sally", false, "Bode" },
                    { 3, "Nathaniel", true, "Parker" },
                    { 2, "Dianne", true, "Kihn" },
                    { 23, "Dwight", true, "Donnelly" },
                    { 24, "Bryan", false, "Jaskolski" },
                    { 25, "Lowell", true, "Bernhard" },
                    { 26, "Neal", false, "Bednar" },
                    { 48, "Hector", true, "Johnston" },
                    { 47, "Marianne", true, "Considine" },
                    { 46, "Tommy", false, "Bednar" },
                    { 45, "Emmett", true, "Thiel" },
                    { 44, "Benjamin", false, "Cartwright" },
                    { 43, "Ana", true, "Leffler" },
                    { 42, "Doreen", true, "Bogisich" },
                    { 41, "William", true, "Kutch" },
                    { 40, "Paul", true, "Hansen" },
                    { 39, "Rolando", true, "Steuber" },
                    { 99, "Dolores", true, "Volkman" },
                    { 38, "Jackie", true, "Kuhic" },
                    { 36, "Shaun", true, "Purdy" },
                    { 35, "Luther", true, "Satterfield" },
                    { 34, "Eric", true, "Schultz" },
                    { 33, "Lena", true, "Mann" },
                    { 32, "Penny", true, "Lakin" },
                    { 31, "Rex", true, "Haag" },
                    { 30, "Jamie", true, "Simonis" },
                    { 29, "Eugene", true, "O'Connell" },
                    { 28, "Dustin", true, "Ward" },
                    { 27, "Jason", true, "Deckow" },
                    { 37, "Brenda", true, "Russel" },
                    { 100, "Patsy", true, "Hettinger" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ItemId",
                table: "OrderDetail",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
