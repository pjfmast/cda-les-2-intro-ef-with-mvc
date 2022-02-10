using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Les2EFMVC.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Group = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TeamId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "Group", "Title" },
                values: new object[,]
                {
                    { 201, "Groep-A", "Alpha Wolf Squadron" },
                    { 202, "Groep-B", "Moviehub" },
                    { 203, "Groep-H", "The Cool beans" },
                    { 204, "Groep-1", "You snooze, you loose!" },
                    { 205, "Groep-2", "Nachos" },
                    { 206, "Groep-3", "3 front-end devs + 1 back-end dev" },
                    { 207, "Groep-4", "Cinavas" }
                });

            migrationBuilder.InsertData(
                table: "Members",
                columns: new[] { "Id", "Email", "Name", "TeamId" },
                values: new object[,]
                {
                    { 1001, "henk@breda.nl", "Henk", 201 },
                    { 1002, "tim@breda.nl", "Tim", 201 },
                    { 1003, "robbert@breda.nl", "Robbert", 201 },
                    { 1004, "paul@breda.nl", "Paul", 201 },
                    { 1005, "Bart-Jan@breda.nl", "Niek", 201 },
                    { 1006, "Teun@breda.nl", "Teun", 201 },
                    { 1007, "bart@avans.nl", "Bart", 202 },
                    { 1008, "joris@avans.nl", "Joris", 202 },
                    { 1009, "danny@avans.nl", "Danny", 202 },
                    { 1010, "lars@avans.nl", "Lars", 202 },
                    { 1011, "rob@avans.nl", "Rob", 202 },
                    { 1012, "dennis@avans.nl", "Dennis", 202 },
                    { 1013, "daniel@avans.nl", "Daniël", 202 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_TeamId",
                table: "Members",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
