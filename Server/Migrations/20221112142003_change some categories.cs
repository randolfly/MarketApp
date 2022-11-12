using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class changesomecategories : Migration
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
                    { 1, "24/365", "24/365" },
                    { 2, "Incredible Rubber Computer", "incredible rubber computer" },
                    { 3, "SDD", "sdd" },
                    { 4, "program", "program" },
                    { 5, "embrace", "embrace" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, 2, "interactive applications Auto Loan Account", "https://picsum.photos/640/480/?image=875", 0.9665254004202140m, "Global" },
                    { 2, 1, "Programmable", "https://picsum.photos/640/480/?image=166", 0.5998395713801130m, "Cambridgeshire" },
                    { 3, 2, "digital leverage", "https://picsum.photos/640/480/?image=608", 0.2066520775043770m, "Cotton" },
                    { 4, 3, "Track pink Soft", "https://picsum.photos/640/480/?image=1020", 0.1704302667770820m, "Quality" },
                    { 5, 3, "reboot", "https://picsum.photos/640/480/?image=995", 0.9323436946798290m, "Credit Card Account" },
                    { 6, 5, "SAS", "https://picsum.photos/640/480/?image=385", 0.7618871372632180m, "alarm" },
                    { 7, 3, "Ethiopian Birr", "https://picsum.photos/640/480/?image=656", 0.2042694985421450m, "Licensed" },
                    { 8, 1, "invoice Coordinator", "https://picsum.photos/640/480/?image=439", 0.5350905616749590m, "robust" },
                    { 9, 4, "uniform scale Turnpike", "https://picsum.photos/640/480/?image=773", 0.07311279992428580m, "Home, Baby & Toys" },
                    { 10, 2, "Money Market Account Row", "https://picsum.photos/640/480/?image=1034", 0.6315360567423040m, "Open-source" },
                    { 11, 4, "Infrastructure Steel Chief", "https://picsum.photos/640/480/?image=28", 0.7054842136107530m, "invoice" },
                    { 12, 2, "Ameliorated orchid", "https://picsum.photos/640/480/?image=972", 0.8662137102858880m, "Direct" },
                    { 13, 1, "Baby Electronics, Grocery & Tools", "https://picsum.photos/640/480/?image=968", 0.4974352042437160m, "Beauty & Movies" },
                    { 14, 5, "Cambridgeshire", "https://picsum.photos/640/480/?image=747", 0.4045462349201020m, "black" },
                    { 15, 4, "Cove scalable Bedfordshire", "https://picsum.photos/640/480/?image=603", 0.4822387860077920m, "Horizontal" },
                    { 16, 2, "Cambridgeshire", "https://picsum.photos/640/480/?image=276", 0.7527020307704210m, "system" },
                    { 17, 2, "Generic Tools Licensed Granite Bacon", "https://picsum.photos/640/480/?image=616", 0.8677455427636220m, "orchestration" },
                    { 18, 5, "Cambridgeshire Representative", "https://picsum.photos/640/480/?image=744", 0.7361021844648840m, "input" },
                    { 19, 4, "payment", "https://picsum.photos/640/480/?image=402", 0.719448499105090m, "Reverse-engineered" },
                    { 20, 3, "Configuration Kyat", "https://picsum.photos/640/480/?image=1044", 0.7271752410077870m, "Handmade" },
                    { 21, 4, "Personal Loan Account Designer JBOD", "https://picsum.photos/640/480/?image=641", 0.6313473659715280m, "Health" },
                    { 22, 1, "Guinea-Bissau Knoll", "https://picsum.photos/640/480/?image=769", 0.1678680511727240m, "Extended" },
                    { 23, 2, "syndicate", "https://picsum.photos/640/480/?image=1036", 0.1181144171265930m, "panel" },
                    { 24, 4, "radical", "https://picsum.photos/640/480/?image=696", 0.4776208058467080m, "Florida" },
                    { 25, 3, "Intelligent Steel Shirt", "https://picsum.photos/640/480/?image=994", 0.7658658587495650m, "back-end" },
                    { 26, 4, "Gardens New Jersey Cote d'Ivoire", "https://picsum.photos/640/480/?image=509", 0.9776686403190110m, "Fresh" },
                    { 27, 1, "Practical Granite Soap Electronics white", "https://picsum.photos/640/480/?image=661", 0.2121430318518970m, "quantify" },
                    { 28, 2, "Handmade Managed Reactive", "https://picsum.photos/640/480/?image=754", 0.8004457484381440m, "Accountability" },
                    { 29, 4, "reboot", "https://picsum.photos/640/480/?image=365", 0.1709149040793780m, "convergence" },
                    { 30, 3, "silver redundant", "https://picsum.photos/640/480/?image=874", 0.9497379751568720m, "static" },
                    { 31, 4, "Ergonomic", "https://picsum.photos/640/480/?image=346", 0.8176674406362370m, "open-source" },
                    { 32, 1, "bluetooth", "https://picsum.photos/640/480/?image=691", 0.2851887922145460m, "seamless" },
                    { 33, 5, "payment United Kingdom", "https://picsum.photos/640/480/?image=623", 0.4569169222562810m, "Integrated" },
                    { 34, 3, "Rwanda Franc", "https://picsum.photos/640/480/?image=261", 0.3666256451494950m, "redundant" },
                    { 35, 2, "bluetooth", "https://picsum.photos/640/480/?image=1079", 0.8433783604247340m, "Directives" },
                    { 36, 4, "Dale Wisconsin", "https://picsum.photos/640/480/?image=329", 0.9202678820244820m, "Cross-platform" },
                    { 37, 1, "Mongolia Vanuatu Credit Card Account", "https://picsum.photos/640/480/?image=1056", 0.5293601740619510m, "tan" },
                    { 38, 5, "invoice mesh", "https://picsum.photos/640/480/?image=805", 0.8699871503074160m, "generate" },
                    { 39, 1, "e-business Plains", "https://picsum.photos/640/480/?image=377", 0.6193895698608840m, "artificial intelligence" },
                    { 40, 4, "Total THX", "https://picsum.photos/640/480/?image=1016", 0.3314499933059020m, "Pa'anga" },
                    { 41, 4, "Rial Omani", "https://picsum.photos/640/480/?image=1062", 0.3234830544320320m, "turquoise" },
                    { 42, 3, "port", "https://picsum.photos/640/480/?image=236", 0.4905751627039460m, "Licensed" },
                    { 43, 5, "plug-and-play open architecture Representative", "https://picsum.photos/640/480/?image=535", 0.9072301561730030m, "Mongolia" },
                    { 44, 4, "help-desk", "https://picsum.photos/640/480/?image=4", 0.05873491258814060m, "Field" },
                    { 45, 3, "deposit South Dakota Park", "https://picsum.photos/640/480/?image=869", 0.001520963043350030m, "yellow" },
                    { 46, 1, "Outdoors & Toys", "https://picsum.photos/640/480/?image=205", 0.2463675272298410m, "Manat" },
                    { 47, 5, "firewall", "https://picsum.photos/640/480/?image=579", 0.1012104229970370m, "Rwanda Franc" },
                    { 48, 1, "Colorado", "https://picsum.photos/640/480/?image=305", 0.00009524058360321780m, "Paradigm" },
                    { 49, 1, "Hills", "https://picsum.photos/640/480/?image=731", 0.8039256089897430m, "world-class" },
                    { 50, 4, "Berkshire", "https://picsum.photos/640/480/?image=838", 0.8218550105689060m, "Intelligent" },
                    { 51, 4, "orchid", "https://picsum.photos/640/480/?image=432", 0.5758622227092470m, "Avon" },
                    { 52, 1, "whiteboard", "https://picsum.photos/640/480/?image=1078", 0.08073535715109340m, "backing up" },
                    { 53, 2, "USB", "https://picsum.photos/640/480/?image=120", 0.5427597480253470m, "Jordan" },
                    { 54, 5, "Garden, Computers & Tools", "https://picsum.photos/640/480/?image=869", 0.1433941261244020m, "North Carolina" },
                    { 55, 4, "Practical Frozen Chicken syndicate", "https://picsum.photos/640/480/?image=803", 0.5765299791156970m, "National" },
                    { 56, 4, "neural Mills bandwidth", "https://picsum.photos/640/480/?image=798", 0.2812311058504940m, "Metal" },
                    { 57, 3, "Buckinghamshire", "https://picsum.photos/640/480/?image=729", 0.1293810691663150m, "Pre-emptive" },
                    { 58, 5, "Pike", "https://picsum.photos/640/480/?image=1072", 0.4605029052410740m, "vertical" },
                    { 59, 2, "Generic Quality Granite", "https://picsum.photos/640/480/?image=553", 0.027437187967260m, "Kids, Kids & Baby" },
                    { 60, 1, "Sleek Guyana Dollar Cambridgeshire", "https://picsum.photos/640/480/?image=698", 0.6515326675635890m, "Handcrafted Concrete Pants" },
                    { 61, 1, "Global", "https://picsum.photos/640/480/?image=7", 0.9485923002468330m, "Computers, Automotive & Shoes" },
                    { 62, 5, "Web", "https://picsum.photos/640/480/?image=680", 0.2599816890302560m, "payment" },
                    { 63, 2, "blue Product Personal Loan Account", "https://picsum.photos/640/480/?image=1019", 0.8163048099126160m, "Generic Soft Hat" },
                    { 64, 3, "payment", "https://picsum.photos/640/480/?image=976", 0.8737949362133540m, "User-centric" },
                    { 65, 2, "Wisconsin iterate", "https://picsum.photos/640/480/?image=736", 0.04688264599416090m, "Licensed Plastic Cheese" },
                    { 66, 1, "neural-net Point gold", "https://picsum.photos/640/480/?image=810", 0.379897883069590m, "Engineer" },
                    { 67, 1, "orange", "https://picsum.photos/640/480/?image=763", 0.5776461745417620m, "Turks and Caicos Islands" },
                    { 68, 2, "Beauty, Electronics & Industrial", "https://picsum.photos/640/480/?image=828", 0.9009229768686650m, "navigate" },
                    { 69, 2, "Frozen", "https://picsum.photos/640/480/?image=697", 0.8018986595473090m, "experiences" },
                    { 70, 4, "Industrial, Games & Shoes", "https://picsum.photos/640/480/?image=42", 0.6781155987445040m, "white" },
                    { 71, 1, "Togo Directives HDD", "https://picsum.photos/640/480/?image=895", 0.03514794371906370m, "Handmade Soft Gloves" },
                    { 72, 4, "Personal Loan Account demand-driven Program", "https://picsum.photos/640/480/?image=244", 0.5093357091095230m, "help-desk" },
                    { 73, 4, "Divide", "https://picsum.photos/640/480/?image=874", 0.5283742191852630m, "SMS" },
                    { 74, 4, "Liaison", "https://picsum.photos/640/480/?image=60", 0.4228703689943570m, "Switchable" },
                    { 75, 5, "systemic", "https://picsum.photos/640/480/?image=767", 0.3189810595778920m, "Music, Music & Garden" },
                    { 76, 3, "Wisconsin Rustic Plastic Car interface", "https://picsum.photos/640/480/?image=905", 0.3722831521505170m, "quantify" },
                    { 77, 3, "Denmark", "https://picsum.photos/640/480/?image=266", 0.6719283296039910m, "monitor" },
                    { 78, 3, "Integration Clothing", "https://picsum.photos/640/480/?image=974", 0.5801060170722280m, "eyeballs" },
                    { 79, 5, "Guadeloupe", "https://picsum.photos/640/480/?image=876", 0.4159348910414540m, "even-keeled" },
                    { 80, 3, "Borders Practical", "https://picsum.photos/640/480/?image=1032", 0.02725615332161360m, "Auto Loan Account" },
                    { 81, 2, "multimedia bus payment", "https://picsum.photos/640/480/?image=629", 0.6889164400257790m, "Dynamic" },
                    { 82, 1, "black", "https://picsum.photos/640/480/?image=393", 0.9294101013455070m, "Congolese Franc" },
                    { 83, 2, "Orchestrator parsing", "https://picsum.photos/640/480/?image=67", 0.4312914363752510m, "Road" },
                    { 84, 3, "silver Iowa Operations", "https://picsum.photos/640/480/?image=605", 0.5703609390252840m, "rich" },
                    { 85, 4, "bus", "https://picsum.photos/640/480/?image=931", 0.6303524657335280m, "wireless" },
                    { 86, 1, "Soft e-business", "https://picsum.photos/640/480/?image=730", 0.1788298839567580m, "Checking Account" },
                    { 87, 3, "Grocery & Movies", "https://picsum.photos/640/480/?image=320", 0.5815989742301970m, "Planner" },
                    { 88, 2, "Personal Loan Account connect interfaces", "https://picsum.photos/640/480/?image=105", 0.6738173458761850m, "Frozen" },
                    { 89, 2, "grey compressing Practical", "https://picsum.photos/640/480/?image=565", 0.7381102516469040m, "New Mexico" },
                    { 90, 2, "Clothing Utah haptic", "https://picsum.photos/640/480/?image=696", 0.9308805687643590m, "B2B" },
                    { 91, 1, "neural Concrete Robust", "https://picsum.photos/640/480/?image=59", 0.8801856640808740m, "Arizona" },
                    { 92, 1, "Generic Soft Shirt FTP", "https://picsum.photos/640/480/?image=814", 0.8874386208178440m, "experiences" },
                    { 93, 1, "Ergonomic", "https://picsum.photos/640/480/?image=222", 0.6052081155467880m, "COM" },
                    { 94, 4, "lime", "https://picsum.photos/640/480/?image=166", 0.2171810201230360m, "contingency" },
                    { 95, 5, "bus", "https://picsum.photos/640/480/?image=662", 0.8773015770917330m, "reinvent" },
                    { 96, 2, "program", "https://picsum.photos/640/480/?image=42", 0.2812472524958230m, "global" },
                    { 97, 2, "Gibraltar Pound", "https://picsum.photos/640/480/?image=683", 0.54349424473780m, "Malta" },
                    { 98, 5, "vertical", "https://picsum.photos/640/480/?image=928", 0.4233552970760010m, "Devolved" },
                    { 99, 3, "Cordoba Oro Forge European Unit of Account 9(E.U.A.-9)", "https://picsum.photos/640/480/?image=918", 0.1704332474434940m, "input" },
                    { 100, 3, "El Salvador Colon", "https://picsum.photos/640/480/?image=464", 0.8490165293326960m, "capacitor" }
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
