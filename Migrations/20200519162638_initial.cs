using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BandAPI.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bands",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Founded = table.Column<DateTime>(nullable: false),
                    MainGenre = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Title = table.Column<string>(maxLength: 200, nullable: false),
                    Description = table.Column<string>(maxLength: 400, nullable: true),
                    BandId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albums_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Bands",
                columns: new[] { "Id", "Founded", "MainGenre", "Name" },
                values: new object[,]
                {
                    { new Guid("e912458d-da72-46df-a17c-7427c9687237"), new DateTime(1981, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Heavy Metal", "Metallica" },
                    { new Guid("95209b50-83f6-4995-834f-708c495f78be"), new DateTime(1996, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Indie Rock", "The Shins" },
                    { new Guid("552f2f6a-bd51-4969-a8f0-9c1fcb7301a9"), new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock", "Guns N Roses" },
                    { new Guid("c3203c2c-653d-4033-bbb3-bf44f379db7c"), new DateTime(1972, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Disco", "ABBA" },
                    { new Guid("5f7d7c0b-6052-468a-9414-da1364ee76c1"), new DateTime(1992, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alternative", "Oasis" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "Id", "BandId", "Description", "Title" },
                values: new object[,]
                {
                    { new Guid("d6db7bd7-2406-48a9-ab9e-adaeaa10a3e1"), new Guid("e912458d-da72-46df-a17c-7427c9687237"), "Master of Puppets is the third studio album by American heavy metal band Metallica, released on March 3, 1986, by Elektra Records.", "Master of Puppets" },
                    { new Guid("d277729c-d5b5-44e7-b70f-3a798053a6b1"), new Guid("95209b50-83f6-4995-834f-708c495f78be"), "Oh, Inverted World is the debut studio album by American indie rock band The Shins, released on June 19, 2001 to critical acclaim.", "Oh, Inverted World" },
                    { new Guid("0238aa24-1064-404d-867f-1c6c37bb48d9"), new Guid("552f2f6a-bd51-4969-a8f0-9c1fcb7301a9"), "Appetite for Destruction is the debut studio album by American hard rock band Guns N' Roses. It was released on July 21, 1987, by Geffen Records.", "Appetite for Destruction" },
                    { new Guid("3ac39fec-e8ec-45e8-bcc3-c62743da1fee"), new Guid("c3203c2c-653d-4033-bbb3-bf44f379db7c"), "Arrival is the fourth studio album by the Swedish pop group ABBA. It was originally released in Sweden on 11 October 1976 by Polar Records. ", "Arrival" },
                    { new Guid("fe89c16a-07a8-44f5-886b-4fa75015feb8"), new Guid("5f7d7c0b-6052-468a-9414-da1364ee76c1"), "Definitely Maybe is the debut studio album by English rock band Oasis, released by Creation Records on 29 August 1994.", "Definitely Maybe" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albums_BandId",
                table: "Albums",
                column: "BandId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.DropTable(
                name: "Bands");
        }
    }
}
