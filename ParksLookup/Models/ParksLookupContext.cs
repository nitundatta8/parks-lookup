using Microsoft.EntityFrameworkCore;


namespace ParksLookup.Models
{
  public class ParksLookupContext : DbContext
  {
    public ParksLookupContext(DbContextOptions<ParksLookupContext> options)
        : base(options)
    {
    }

    public DbSet<Park> Parks { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Park>()
          .HasData(
            new Park
            {
              ParkId = 1,
              Name = "Zion",
              State = "Utah",
              Agency = "National Park Service",
              Address = "1 Zion Park Blvd,State Route 9,Springdale, UT 84767.",
              Description = "Located in southern Utah near the city of Springdale. The park provides access to varied hiking, canyoneering, and water adventures.",
              Campsites = true
            },
            new Park
            {
              ParkId = 2,
              Name = "Grand Canyon",
              State = "Arizona",
              Agency = "National Park Service",
              Address = "Grand Canyon, AZ 86023",
              Description = "Truly grand: a steep-sided canyon carved by the Colorado River. The Grand Canyon features layered bands of red rock revealing millions of years of geological history. Viewpoints include Mather Point, Yavapai Observation Station and architect Mary Colter’s Lookout Studio and her Desert View Watchtower.",
              Campsites = true
            },
            new Park
            {
              ParkId = 3,
              Name = "Fort Stevens State Park",
              State = "Oregon",
              Agency = "Oregon State Parks",
              Address = "1675 Peter Iredale Rd, Hammond, OR 97121",
              Description = "Formerly the primary military defense  installation in the three-fort, Harbor Defense System at the mouth of the Columbia River. Now, Fort Stevens is a 4,300-acre park offering a variety of recreational opportunities, including camping, beach-combing, freshwater lake swimming, hiking trails, wildlife viewing and a historic shipwreck.",
              Campsites = true
            },
            new Park
            {
              ParkId = 4,
              Name = "Painted Hills",
              State = "Oregon",
              Agency = "National Park Service",
              Address = "Oregon 97750",
              Description = "Part of the John Day Fossil Beds. The painted hills are located about 9 miles northwest of Mitchell, Oregon and distinguished by their stripes of red, tan, orange, and black. If you visit, stay off the dirt to help preserve the monument!",
              Campsites = false
            },
            new Park
            {
              ParkId = 5,
              Name = "Moran State Park",
              State = "Washington",
              Agency = "Washington State Parks",
              Address = "3572 Olga Rd, Olga, WA 98279",
              Description = "Public recreation area on Orcas Island in Puget Sound's San Juan Islands. This 5,424-acre park offers abundant camping (151 sites), five freshwater lakes for swimming and non-motorized boating, and more than 30 miles of hiking, bicycling, mountain biking and equestrian trails.",
              Campsites = true
            }


          );
    }
  }
}