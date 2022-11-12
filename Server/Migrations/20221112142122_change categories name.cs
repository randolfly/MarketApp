using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class changecategoriesname : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Url" },
                values: new object[] { "program", "program" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Checking Account", "checking account" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Url" },
                values: new object[] { "microchip", "microchip" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Saint Kitts and Nevis", "saint kitts and nevis" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Url" },
                values: new object[] { "HTTP", "http" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Bedfordshire", "https://picsum.photos/640/480/?image=675", 0.4829885927453160m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "application Ergonomic Plastic Tuna", "https://picsum.photos/640/480/?image=426", 0.6558154818871850m, "circuit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "infomediaries Awesome input", "https://picsum.photos/640/480/?image=186", 0.5201297609049620m, "Garden & Games" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Investment Account", "https://picsum.photos/640/480/?image=978", 0.9647470176919850m, "Versatile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Cotton", "https://picsum.photos/640/480/?image=531", 0.2803827463493270m, "Customer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "tan International even-keeled", "https://picsum.photos/640/480/?image=814", 0.195978464346080m, "program" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Cliff Ferry", "https://picsum.photos/640/480/?image=196", 0.7634088073218140m, "Producer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Spurs Spurs", "https://picsum.photos/640/480/?image=379", 0.322131887819160m, "AI" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "blockchains Home Loan Account", "https://picsum.photos/640/480/?image=6", 0.8199834910701920m, "Peru" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Handmade Granite Bacon next generation Marshall Islands", "https://picsum.photos/640/480/?image=989", 0.2869826259902140m, "initiatives" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Garden, Jewelery & Tools", "https://picsum.photos/640/480/?image=688", 0.339046468712160m, "Compatible" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Handmade Steel Shoes calculate", "https://picsum.photos/640/480/?image=117", 0.7591938998059360m, "Pakistan Rupee" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Mountains Unbranded Concrete Tuna Handcrafted Wooden Ball", "https://picsum.photos/640/480/?image=298", 0.3174672269839060m, "logistical" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Crescent", "https://picsum.photos/640/480/?image=588", 0.1170310041783440m, "Books" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Managed Movies, Computers & Electronics", "https://picsum.photos/640/480/?image=349", 0.6655335224643040m, "indexing" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "eyeballs Estates Unbranded", "https://picsum.photos/640/480/?image=1029", 0.7272851910097570m, "methodology" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Avon Fresh", "https://picsum.photos/640/480/?image=997", 0.7115545956047690m, "brand" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "copy Concrete", "https://picsum.photos/640/480/?image=935", 0.9126882561023050m, "Refined" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "auxiliary Music, Kids & Toys deposit", "https://picsum.photos/640/480/?image=679", 0.9141229172135130m, "index" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Ergonomic Rubber Salad Savings Account", "https://picsum.photos/640/480/?image=117", 0.4173873858411120m, "gold" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "encoding Reverse-engineered Plastic", "https://picsum.photos/640/480/?image=1061", 0.8804472200445860m, "Soft" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "database", "https://picsum.photos/640/480/?image=318", 0.9100725006856730m, "Incredible Fresh Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "homogeneous synergies", "https://picsum.photos/640/480/?image=700", 0.6187047818267480m, "niches" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Functionality", "https://picsum.photos/640/480/?image=810", 0.2514299439894180m, "virtual" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Managed sensor", "https://picsum.photos/640/480/?image=82", 0.4419215789295230m, "magenta" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Rustic software", "https://picsum.photos/640/480/?image=221", 0.09251441843221120m, "Lodge" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "cyan bypass Metal", "https://picsum.photos/640/480/?image=1064", 0.8036825130495660m, "Lodge" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "solid state", "https://picsum.photos/640/480/?image=684", 0.7081642075805170m, "National" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "deposit Hong Kong Grocery, Baby & Books", "https://picsum.photos/640/480/?image=484", 0.9914446874375010m, "virtual" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Tactics", "https://picsum.photos/640/480/?image=215", 0.3728286491701440m, "Generic Concrete Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Kyat Circles", "https://picsum.photos/640/480/?image=631", 0.3618452475762680m, "multi-byte" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Gorgeous paradigms", "https://picsum.photos/640/480/?image=929", 0.1011301919854390m, "mobile" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "white Expanded", "https://picsum.photos/640/480/?image=100", 0.7390609940653020m, "Lithuanian Litas" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Kids, Music & Home International overriding", "https://picsum.photos/640/480/?image=3", 0.01314546883941370m, "Cotton" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Awesome Soft Chicken", "https://picsum.photos/640/480/?image=882", 0.3312795674296740m, "Assurance" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Ergonomic Wooden Table", "https://picsum.photos/640/480/?image=735", 0.825127071908080m, "Liaison" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Incredible Cotton Chips", "https://picsum.photos/640/480/?image=843", 0.5635261753976480m, "B2B" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Singapore Dollar Kroon systematic", "https://picsum.photos/640/480/?image=139", 0.4762846836844470m, "override" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "mesh", "https://picsum.photos/640/480/?image=1061", 0.9756300067693860m, "Paradigm" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "AGP Customizable Granite", "https://picsum.photos/640/480/?image=999", 0.2477102888683350m, "Kiribati" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Louisiana orchestration Borders", "https://picsum.photos/640/480/?image=197", 0.6892554123508280m, "Views" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Fork", "https://picsum.photos/640/480/?image=500", 0.2390107495097470m, "product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Awesome red Avon", "https://picsum.photos/640/480/?image=565", 0.5746837455668360m, "Rustic Fresh Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "deposit", "https://picsum.photos/640/480/?image=948", 0.5991717301834320m, "Investor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "evolve deposit", "https://picsum.photos/640/480/?image=603", 0.9765695219184430m, "maroon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Indonesia Handcrafted regional", "https://picsum.photos/640/480/?image=430", 0.376528255071440m, "Fresh" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Shoes & Outdoors", "https://picsum.photos/640/480/?image=622", 0.4604583479305890m, "cultivate" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "tangible", "https://picsum.photos/640/480/?image=922", 0.8900851079950730m, "Planner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "programming", "https://picsum.photos/640/480/?image=583", 0.5623507814393880m, "Small" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Liaison Fiji Dollar revolutionary", "https://picsum.photos/640/480/?image=1076", 0.5495418298158930m, "unleash" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "extranet cross-platform Rhode Island", "https://picsum.photos/640/480/?image=880", 0.4182642884558410m, "backing up" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "digital Montserrat enable", "https://picsum.photos/640/480/?image=447", 0.4680821949437630m, "Landing" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "AI Azerbaijanian Manat Bosnia and Herzegovina", "https://picsum.photos/640/480/?image=129", 0.925463595146850m, "Rustic Metal Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "invoice array Representative", "https://picsum.photos/640/480/?image=652", 0.7017070336703280m, "Product" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "protocol", "https://picsum.photos/640/480/?image=1082", 0.5451455191440640m, "Savings Account" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Cambridgeshire SDD", "https://picsum.photos/640/480/?image=441", 0.2558748558292560m, "Fantastic Concrete Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Rustic Metal Hat visionary", "https://picsum.photos/640/480/?image=655", 0.1277072307103420m, "Tunnel" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Cuban Peso Convertible Circles Identity", "https://picsum.photos/640/480/?image=521", 0.5751462314283650m, "Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Metal Plastic", "https://picsum.photos/640/480/?image=162", 0.7718532451886790m, "silver" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "multimedia", "https://picsum.photos/640/480/?image=644", 0.643465805923610m, "navigate" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Games", "https://picsum.photos/640/480/?image=257", 0.4156120882319710m, "connect" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "backing up Ergonomic Brand", "https://picsum.photos/640/480/?image=623", 0.8258027670261830m, "Small Rubber Chips" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Wooden calculate Cambridgeshire", "https://picsum.photos/640/480/?image=1066", 0.441756093187650m, "Saint Lucia" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Island Course Music", "https://picsum.photos/640/480/?image=997", 0.9874417660604950m, "Fantastic Fresh Computer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Handmade Concrete Chair tan", "https://picsum.photos/640/480/?image=366", 0.008842645988977880m, "Enterprise-wide" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Music & Toys", "https://picsum.photos/640/480/?image=384", 0.8800185340417210m, "Wisconsin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "product generate Ways", "https://picsum.photos/640/480/?image=529", 0.603228655767070m, "Infrastructure" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Frozen Iceland pixel", "https://picsum.photos/640/480/?image=629", 0.01628802002686510m, "HDD" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "plum", "https://picsum.photos/640/480/?image=831", 0.7945698979794120m, "granular" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Agent Incredible Fresh Ball", "https://picsum.photos/640/480/?image=565", 0.5327092806014030m, "circuit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "quantify", "https://picsum.photos/640/480/?image=1032", 0.565871648481860m, "Tools" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "synergies Metrics e-services", "https://picsum.photos/640/480/?image=403", 0.6698356813825450m, "Awesome" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Tunnel Circles Ridge", "https://picsum.photos/640/480/?image=9", 0.694332414291530m, "Prairie" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Program Practical", "https://picsum.photos/640/480/?image=927", 0.2111547600333710m, "exploit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "24/7", "https://picsum.photos/640/480/?image=812", 0.4232942152026030m, "programming" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price" },
                values: new object[] { 5, "Function-based Buckinghamshire", "https://picsum.photos/640/480/?image=204", 0.2572255221568020m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Granite synthesize global", "https://picsum.photos/640/480/?image=34", 0.2507668640849920m, "Steel" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "mesh", "https://picsum.photos/640/480/?image=853", 0.587196285074570m, "Small Rubber Ball" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "responsive Analyst", "https://picsum.photos/640/480/?image=31", 0.9691385166413620m, "Kids & Beauty" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Turkish Lira Nebraska virtual", "https://picsum.photos/640/480/?image=683", 0.227986193025530m, "Pines" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Fantastic", "https://picsum.photos/640/480/?image=656", 0.03451631061649440m, "Mission" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Multi-lateral feed", "https://picsum.photos/640/480/?image=101", 0.2318473550194470m, "Montana" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Handcrafted Wooden Bacon Hawaii", "https://picsum.photos/640/480/?image=188", 0.1287713475194470m, "reboot" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Intelligent Frozen Chair ROI Organized", "https://picsum.photos/640/480/?image=589", 0.9248401671633190m, "Functionality" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "alliance", "https://picsum.photos/640/480/?image=140", 0.5296746784742870m, "Ukraine" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "transmitting", "https://picsum.photos/640/480/?image=497", 0.565646140202650m, "logistical" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "vertical", "https://picsum.photos/640/480/?image=326", 0.8664743721865590m, "Applications" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Austria Intelligent Rubber Computer", "https://picsum.photos/640/480/?image=228", 0.1439579259455040m, "Usability" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Books, Beauty & Shoes", "https://picsum.photos/640/480/?image=2", 0.16401247152410m, "Kids" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Borders Intelligent Frozen Mouse", "https://picsum.photos/640/480/?image=832", 0.6081436185824670m, "platforms" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "matrix", "https://picsum.photos/640/480/?image=593", 0.2469378750960180m, "Officer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Optimization synthesizing", "https://picsum.photos/640/480/?image=840", 0.4787934879364170m, "functionalities" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Unbranded parsing Granite", "https://picsum.photos/640/480/?image=754", 0.5207686680266520m, "harness" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "calculate", "https://picsum.photos/640/480/?image=232", 0.3693595363643650m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "District Finland", "https://picsum.photos/640/480/?image=439", 0.5861702685441980m, "Vista" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Soft Direct", "https://picsum.photos/640/480/?image=175", 0.09742323451239030m, "Technician" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Slovenia SQL Fresh", "https://picsum.photos/640/480/?image=307", 0.1519951161640360m, "Planner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Rapids", "https://picsum.photos/640/480/?image=307", 0.6163124814953220m, "THX" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "bluetooth", "https://picsum.photos/640/480/?image=171", 0.6022960790987870m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "online", "https://picsum.photos/640/480/?image=655", 0.1949677394066390m, "bi-directional" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Url" },
                values: new object[] { "24/365", "24/365" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Incredible Rubber Computer", "incredible rubber computer" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Url" },
                values: new object[] { "SDD", "sdd" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Url" },
                values: new object[] { "program", "program" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Url" },
                values: new object[] { "embrace", "embrace" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "interactive applications Auto Loan Account", "https://picsum.photos/640/480/?image=875", 0.9665254004202140m, "Global" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Programmable", "https://picsum.photos/640/480/?image=166", 0.5998395713801130m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "digital leverage", "https://picsum.photos/640/480/?image=608", 0.2066520775043770m, "Cotton" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Track pink Soft", "https://picsum.photos/640/480/?image=1020", 0.1704302667770820m, "Quality" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "reboot", "https://picsum.photos/640/480/?image=995", 0.9323436946798290m, "Credit Card Account" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "SAS", "https://picsum.photos/640/480/?image=385", 0.7618871372632180m, "alarm" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Ethiopian Birr", "https://picsum.photos/640/480/?image=656", 0.2042694985421450m, "Licensed" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "invoice Coordinator", "https://picsum.photos/640/480/?image=439", 0.5350905616749590m, "robust" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "uniform scale Turnpike", "https://picsum.photos/640/480/?image=773", 0.07311279992428580m, "Home, Baby & Toys" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Money Market Account Row", "https://picsum.photos/640/480/?image=1034", 0.6315360567423040m, "Open-source" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Infrastructure Steel Chief", "https://picsum.photos/640/480/?image=28", 0.7054842136107530m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Ameliorated orchid", "https://picsum.photos/640/480/?image=972", 0.8662137102858880m, "Direct" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Baby Electronics, Grocery & Tools", "https://picsum.photos/640/480/?image=968", 0.4974352042437160m, "Beauty & Movies" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Cambridgeshire", "https://picsum.photos/640/480/?image=747", 0.4045462349201020m, "black" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Cove scalable Bedfordshire", "https://picsum.photos/640/480/?image=603", 0.4822387860077920m, "Horizontal" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Cambridgeshire", "https://picsum.photos/640/480/?image=276", 0.7527020307704210m, "system" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Generic Tools Licensed Granite Bacon", "https://picsum.photos/640/480/?image=616", 0.8677455427636220m, "orchestration" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Cambridgeshire Representative", "https://picsum.photos/640/480/?image=744", 0.7361021844648840m, "input" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "payment", "https://picsum.photos/640/480/?image=402", 0.719448499105090m, "Reverse-engineered" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Configuration Kyat", "https://picsum.photos/640/480/?image=1044", 0.7271752410077870m, "Handmade" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Personal Loan Account Designer JBOD", "https://picsum.photos/640/480/?image=641", 0.6313473659715280m, "Health" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Guinea-Bissau Knoll", "https://picsum.photos/640/480/?image=769", 0.1678680511727240m, "Extended" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "syndicate", "https://picsum.photos/640/480/?image=1036", 0.1181144171265930m, "panel" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "radical", "https://picsum.photos/640/480/?image=696", 0.4776208058467080m, "Florida" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Intelligent Steel Shirt", "https://picsum.photos/640/480/?image=994", 0.7658658587495650m, "back-end" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Gardens New Jersey Cote d'Ivoire", "https://picsum.photos/640/480/?image=509", 0.9776686403190110m, "Fresh" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Practical Granite Soap Electronics white", "https://picsum.photos/640/480/?image=661", 0.2121430318518970m, "quantify" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Handmade Managed Reactive", "https://picsum.photos/640/480/?image=754", 0.8004457484381440m, "Accountability" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "reboot", "https://picsum.photos/640/480/?image=365", 0.1709149040793780m, "convergence" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "silver redundant", "https://picsum.photos/640/480/?image=874", 0.9497379751568720m, "static" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Ergonomic", "https://picsum.photos/640/480/?image=346", 0.8176674406362370m, "open-source" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "bluetooth", "https://picsum.photos/640/480/?image=691", 0.2851887922145460m, "seamless" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "payment United Kingdom", "https://picsum.photos/640/480/?image=623", 0.4569169222562810m, "Integrated" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Rwanda Franc", "https://picsum.photos/640/480/?image=261", 0.3666256451494950m, "redundant" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "bluetooth", "https://picsum.photos/640/480/?image=1079", 0.8433783604247340m, "Directives" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Dale Wisconsin", "https://picsum.photos/640/480/?image=329", 0.9202678820244820m, "Cross-platform" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Mongolia Vanuatu Credit Card Account", "https://picsum.photos/640/480/?image=1056", 0.5293601740619510m, "tan" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "invoice mesh", "https://picsum.photos/640/480/?image=805", 0.8699871503074160m, "generate" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "e-business Plains", "https://picsum.photos/640/480/?image=377", 0.6193895698608840m, "artificial intelligence" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Total THX", "https://picsum.photos/640/480/?image=1016", 0.3314499933059020m, "Pa'anga" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Rial Omani", "https://picsum.photos/640/480/?image=1062", 0.3234830544320320m, "turquoise" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "port", "https://picsum.photos/640/480/?image=236", 0.4905751627039460m, "Licensed" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "plug-and-play open architecture Representative", "https://picsum.photos/640/480/?image=535", 0.9072301561730030m, "Mongolia" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "help-desk", "https://picsum.photos/640/480/?image=4", 0.05873491258814060m, "Field" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "deposit South Dakota Park", "https://picsum.photos/640/480/?image=869", 0.001520963043350030m, "yellow" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Outdoors & Toys", "https://picsum.photos/640/480/?image=205", 0.2463675272298410m, "Manat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "firewall", "https://picsum.photos/640/480/?image=579", 0.1012104229970370m, "Rwanda Franc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Colorado", "https://picsum.photos/640/480/?image=305", 0.00009524058360321780m, "Paradigm" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Hills", "https://picsum.photos/640/480/?image=731", 0.8039256089897430m, "world-class" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Berkshire", "https://picsum.photos/640/480/?image=838", 0.8218550105689060m, "Intelligent" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "orchid", "https://picsum.photos/640/480/?image=432", 0.5758622227092470m, "Avon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "whiteboard", "https://picsum.photos/640/480/?image=1078", 0.08073535715109340m, "backing up" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "USB", "https://picsum.photos/640/480/?image=120", 0.5427597480253470m, "Jordan" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Garden, Computers & Tools", "https://picsum.photos/640/480/?image=869", 0.1433941261244020m, "North Carolina" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Practical Frozen Chicken syndicate", "https://picsum.photos/640/480/?image=803", 0.5765299791156970m, "National" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "neural Mills bandwidth", "https://picsum.photos/640/480/?image=798", 0.2812311058504940m, "Metal" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Buckinghamshire", "https://picsum.photos/640/480/?image=729", 0.1293810691663150m, "Pre-emptive" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Pike", "https://picsum.photos/640/480/?image=1072", 0.4605029052410740m, "vertical" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Generic Quality Granite", "https://picsum.photos/640/480/?image=553", 0.027437187967260m, "Kids, Kids & Baby" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Sleek Guyana Dollar Cambridgeshire", "https://picsum.photos/640/480/?image=698", 0.6515326675635890m, "Handcrafted Concrete Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Global", "https://picsum.photos/640/480/?image=7", 0.9485923002468330m, "Computers, Automotive & Shoes" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Web", "https://picsum.photos/640/480/?image=680", 0.2599816890302560m, "payment" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "blue Product Personal Loan Account", "https://picsum.photos/640/480/?image=1019", 0.8163048099126160m, "Generic Soft Hat" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "payment", "https://picsum.photos/640/480/?image=976", 0.8737949362133540m, "User-centric" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Wisconsin iterate", "https://picsum.photos/640/480/?image=736", 0.04688264599416090m, "Licensed Plastic Cheese" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "neural-net Point gold", "https://picsum.photos/640/480/?image=810", 0.379897883069590m, "Engineer" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "orange", "https://picsum.photos/640/480/?image=763", 0.5776461745417620m, "Turks and Caicos Islands" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Beauty, Electronics & Industrial", "https://picsum.photos/640/480/?image=828", 0.9009229768686650m, "navigate" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Frozen", "https://picsum.photos/640/480/?image=697", 0.8018986595473090m, "experiences" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Industrial, Games & Shoes", "https://picsum.photos/640/480/?image=42", 0.6781155987445040m, "white" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Togo Directives HDD", "https://picsum.photos/640/480/?image=895", 0.03514794371906370m, "Handmade Soft Gloves" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Personal Loan Account demand-driven Program", "https://picsum.photos/640/480/?image=244", 0.5093357091095230m, "help-desk" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Divide", "https://picsum.photos/640/480/?image=874", 0.5283742191852630m, "SMS" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Liaison", "https://picsum.photos/640/480/?image=60", 0.4228703689943570m, "Switchable" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "systemic", "https://picsum.photos/640/480/?image=767", 0.3189810595778920m, "Music, Music & Garden" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price" },
                values: new object[] { 3, "Wisconsin Rustic Plastic Car interface", "https://picsum.photos/640/480/?image=905", 0.3722831521505170m });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Denmark", "https://picsum.photos/640/480/?image=266", 0.6719283296039910m, "monitor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Integration Clothing", "https://picsum.photos/640/480/?image=974", 0.5801060170722280m, "eyeballs" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Guadeloupe", "https://picsum.photos/640/480/?image=876", 0.4159348910414540m, "even-keeled" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Borders Practical", "https://picsum.photos/640/480/?image=1032", 0.02725615332161360m, "Auto Loan Account" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "multimedia bus payment", "https://picsum.photos/640/480/?image=629", 0.6889164400257790m, "Dynamic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "black", "https://picsum.photos/640/480/?image=393", 0.9294101013455070m, "Congolese Franc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Orchestrator parsing", "https://picsum.photos/640/480/?image=67", 0.4312914363752510m, "Road" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "silver Iowa Operations", "https://picsum.photos/640/480/?image=605", 0.5703609390252840m, "rich" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "bus", "https://picsum.photos/640/480/?image=931", 0.6303524657335280m, "wireless" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Soft e-business", "https://picsum.photos/640/480/?image=730", 0.1788298839567580m, "Checking Account" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Grocery & Movies", "https://picsum.photos/640/480/?image=320", 0.5815989742301970m, "Planner" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Personal Loan Account connect interfaces", "https://picsum.photos/640/480/?image=105", 0.6738173458761850m, "Frozen" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "grey compressing Practical", "https://picsum.photos/640/480/?image=565", 0.7381102516469040m, "New Mexico" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Clothing Utah haptic", "https://picsum.photos/640/480/?image=696", 0.9308805687643590m, "B2B" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "neural Concrete Robust", "https://picsum.photos/640/480/?image=59", 0.8801856640808740m, "Arizona" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Generic Soft Shirt FTP", "https://picsum.photos/640/480/?image=814", 0.8874386208178440m, "experiences" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Ergonomic", "https://picsum.photos/640/480/?image=222", 0.6052081155467880m, "COM" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "lime", "https://picsum.photos/640/480/?image=166", 0.2171810201230360m, "contingency" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "bus", "https://picsum.photos/640/480/?image=662", 0.8773015770917330m, "reinvent" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "program", "https://picsum.photos/640/480/?image=42", 0.2812472524958230m, "global" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Gibraltar Pound", "https://picsum.photos/640/480/?image=683", 0.54349424473780m, "Malta" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "vertical", "https://picsum.photos/640/480/?image=928", 0.4233552970760010m, "Devolved" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Cordoba Oro Forge European Unit of Account 9(E.U.A.-9)", "https://picsum.photos/640/480/?image=918", 0.1704332474434940m, "input" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "El Salvador Colon", "https://picsum.photos/640/480/?image=464", 0.8490165293326960m, "capacitor" });
        }
    }
}
