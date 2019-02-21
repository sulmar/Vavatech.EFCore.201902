using Microsoft.EntityFrameworkCore.Migrations;

namespace Vavatech.EFCore.DbServices.Migrations
{
    public partial class AddPeselToCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Pesel",
                table: "Customers",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Velma", "Berge" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Wm", "Grimes" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Doug", "Marvin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Tyler", "Wisoky" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Brenda", "Senger" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Stephanie", "Jones" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Juana", false, "Jast" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Judith", "Smith" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Claude", true, "Larkin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Edgar", "Borer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kathleen", "Rutherford" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Erick", true, "Labadie" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kristine", "Crona" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Bernadette", "Brakus" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Earl", "Beatty" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Ellis", false, "Heidenreich" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Marianne", "Olson" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Rickey", true, "Braun" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Irvin", true, "Jerde" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Caroline", "Hammes" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dale", "Bartoletti" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kathleen", "Nolan" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Geneva", "Blanda" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Loren", true, "Conn" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Shawna", "Haag" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Lucia", true, "Weimann" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Andy", "Grant" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Donna", "Frami" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Christina", false, "Osinski" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Estelle", "Pfannerstill" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Regina", false, "Klein" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Randall", "Thompson" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Bradley", "Treutel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Paul", "Hessel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Guillermo", "Stamm" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Gordon", "Dare" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Arlene", "Nienow" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Wallace", "Bartell" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rodolfo", "Greenholt" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Patrick", false, "Walker" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Connie", "Trantow" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Bridget", "Grady" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Tammy", false, "Bayer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Gertrude", "Bernhard" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Frances", "Kautzer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Saul", true, "Sanford" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Constance", "Brekke" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Patti", "Bailey" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Doreen", true, "Kling" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Latoya", "Bashirian" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Jody", false, "Lueilwitz" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Doug", "Carter" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Max", "Gaylord" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Elmer", true, "Gorczany" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Moses", "Runte" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Tommy", "Rath" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Elsa", "Towne" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Pam", true, "Pacocha" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ramon", "Lehner" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Beth", false, "McDermott" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Brenda", "Blick" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Margaret", true, "Windler" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Christina", "Lindgren" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Rogelio", true, "Murray" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Cecilia", "Mayer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Ignacio", true, "Auer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Roderick", true, "Nader" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Julian", false, "Lockman" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Stella", "Wehner" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Gregg", "Beer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kathy", "Kohler" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kristie", "Crooks" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Joseph", "Schneider" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Anna", "Keebler" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Chester", "Hamill" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Heidi", "Ankunding" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Marjorie", true, "Luettgen" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dean", "Hintz" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jessica", "McDermott" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Samantha", "Bogisich" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Brent", "Satterfield" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sonya", "Reichert" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Teri", "Zulauf" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Jessie", true, "O'Keefe" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Monica", "Abbott" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Nick", "Gorczany" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Alvin", "Jacobs" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Dan", false, "Strosin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Laura", "Trantow" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Eugene", false, "Kunde" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Jana", false, "Trantow" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Joseph", "Hickle" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Elsie", false, "Swift" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Cedric", "Cummerata" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Tina", false, "Lakin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Jeannette", false, "Goldner" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Clinton", "McDermott" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Felix", true, "Jacobs" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Willard", "Dach" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Willie", false, "Rowe" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Pesel",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Betsy", "Batz" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dianne", "Kihn" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Nathaniel", "Parker" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sally", "Bode" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Delores", "Kertzmann" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Donna", "Kuvalis" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Erick", true, "Prosacco" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jana", "Mertz" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Nathan", false, "Wisozk" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Moses", "Jast" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Bethany", "Goyette" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Larry", false, "Purdy" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ruben", "Herzog" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Alton", "Fahey" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Victor", "Reichel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Jamie", true, "Zemlak" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Bryant", "Nienow" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Sonja", false, "Huel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Stephanie", false, "Blanda" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Penny", "Von" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Agnes", "Gottlieb" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Erma", "Moen" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dwight", "Donnelly" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Bryan", false, "Jaskolski" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Lowell", "Bernhard" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Neal", false, "Bednar" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jason", "Deckow" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dustin", "Ward" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Eugene", true, "O'Connell" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jamie", "Simonis" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Rex", true, "Haag" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Penny", "Lakin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Lena", "Mann" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Eric", "Schultz" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Luther", "Satterfield" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Shaun", "Purdy" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Brenda", "Russel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jackie", "Kuhic" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rolando", "Steuber" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Paul", true, "Hansen" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "William", "Kutch" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Doreen", "Bogisich" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Ana", true, "Leffler" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Benjamin", "Cartwright" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Emmett", "Thiel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Tommy", false, "Bednar" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Marianne", "Considine" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Hector", "Johnston" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Sam", false, "Braun" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Beatrice", "Zulauf" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Corey", true, "Hartmann" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Shane", "Greenfelder" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Daryl", "Buckridge" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Pamela", false, "Langosh" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "George", "Klocko" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dixie", "Spencer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Daryl", "Mohr" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Ruth", false, "Brakus" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Elsa", "Heaney" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Mike", true, "Haley" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kathleen", "Kilback" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Marcella", false, "Smitham" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Bill", "Jacobi" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Lewis", false, "Marvin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Edgar", "Buckridge" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Kelley", false, "Bogisich" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Mathew", false, "Kunze" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Alton", true, "Smitham" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "May", "Hoppe" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Alex", "Gerhold" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Derrick", "Moen" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Shannon", "Blick" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sharon", "Ullrich" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dwayne", "Rippin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Lila", "Daniel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Katie", "Auer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Alfredo", false, "Jaskolski" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rene", "Heidenreich" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sonja", "Paucek" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Ross", "Watsica" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Lora", "Corwin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Naomi", "Kuhn" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kristi", "White" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Guillermo", false, "Ruecker" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Devin", "Schmidt" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sandra", "Von" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Rudolph", "Kuvalis" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Alma", true, "Metz" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Jack", "Donnelly" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Fannie", true, "Stiedemann" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Lindsay", true, "Lemke" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Preston", "Murazik" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Elena", true, "Trantow" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Kerry", "Littel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Jacquelyn", true, "Kiehn" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Leland", true, "Schuppe" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Sonya", "Abshire" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Marie", false, "Lindgren" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "FirstName", "LastName" },
                values: new object[] { "Dolores", "Volkman" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "FirstName", "IsDeleted", "LastName" },
                values: new object[] { "Patsy", true, "Hettinger" });
        }
    }
}
