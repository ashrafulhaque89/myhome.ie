using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Home",
                columns: table => new
                {
                    PropertyId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    GroupLogoUrl = table.Column<string>(nullable: true),
                    BedsString = table.Column<string>(nullable: true),
                    Price = table.Column<string>(nullable: true),
                    SizeStringMeters = table.Column<double>(nullable: false),
                    DisplayAddress = table.Column<string>(nullable: true),
                    PropertyType = table.Column<string>(nullable: true),
                    BathString = table.Column<string>(nullable: true),
                    BerRating = table.Column<string>(nullable: true),
                    MainPhoto = table.Column<string>(nullable: true),
                    Photos = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Home", x => x.PropertyId);
                });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4292232, null, "2 beds", "D2", "Apt. 16 The Northumberlands, Off Lower Mount Street, Dublin 2", "https://photosa.propertyimages.ie/groups/9/0/4/6409/logo.jpg", "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg", "https://photosa.propertyimages.ie/media/2/3/2/4292232/38e98b8e-645f-4adf-8e57-f927e5769840_l.jpg,https://photosa.propertyimages.ie/media/2/3/2/4292232/e0c4c2c8-6a61-4fda-b5a8-59edc32060b6_l.jpg,https://photosa.propertyimages.ie/media/2/3/2/4292232/b5ce3372-d71c-4897-91dc7c5b4ce21c17_l.jpg", "395000", "Apartment", 52.950000000000003 });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4229499, "4 baths", "5 beds", "B2", "Alleen, Donohill, Tipperary", "https://photosa.propertyimages.ie/groups/9/2/6/283629/logo.jpg", "https://photosa.propertyimages.ie/media/9/9/4/4229499/aae25e08-31b0-465b-ba35-498d78f6b5c9_l.jpg", "https://photosa.propertyimages.ie/media/9/9/4/4229499/aae25e08-31b0-465b-ba35-498d78f6b5c9_l.jpg,https://photosa.propertyimages.ie/media/9/9/4/4229499/7f983103-2529-425a-905b617b23bfa0f7_l.jpg,https://photosa.propertyimages.ie/media/9/9/4/4229499/4470fb1c-c301-4b1c-8bfae1c85a5d8fbc_l.jpg", "420000", "Detached House", 98.0 });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4301249, "1 bath", "2 beds", "G", "20 Gratton Street, Gorey,	Wexford", "https://photosa.propertyimages.ie/groups/3/1/4/256413/logo.jpg", "https://photosa.propertyimages.ie/media/9/4/2/4301249/0e9bc081-ab16-4885-bddbf33678432a17_l.jpg", "https://photosa.propertyimages.ie/media/9/4/2/4301249/0e9bc081-ab16-4885-bddbf33678432a17_l.jpg,https://photosa.propertyimages.ie/media/9/4/2/4301249/2e03ba2b-471d-4f93-a8ad6bfecd2fd35b_l.jpg", "99000", "Terraced House", 52.950000000000003 });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4301247, "4 baths", "4 beds", "C1", "Cappagh, Inistioge, Co Kilkenny, R95 E642", "https://photosa.propertyimages.ie/groups/0/5/6/5650/logo.jpg", "https://photosa.propertyimages.ie/media/7/4/2/4301247/7ff064ce-07c2-4a34-8765-d031b7a28295_l.jpg", "https://photosa.propertyimages.ie/media/7/4/2/4301247/7ff064ce-07c2-4a34-8765-d031b7a28295_l.jpg,https://photosa.propertyimages.ie/media/7/4/2/4301247/ecd5bd19-e956-4c04-9932-0cf0112bb2f6_l.jpg,https://photosa.propertyimages.ie/media/7/4/2/4301247/94b223ea-a365-4646-966d90743344a5d0_l.jpg,https://photosa.propertyimages.ie/media/7/4/2/4301247/be1c10b1-d7be-4c97-890dc8759f288881_l.jpg", "550000", "Detached House", 238.40000000000001 });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4301246, "1 bath", "3 beds", null, "4	Rices Street, Dungarvan, Waterford", "https://photosa.propertyimages.ie/groups/8/6/9/8968/logo.jpg", "https://photosa.propertyimages.ie/media/6/4/2/4301246/90ef0a16-59e7-410c-b688-f45361fc00df_l.jpg", "https://photosa.propertyimages.ie/media/6/4/2/4301246/90ef0a16-59e7-410c-b688-f45361fc00df_l.jpg,https://photosa.propertyimages.ie/media/6/4/2/4301246/2066a03f-d26a-4ceb-92ddd0247556c803_l.jpg,https://photosa.propertyimages.ie/media/6/4/2/4301246/a28bd769-e544-468f-8fa6-e590a3ed77c0_l.jpg,https://photosa.propertyimages.ie/media/6/4/2/4301246/183b8fa1-33d1-4bcb-91ae696f51c08935_l.jpg,https://photosa.propertyimages.ie/media/6/4/2/4301246/8e15e93c-c64e-4306-a18fa276858b25da_l.jpg", "135000", "End	of Terrace House", 1010.0 });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4301245, "2 bath", "3 beds", null, "Cloghan Road,	Shannonbridge, Offaly", "https://photosa.propertyimages.ie/groups/9/9/5/309599/logo.jpg", "https://photosa.propertyimages.ie/media/5/4/2/4301245/a8fc46c4-6676-4e82-89cf74c1736ce441_l.jpg", "https://photosa.propertyimages.ie/media/5/4/2/4301245/a8fc46c4-6676-4e82-89cf74c1736ce441_l.jpg,https://photosa.propertyimages.ie/media/5/4/2/4301245/c6756ace-04b6-4701-b80bbb74f9b985de_l.jpg,https://photosa.propertyimages.ie/media/5/4/2/4301245/7976ee5f-3dc0-4874-833dc169cd0e2ef9_l.jpg,https://photosa.propertyimages.ie/media/5/4/2/4301245/0eade5e7-95b6-43dc-a22da12ec5e37159_l.jpg,https://photosa.propertyimages.ie/media/5/4/2/4301245/7c4d1310-c0c6-4403-97e0-ecc84e564605_l.jpg", "POA", "Bungalow", 109.0 });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4284885, "1 bath", "4 beds", "D1", "45 Ardmore, Gorey, Wexford", "https://photosa.propertyimages.ie/groups/3/1/4/256413/logo.jpg", "https://photosa.propertyimages.ie/media/5/8/8/4284885/f85794ff-5714-4247-91a0-08eed0853a46_l.jpg", "https://photosa.propertyimages.ie/media/5/8/8/4284885/f85794ff-5714-4247-91a0-08eed0853a46_l.jpg,https://photosa.propertyimages.ie/media/5/8/8/4284885/1e2309b8-8fa3-4315-bf20-488d5532856b_l.jpg,https://photosa.propertyimages.ie/media/5/8/8/4284885/394f3834-3ccd-4185-9eeeaf6686004801_l.jpg,https://photosa.propertyimages.ie/media/5/8/8/4284885/9100e307-c3dc-468c-bbfc4e0509cf69be_l.jpg", "325000", "Detached House", 0.0 });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4301244, "2 bath", "3 beds", null, "21 Derryounce, Portarlington,	Co.	Laois", "https://photosa.propertyimages.ie/groups/7/0/1/259107/logo.jpg", "https://photosa.propertyimages.ie/media/4/4/2/4301244/dcacf01c-089b-4d54-b452-eb0d9cb9de4d_l.jpg", "https://photosa.propertyimages.ie/media/4/4/2/4301244/dcacf01c-089b-4d54-b452-eb0d9cb9de4d_l.jpg,https://photosa.propertyimages.ie/media/4/4/2/4301244/e60480c8-a834-41ee-8250-9d2c97ba249e_l.jpg,https://photos-a.propertyimages.ie/media/8/9/2/3851298/44915955-f480-4f3d-8e42-84f12ebfbfde_l.jpg,https://photosa.propertyimages.ie/media/8/9/2/3851298/d8874610-f7ca-4e2b-b450-1dd19597ff0c_l.jpg,https://photosa.propertyimages.ie/media/8/9/2/3851298/3360cd3a-d478-47ab-94b0-f1bd30361dda_l.jpg", "200000", "End	of Terrace House", 0.0 });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4301243, null, "3 beds", null, "22 Derryounce, Portarlington,	Co.	Laois", "https://photosa.propertyimages.ie/groups/7/0/1/259107/logo.jpg", "https://photosa.propertyimages.ie/media/3/4/2/4301243/4453564d-ffa4-4e58-af73-04104692e3cd_l.jpg", "https://photosa.propertyimages.ie/media/3/4/2/4301243/4453564d-ffa4-4e58-af73-04104692e3cd_l.jpg,https://photos-a.propertyimages.ie/media/8/9/2/3851298/9991fa79-d54d-4c0d-a753-23838287e215_l.jpg,https://photos-a.propertyimages.ie/media/8/9/2/3851298/9b15a341-5698-4d8a-9849-a8d2df6f4bef_l.jpg,https://photosa.propertyimages.ie/media/3/4/2/4301243/b7a48e74-ff8a-436d-af3a4eb2ed0c47de_l.jpg", "260000", "Terraced House", 0.0 });

            migrationBuilder.InsertData(
                table: "Home",
                columns: new[] { "PropertyId", "BathString", "BedsString", "BerRating", "DisplayAddress", "GroupLogoUrl", "MainPhoto", "Photos", "Price", "PropertyType", "SizeStringMeters" },
                values: new object[] { 4301242, null, "3 beds", null, "23 Derryounce, Portarlington,	Co.	Laois", "https://photosa.propertyimages.ie/groups/7/0/1/259107/logo.jpg", "https://photosa.propertyimages.ie/media/2/4/2/4301242/4c9ea054-1865-4bd3-901a6ad05a79fa7e_l.jpg", "https://photosa.propertyimages.ie/media/2/4/2/4301242/4c9ea054-1865-4bd3-901a6ad05a79fa7e_l.jpg,https://photosa.propertyimages.ie/media/2/4/2/4301242/f08c8c5d-731d-4be3-a78ee3501d1214d6_l.jpg", "200000", "Terraced House", 0.0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Home");
        }
    }
}
