using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MarketApp.Server.Migrations
{
    /// <inheritdoc />
    public partial class addmorefakedata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Centralized", "centralized" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Url" },
                values: new object[] { "synthesize", "synthesize" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Product", "product" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Url" },
                values: new object[] { "neural", "neural" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Ports", "ports" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Ergonomic Soft Chair", "ergonomic soft chair" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Games & Toys", "games & toys" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Louisiana", "louisiana" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Url" },
                values: new object[] { "embrace", "embrace" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Url" },
                values: new object[] { "quantifying", "quantifying" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Url" },
                values: new object[] { "software", "software" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Url" },
                values: new object[] { "green", "green" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Url" },
                values: new object[] { "transition", "transition" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Supervisor", "supervisor" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Url" },
                values: new object[] { "integrated", "integrated" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Avon", "avon" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Creek", "creek" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Url" },
                values: new object[] { "withdrawal", "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Url" },
                values: new object[] { "proactive", "proactive" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Movies, Automotive & Automotive", "https://picsum.photos/640/480/?image=982", 0.09704865928557020m, "auxiliary" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 10, "green", "https://picsum.photos/640/480/?image=792", 0.2188268138818930m, "Analyst" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 11, "Specialist", "https://picsum.photos/640/480/?image=907", 0.5924540708555420m, "index" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 14, "SAS", "https://picsum.photos/640/480/?image=68", 0.2712196068124340m, "SMS" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "Savings Account synergy Home Loan Account", "https://picsum.photos/640/480/?image=79", 0.5431039372329590m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 7, "Handmade Cotton Towels Granite", "https://picsum.photos/640/480/?image=671", 0.08684005129961270m, "Ramp" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 17, "deposit compressing", "https://picsum.photos/640/480/?image=333", 0.7445156121727590m, "Springs" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "New Caledonia backing up", "https://picsum.photos/640/480/?image=409", 0.6916672732764870m, "Money Market Account" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 18, "Cove pixel", "https://picsum.photos/640/480/?image=973", 0.5661251806881360m, "Indiana" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "B2C Assistant Investor", "https://picsum.photos/640/480/?image=139", 0.644513148148950m, "Small Cotton Car" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Berkshire Creek generate", "https://picsum.photos/640/480/?image=476", 0.0881751192762140m, "ivory" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 7, "Parks withdrawal", "https://picsum.photos/640/480/?image=631", 0.6773562321483620m, "Key" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 9, "indexing", "https://picsum.photos/640/480/?image=459", 0.3430671906592360m, "Cape" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 18, "driver hybrid invoice", "https://picsum.photos/640/480/?image=532", 0.4596908186888730m, "feed" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "auxiliary", "https://picsum.photos/640/480/?image=374", 0.7759023588502580m, "system" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Granite", "https://picsum.photos/640/480/?image=385", 0.1175122404938910m, "overriding" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 16, "Montana", "https://picsum.photos/640/480/?image=545", 0.881574733235660m, "redundant" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 7, "Plastic XML", "https://picsum.photos/640/480/?image=831", 0.06158321909415790m, "Executive" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 6, "FTP", "https://picsum.photos/640/480/?image=865", 0.9023295801786140m, "Program" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Rustic Granite Gloves Consultant", "https://picsum.photos/640/480/?image=1044", 0.9884119145598320m, "District" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 15, "scalable Small Concrete Pizza Baby, Automotive & Jewelery", "https://picsum.photos/640/480/?image=864", 0.2936221258781160m, "compressing" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 8, "port demand-driven", "https://picsum.photos/640/480/?image=990", 0.8609509219870420m, "Won" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "UIC-Franc bluetooth", "https://picsum.photos/640/480/?image=905", 0.6597034041625130m, "maroon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "Mountains Ergonomic Steel Bacon", "https://picsum.photos/640/480/?image=310", 0.09860280042542440m, "Grocery" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 10, "Orchestrator software", "https://picsum.photos/640/480/?image=1", 0.9340070629927330m, "haptic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 4, "Handcrafted Cotton Pants Savings Account hard drive", "https://picsum.photos/640/480/?image=592", 0.198294344478610m, "orange" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Syrian Pound", "https://picsum.photos/640/480/?image=367", 0.7179529161572640m, "Tasty Plastic Pizza" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 12, "compress", "https://picsum.photos/640/480/?image=396", 0.7913470619511020m, "Corporate" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 17, "1080p", "https://picsum.photos/640/480/?image=179", 0.8003013878387470m, "Ohio" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 9, "withdrawal hard drive Fundamental", "https://picsum.photos/640/480/?image=214", 0.1595396952323310m, "Small Rubber Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 14, "bypassing orange", "https://picsum.photos/640/480/?image=714", 0.5168651139965380m, "Security" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "productize", "https://picsum.photos/640/480/?image=657", 0.02127036614983960m, "Isle" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 14, "Fantastic Florida", "https://picsum.photos/640/480/?image=96", 0.06263015279787050m, "Steel" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 16, "users Refined Rubber Table TCP", "https://picsum.photos/640/480/?image=977", 0.1391426458476170m, "transmitting" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 16, "Cross-group utilisation withdrawal", "https://picsum.photos/640/480/?image=256", 0.3937756376219510m, "SCSI" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 11, "Metal", "https://picsum.photos/640/480/?image=353", 0.5133066549712820m, "turquoise" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "database Accounts", "https://picsum.photos/640/480/?image=317", 0.1285496790549730m, "seamless" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 15, "Metal Ergonomic Fresh Table Ranch", "https://picsum.photos/640/480/?image=92", 0.4198633710966570m, "array" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "Generic payment Avon", "https://picsum.photos/640/480/?image=899", 0.01920899100289240m, "proactive" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Islands Row", "https://picsum.photos/640/480/?image=159", 0.09045887276729070m, "alarm" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 20, "B2C Checking Account monitor", "https://picsum.photos/640/480/?image=953", 0.1530777865361980m, "experiences" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Lake Savings Account Corporate", "https://picsum.photos/640/480/?image=255", 0.1204186049886620m, "Fresh" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 16, "Course", "https://picsum.photos/640/480/?image=355", 0.6511596181758390m, "channels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 9, "override maximize Money Market Account", "https://picsum.photos/640/480/?image=325", 0.4224335344083790m, "Union" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Borders", "https://picsum.photos/640/480/?image=991", 0.8866676913226770m, "Clothing, Shoes & Baby" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 13, "system", "https://picsum.photos/640/480/?image=1076", 0.340955988103510m, "Handmade Steel Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "XML Communications override", "https://picsum.photos/640/480/?image=909", 0.9913504379314130m, "SSL" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 8, "Toys, Toys & Music", "https://picsum.photos/640/480/?image=1035", 0.2380325851168440m, "Rue" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 10, "Consultant", "https://picsum.photos/640/480/?image=1057", 0.7824904000066360m, "Gambia" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 13, "engage withdrawal strategy", "https://picsum.photos/640/480/?image=494", 0.821710189155280m, "Investment Account" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 51, 14, "Checking Account Bedfordshire Corporate", "https://picsum.photos/640/480/?image=584", 0.4139317930806120m, "Markets" },
                    { 52, 20, "Panama", "https://picsum.photos/640/480/?image=572", 0.3452683920036540m, "Metal" },
                    { 53, 9, "Concrete online", "https://picsum.photos/640/480/?image=279", 0.1060484223505710m, "deposit" },
                    { 54, 17, "Honduras Fresh", "https://picsum.photos/640/480/?image=58", 0.1551414543759080m, "lavender" },
                    { 55, 6, "Tasty Handcrafted", "https://picsum.photos/640/480/?image=543", 0.3936420937995010m, "Branch" },
                    { 56, 20, "Functionality Avon Tunnel", "https://picsum.photos/640/480/?image=316", 0.1475286628930210m, "cultivate" },
                    { 57, 6, "Fantastic generating transmitting", "https://picsum.photos/640/480/?image=513", 0.2549104876870490m, "Row" },
                    { 58, 7, "transmitter", "https://picsum.photos/640/480/?image=1070", 0.02090494771643890m, "copy" },
                    { 59, 11, "Checking Account pink Extension", "https://picsum.photos/640/480/?image=390", 0.6227306632829190m, "Incredible" },
                    { 60, 18, "Borders North Dakota Lead", "https://picsum.photos/640/480/?image=285", 0.598356417594230m, "Sleek Metal Sausages" },
                    { 61, 20, "Personal Loan Account sky blue", "https://picsum.photos/640/480/?image=491", 0.3948621926085550m, "Health, Kids & Computers" },
                    { 62, 11, "Games & Grocery", "https://picsum.photos/640/480/?image=226", 0.1010828707014020m, "Money Market Account" },
                    { 63, 19, "Concrete hacking engineer", "https://picsum.photos/640/480/?image=309", 0.7273002993756330m, "card" },
                    { 64, 18, "Norwegian Krone Mexico whiteboard", "https://picsum.photos/640/480/?image=553", 0.8898772856576140m, "embrace" },
                    { 65, 10, "Internal compressing", "https://picsum.photos/640/480/?image=657", 0.7729354774012020m, "Tools, Clothing & Movies" },
                    { 66, 16, "benchmark Baby & Music indexing", "https://picsum.photos/640/480/?image=450", 0.7864916241967240m, "Rubber" },
                    { 67, 20, "Credit Card Account Cambridgeshire Gorgeous Steel Keyboard", "https://picsum.photos/640/480/?image=250", 0.4587265483488760m, "analyzing" },
                    { 68, 1, "Licensed Concrete Table invoice", "https://picsum.photos/640/480/?image=954", 0.2662229721384780m, "Orchestrator" },
                    { 69, 16, "Gorgeous Movies, Tools & Toys Unbranded", "https://picsum.photos/640/480/?image=157", 0.5458228812461210m, "global" },
                    { 70, 16, "whiteboard", "https://picsum.photos/640/480/?image=303", 0.6680056450944130m, "Credit Card Account" },
                    { 71, 20, "PNG Producer", "https://picsum.photos/640/480/?image=205", 0.2974991618137510m, "bluetooth" },
                    { 72, 5, "generating Operative", "https://picsum.photos/640/480/?image=715", 0.08675315171696020m, "International" },
                    { 73, 20, "Credit Card Account Fantastic Wooden Table", "https://picsum.photos/640/480/?image=523", 0.1559110218606340m, "Adaptive" },
                    { 74, 11, "Planner optimizing Stand-alone", "https://picsum.photos/640/480/?image=185", 0.9493295582932270m, "orchid" },
                    { 75, 10, "program Burg methodologies", "https://picsum.photos/640/480/?image=735", 0.4566694491096520m, "supply-chains" },
                    { 76, 19, "Stream Bedfordshire payment", "https://picsum.photos/640/480/?image=445", 0.7047977895017360m, "Bermudian Dollar (customarily known as Bermuda Dollar)" },
                    { 77, 16, "Direct", "https://picsum.photos/640/480/?image=569", 0.9712129756175320m, "transmitting" },
                    { 78, 4, "Implementation", "https://picsum.photos/640/480/?image=869", 0.6174321635733850m, "Practical Metal Computer" },
                    { 79, 20, "Awesome", "https://picsum.photos/640/480/?image=730", 0.601513794118140m, "coherent" },
                    { 80, 14, "Utah Checking Account", "https://picsum.photos/640/480/?image=267", 0.4467689327813890m, "scalable" },
                    { 81, 9, "integrate", "https://picsum.photos/640/480/?image=616", 0.661870311223840m, "pink" },
                    { 82, 12, "synthesizing payment", "https://picsum.photos/640/480/?image=243", 0.7803640342306910m, "generating" },
                    { 83, 8, "application Wooden Garden & Tools", "https://picsum.photos/640/480/?image=283", 0.3053544692138260m, "Branch" },
                    { 84, 16, "generating bypass", "https://picsum.photos/640/480/?image=338", 0.53117129098640m, "back up" },
                    { 85, 14, "Grocery, Clothing & Tools COM Buckinghamshire", "https://picsum.photos/640/480/?image=966", 0.9556480531557240m, "Cotton" },
                    { 86, 13, "Bahrain EXE compressing", "https://picsum.photos/640/480/?image=973", 0.4160300266222160m, "Principal" },
                    { 87, 17, "Wooden generate", "https://picsum.photos/640/480/?image=528", 0.2624035703168950m, "Personal Loan Account" },
                    { 88, 8, "Handcrafted Plastic Chicken programming Intelligent Metal Pizza", "https://picsum.photos/640/480/?image=476", 0.6902883835055780m, "Investor" },
                    { 89, 2, "Well Refined", "https://picsum.photos/640/480/?image=506", 0.8466194038976610m, "navigate" },
                    { 90, 10, "platforms visionary", "https://picsum.photos/640/480/?image=75", 0.07624610507263540m, "pixel" },
                    { 91, 4, "web-readiness algorithm", "https://picsum.photos/640/480/?image=14", 0.8455001813167130m, "Unbranded Soft Table" },
                    { 92, 18, "architect Corporate", "https://picsum.photos/640/480/?image=719", 0.1061750432166690m, "Auto Loan Account" },
                    { 93, 11, "PCI Rustic Cambodia", "https://picsum.photos/640/480/?image=810", 0.4733940649484770m, "Small Granite Shoes" },
                    { 94, 17, "Incredible Concrete Chips New Mexico Program", "https://picsum.photos/640/480/?image=332", 0.9295558665974310m, "Sleek Granite Towels" },
                    { 95, 1, "reinvent Som back up", "https://picsum.photos/640/480/?image=205", 0.2894745414195920m, "Bedfordshire" },
                    { 96, 5, "Rustic Metal Mouse", "https://picsum.photos/640/480/?image=549", 0.5180219383014810m, "Assistant" },
                    { 97, 11, "online", "https://picsum.photos/640/480/?image=638", 0.3754106238206730m, "turquoise" },
                    { 98, 7, "benchmark", "https://picsum.photos/640/480/?image=854", 0.327662940172660m, "Generic Metal Chair" },
                    { 99, 12, "Awesome Concrete Cheese Handmade revolutionize", "https://picsum.photos/640/480/?image=93", 0.7786348482765020m, "Berkshire" },
                    { 100, 1, "Configurable", "https://picsum.photos/640/480/?image=334", 0.707163935200380m, "Awesome Granite Fish" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 100);

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
                values: new object[] { "lavender", "lavender" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Savings Account", "savings account" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Url" },
                values: new object[] { "cutting-edge", "cutting-edge" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Name", "Url" },
                values: new object[] { "TCP", "tcp" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Name", "Url" },
                values: new object[] { "time-frame", "time-frame" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Corporate", "corporate" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Ghana", "ghana" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Url" },
                values: new object[] { "South Carolina", "south carolina" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Enhanced", "enhanced" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Spurs", "spurs" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Name", "Url" },
                values: new object[] { "THX", "thx" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Landing", "landing" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Name", "Url" },
                values: new object[] { "protocol", "protocol" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Url" },
                values: new object[] { "Response", "response" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Name", "Url" },
                values: new object[] { "salmon", "salmon" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Url" },
                values: new object[] { "generate", "generate" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Name", "Url" },
                values: new object[] { "strategic", "strategic" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Url" },
                values: new object[] { "relationships", "relationships" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 12, "red Auto Loan Account navigating", "https://picsum.photos/640/480/?image=1069", 0.4591908585402250m, "models" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 11, "Steel Alaska invoice", "https://picsum.photos/640/480/?image=539", 0.8782998746253810m, "Direct" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "magenta New Mexico Drive", "https://picsum.photos/640/480/?image=254", 0.5919881096541780m, "enterprise" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 12, "synthesize 4th generation", "https://picsum.photos/640/480/?image=408", 0.8289136459954160m, "Spur" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Turkish Lira Soft Burkina Faso", "https://picsum.photos/640/480/?image=301", 0.4042950562715520m, "Guinea" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "Facilitator", "https://picsum.photos/640/480/?image=46", 0.1333902662784290m, "East Caribbean Dollar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Future Auto Loan Account", "https://picsum.photos/640/480/?image=954", 0.2902385712511810m, "Cambridgeshire" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "AI Chad Handcrafted", "https://picsum.photos/640/480/?image=1072", 0.1525986530209030m, "Dynamic" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 7, "enhance", "https://picsum.photos/640/480/?image=493", 0.8849403244758140m, "payment" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 7, "generate Cotton Configuration", "https://picsum.photos/640/480/?image=219", 0.7649123579793960m, "Computers, Tools & Beauty" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 17, "payment", "https://picsum.photos/640/480/?image=390", 0.02537261229502430m, "Malagasy Ariary" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 16, "CSS Personal Loan Account exploit", "https://picsum.photos/640/480/?image=207", 0.2386488541910810m, "Unbranded Soft Towels" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "generating California", "https://picsum.photos/640/480/?image=724", 0.6849361969050630m, "e-commerce" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 17, "parse Rwanda firmware", "https://picsum.photos/640/480/?image=821", 0.7099702144065030m, "Vision-oriented" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "fuchsia deposit", "https://picsum.photos/640/480/?image=278", 0.9360734384961360m, "bandwidth" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 20, "transparent Wall", "https://picsum.photos/640/480/?image=846", 0.6339809942639940m, "Utah" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 20, "connect Well", "https://picsum.photos/640/480/?image=477", 0.3152268917113990m, "Handmade Cotton Pants" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "HTTP Islands", "https://picsum.photos/640/480/?image=3", 0.8845169364849360m, "Libyan Dinar" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 8, "IB Books Israel", "https://picsum.photos/640/480/?image=590", 0.2966574477050680m, "compress" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "Money Market Account redundant website", "https://picsum.photos/640/480/?image=223", 0.5732423393145120m, "enhance" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 6, "Junctions North Carolina client-server", "https://picsum.photos/640/480/?image=634", 0.3384615429942750m, "deposit" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 10, "Drive gold", "https://picsum.photos/640/480/?image=719", 0.2464911109572780m, "B2B" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "South Georgia and the South Sandwich Islands Kina", "https://picsum.photos/640/480/?image=528", 0.6304824590762030m, "budgetary management" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 6, "wireless Concrete Metrics", "https://picsum.photos/640/480/?image=1057", 0.5825068766790850m, "Metrics" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Metal back up", "https://picsum.photos/640/480/?image=533", 0.6705873037909120m, "disintermediate" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 7, "Producer Drives Gold", "https://picsum.photos/640/480/?image=662", 0.1589859845573280m, "schemas" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 20, "synergistic Belgium", "https://picsum.photos/640/480/?image=203", 0.6500834703009970m, "Buckinghamshire" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 13, "Dominican Republic withdrawal channels", "https://picsum.photos/640/480/?image=903", 0.1486947705271360m, "Refined" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 8, "Point programming", "https://picsum.photos/640/480/?image=395", 0.03997715579240450m, "invoice" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "payment Operations Distributed", "https://picsum.photos/640/480/?image=120", 0.4202340868626720m, "navigate" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "models", "https://picsum.photos/640/480/?image=1003", 0.6670530195975460m, "copying" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "Digitized", "https://picsum.photos/640/480/?image=1076", 0.9077327213158320m, "backing up" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 12, "Direct", "https://picsum.photos/640/480/?image=466", 0.6360598807140320m, "Books, Kids & Kids" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 14, "quantify payment", "https://picsum.photos/640/480/?image=9", 0.4237339156949170m, "Unbranded Fresh Chair" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 18, "deliver Licensed Steel Ball Park", "https://picsum.photos/640/480/?image=879", 0.8676752836915070m, "revolutionary" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 18, "Product experiences", "https://picsum.photos/640/480/?image=888", 0.5663098765891510m, "Usability" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 9, "Indian Rupee magenta", "https://picsum.photos/640/480/?image=151", 0.6643886943180480m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 17, "Prairie sensor action-items", "https://picsum.photos/640/480/?image=395", 0.7787062448121420m, "Generic Soft Bacon" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Shoal Cambridgeshire", "https://picsum.photos/640/480/?image=69", 0.3841720728303790m, "asynchronous" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 3, "Metal", "https://picsum.photos/640/480/?image=109", 0.7061102481879710m, "Steel" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 10, "red", "https://picsum.photos/640/480/?image=976", 0.3990801438484810m, "withdrawal" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 9, "neural Tasty Rubber Towels PNG", "https://picsum.photos/640/480/?image=1030", 0.7401998550192690m, "cross-platform" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Awesome Steel Tuna Global", "https://picsum.photos/640/480/?image=285", 0.5133939336126170m, "responsive" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "Digitized", "https://picsum.photos/640/480/?image=25", 0.3977843006304820m, "Harbor" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { "overriding Optimization Engineer", "https://picsum.photos/640/480/?image=497", 0.4904414226121620m, "indigo" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 15, "strategy Rustic Wooden Soap transmitting", "https://picsum.photos/640/480/?image=798", 0.979224795507190m, "Generic Metal Fish" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 5, "Awesome Cotton Chicken Cook Islands", "https://picsum.photos/640/480/?image=805", 0.9235797972878820m, "Specialist" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 17, "Small Concrete Bike Buckinghamshire", "https://picsum.photos/640/480/?image=319", 0.2370368841653140m, "collaborative" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 19, "Versatile convergence", "https://picsum.photos/640/480/?image=805", 0.2523714213667230m, "harness" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CategoryId", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Movies & Shoes", "https://picsum.photos/640/480/?image=164", 0.4732622577219790m, "West Virginia" });
        }
    }
}
