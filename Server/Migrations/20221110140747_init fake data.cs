using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class initfakedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name", "Url" },
                values: new object[,]
                {
                    { 1, "program", "program" },
                    { 2, "lavender", "lavender" },
                    { 3, "Savings Account", "savings account" },
                    { 4, "cutting-edge", "cutting-edge" },
                    { 5, "TCP", "tcp" },
                    { 6, "time-frame", "time-frame" },
                    { 7, "Corporate", "corporate" },
                    { 8, "Ghana", "ghana" },
                    { 9, "South Carolina", "south carolina" },
                    { 10, "Enhanced", "enhanced" },
                    { 11, "Spurs", "spurs" },
                    { 12, "THX", "thx" },
                    { 13, "Landing", "landing" },
                    { 14, "protocol", "protocol" },
                    { 15, "Response", "response" },
                    { 16, "Rubber", "rubber" },
                    { 17, "salmon", "salmon" },
                    { 18, "generate", "generate" },
                    { 19, "strategic", "strategic" },
                    { 20, "relationships", "relationships" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 12, "red Auto Loan Account navigating", "https://picsum.photos/640/480/?image=1069", 0.4591908585402250m, "models" },
                    { 2, 11, "Steel Alaska invoice", "https://picsum.photos/640/480/?image=539", 0.8782998746253810m, "Direct" },
                    { 3, 3, "magenta New Mexico Drive", "https://picsum.photos/640/480/?image=254", 0.5919881096541780m, "enterprise" },
                    { 4, 12, "synthesize 4th generation", "https://picsum.photos/640/480/?image=408", 0.8289136459954160m, "Spur" },
                    { 5, 3, "Turkish Lira Soft Burkina Faso", "https://picsum.photos/640/480/?image=301", 0.4042950562715520m, "Guinea" },
                    { 6, 19, "Facilitator", "https://picsum.photos/640/480/?image=46", 0.1333902662784290m, "East Caribbean Dollar" },
                    { 7, 1, "Future Auto Loan Account", "https://picsum.photos/640/480/?image=954", 0.2902385712511810m, "Cambridgeshire" },
                    { 8, 19, "AI Chad Handcrafted", "https://picsum.photos/640/480/?image=1072", 0.1525986530209030m, "Dynamic" },
                    { 9, 7, "enhance", "https://picsum.photos/640/480/?image=493", 0.8849403244758140m, "payment" },
                    { 10, 7, "generate Cotton Configuration", "https://picsum.photos/640/480/?image=219", 0.7649123579793960m, "Computers, Tools & Beauty" },
                    { 11, 17, "payment", "https://picsum.photos/640/480/?image=390", 0.02537261229502430m, "Malagasy Ariary" },
                    { 12, 16, "CSS Personal Loan Account exploit", "https://picsum.photos/640/480/?image=207", 0.2386488541910810m, "Unbranded Soft Towels" },
                    { 13, 3, "generating California", "https://picsum.photos/640/480/?image=724", 0.6849361969050630m, "e-commerce" },
                    { 14, 17, "parse Rwanda firmware", "https://picsum.photos/640/480/?image=821", 0.7099702144065030m, "Vision-oriented" },
                    { 15, 1, "fuchsia deposit", "https://picsum.photos/640/480/?image=278", 0.9360734384961360m, "bandwidth" },
                    { 16, 20, "transparent Wall", "https://picsum.photos/640/480/?image=846", 0.6339809942639940m, "Utah" },
                    { 17, 20, "connect Well", "https://picsum.photos/640/480/?image=477", 0.3152268917113990m, "Handmade Cotton Pants" },
                    { 18, 1, "HTTP Islands", "https://picsum.photos/640/480/?image=3", 0.8845169364849360m, "Libyan Dinar" },
                    { 19, 8, "IB Books Israel", "https://picsum.photos/640/480/?image=590", 0.2966574477050680m, "compress" },
                    { 20, 11, "Money Market Account redundant website", "https://picsum.photos/640/480/?image=223", 0.5732423393145120m, "enhance" },
                    { 21, 6, "Junctions North Carolina client-server", "https://picsum.photos/640/480/?image=634", 0.3384615429942750m, "deposit" },
                    { 22, 10, "Drive gold", "https://picsum.photos/640/480/?image=719", 0.2464911109572780m, "B2B" },
                    { 23, 19, "South Georgia and the South Sandwich Islands Kina", "https://picsum.photos/640/480/?image=528", 0.6304824590762030m, "budgetary management" },
                    { 24, 6, "wireless Concrete Metrics", "https://picsum.photos/640/480/?image=1057", 0.5825068766790850m, "Metrics" },
                    { 25, 3, "Metal back up", "https://picsum.photos/640/480/?image=533", 0.6705873037909120m, "disintermediate" },
                    { 26, 7, "Producer Drives Gold", "https://picsum.photos/640/480/?image=662", 0.1589859845573280m, "schemas" },
                    { 27, 20, "synergistic Belgium", "https://picsum.photos/640/480/?image=203", 0.6500834703009970m, "Buckinghamshire" },
                    { 28, 13, "Dominican Republic withdrawal channels", "https://picsum.photos/640/480/?image=903", 0.1486947705271360m, "Refined" },
                    { 29, 8, "Point programming", "https://picsum.photos/640/480/?image=395", 0.03997715579240450m, "invoice" },
                    { 30, 19, "payment Operations Distributed", "https://picsum.photos/640/480/?image=120", 0.4202340868626720m, "navigate" },
                    { 31, 19, "models", "https://picsum.photos/640/480/?image=1003", 0.6670530195975460m, "copying" },
                    { 32, 19, "Digitized", "https://picsum.photos/640/480/?image=1076", 0.9077327213158320m, "backing up" },
                    { 33, 12, "Direct", "https://picsum.photos/640/480/?image=466", 0.6360598807140320m, "Books, Kids & Kids" },
                    { 34, 14, "quantify payment", "https://picsum.photos/640/480/?image=9", 0.4237339156949170m, "Unbranded Fresh Chair" },
                    { 35, 18, "deliver Licensed Steel Ball Park", "https://picsum.photos/640/480/?image=879", 0.8676752836915070m, "revolutionary" },
                    { 36, 18, "Product experiences", "https://picsum.photos/640/480/?image=888", 0.5663098765891510m, "Usability" },
                    { 37, 9, "Indian Rupee magenta", "https://picsum.photos/640/480/?image=151", 0.6643886943180480m, "withdrawal" },
                    { 38, 17, "Prairie sensor action-items", "https://picsum.photos/640/480/?image=395", 0.7787062448121420m, "Generic Soft Bacon" },
                    { 39, 5, "Shoal Cambridgeshire", "https://picsum.photos/640/480/?image=69", 0.3841720728303790m, "asynchronous" },
                    { 40, 3, "Metal", "https://picsum.photos/640/480/?image=109", 0.7061102481879710m, "Steel" },
                    { 41, 10, "red", "https://picsum.photos/640/480/?image=976", 0.3990801438484810m, "withdrawal" },
                    { 42, 9, "neural Tasty Rubber Towels PNG", "https://picsum.photos/640/480/?image=1030", 0.7401998550192690m, "cross-platform" },
                    { 43, 5, "Awesome Steel Tuna Global", "https://picsum.photos/640/480/?image=285", 0.5133939336126170m, "responsive" },
                    { 44, 19, "Digitized", "https://picsum.photos/640/480/?image=25", 0.3977843006304820m, "Harbor" },
                    { 45, 8, "overriding Optimization Engineer", "https://picsum.photos/640/480/?image=497", 0.4904414226121620m, "indigo" },
                    { 46, 15, "strategy Rustic Wooden Soap transmitting", "https://picsum.photos/640/480/?image=798", 0.979224795507190m, "Generic Metal Fish" },
                    { 47, 5, "Awesome Cotton Chicken Cook Islands", "https://picsum.photos/640/480/?image=805", 0.9235797972878820m, "Specialist" },
                    { 48, 17, "Small Concrete Bike Buckinghamshire", "https://picsum.photos/640/480/?image=319", 0.2370368841653140m, "collaborative" },
                    { 49, 19, "Versatile convergence", "https://picsum.photos/640/480/?image=805", 0.2523714213667230m, "harness" },
                    { 50, 1, "Movies & Shoes", "https://picsum.photos/640/480/?image=164", 0.4732622577219790m, "West Virginia" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
