using Microsoft.EntityFrameworkCore.Migrations;

namespace ParksLookup.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Address", "Agency", "Campsites", "Description", "Name", "State" },
                values: new object[,]
                {
                    { 1, "1 Zion Park Blvd,State Route 9,Springdale, UT 84767.", "National Park Service", true, "Located in southern Utah near the city of Springdale. The park provides access to varied hiking, canyoneering, and water adventures.", "Zion", "Utah" },
                    { 2, "Grand Canyon, AZ 86023", "National Park Service", true, "Truly grand: a steep-sided canyon carved by the Colorado River. The Grand Canyon features layered bands of red rock revealing millions of years of geological history. Viewpoints include Mather Point, Yavapai Observation Station and architect Mary Colter’s Lookout Studio and her Desert View Watchtower.", "Grand Canyon", "Arizona" },
                    { 3, "1675 Peter Iredale Rd, Hammond, OR 97121", "Oregon State Parks", true, "Formerly the primary military defense  installation in the three-fort, Harbor Defense System at the mouth of the Columbia River. Now, Fort Stevens is a 4,300-acre park offering a variety of recreational opportunities, including camping, beach-combing, freshwater lake swimming, hiking trails, wildlife viewing and a historic shipwreck.", "Fort Stevens State Park", "Oregon" },
                    { 4, "Oregon 97750", "National Park Service", false, "Part of the John Day Fossil Beds. The painted hills are located about 9 miles northwest of Mitchell, Oregon and distinguished by their stripes of red, tan, orange, and black. If you visit, stay off the dirt to help preserve the monument!", "Painted Hills", "Oregon" },
                    { 5, "3572 Olga Rd, Olga, WA 98279", "Washington State Parks", true, "Public recreation area on Orcas Island in Puget Sound's San Juan Islands. This 5,424-acre park offers abundant camping (151 sites), five freshwater lakes for swimming and non-motorized boating, and more than 30 miles of hiking, bicycling, mountain biking and equestrian trails.", "Moran State Park", "Washington" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 5);
        }
    }
}
