using Microsoft.EntityFrameworkCore;
using FinalWebAPI.Models;

namespace FinalWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Candle> Candles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember
                {
                    TeamMemberId = 1,
                    FullName = "Maria Smith",
                    Birthdate = new DateTime(2005, 1, 4),
                    CollegeProgram = "Software Application Development",
                    YearInProgram = "Pre-Junior"
                },
                new TeamMember
                {
                    TeamMemberId = 2,
                    FullName = "Reese Howard",
                    Birthdate = new DateTime(2004, 3, 18),
                    CollegeProgram = "Chemical Engineering",
                    YearInProgram = "Pre-Junior"
                },
                new TeamMember
                {
                    TeamMemberId = 3,
                    FullName = "Lauren Riihimaki",
                    Birthdate = new DateTime(2002, 7, 7),
                    CollegeProgram = "Nursing",
                    YearInProgram = "Senior"
                },
                new TeamMember
                {
                    TeamMemberId = 4,
                    FullName = "Peter McWallen",
                    Birthdate = new DateTime(2006, 12, 25),
                    CollegeProgram = "Music Education",
                    YearInProgram = "Sophomore"
                },
                new TeamMember
                {
                    TeamMemberId = 5,
                    FullName = "Ryan Faulkner",
                    Birthdate = new DateTime(2007, 9, 21),
                    CollegeProgram = "English Literature",
                    YearInProgram = "Freshman"
                }
            );

            modelBuilder.Entity<Candle>().HasData(
                new Candle
                {
                    CandleId = 1,
                    Name = "Vanilla Cupcake",
                    Description = "Sweet and spicy fragrance reminiscent of a day of baking.",
                    Brand = "Yankee Candle",
                    FragranceNotes = "vanilla bean, chocolate, cocoa, malted sugar"
                },
                new Candle
                {
                    CandleId = 2,
                    Name = "Seaside Woods",
                    Description = "Experience a cozy, secluded coastal escape.",
                    Brand = "Yankee Candle",
                    FragranceNotes = "cottonwood, driftwood, orange blossoms, acacia"
                },
                new Candle
                {
                    CandleId = 3,
                    Name = "Homemade Sourdough",
                    Description = "You'll enjoy every bit of this savory, fresh-from-the-oven fragrance—no starter needed.",
                    Brand = "Bath and Body Works",
                    FragranceNotes = "baked sourdough, whipped butter, olive oil drizzle"
                }, 
                new Candle
                {
                    CandleId= 4,
                    Name = "Mahogany Teakwood",
                    Description = "Woodsy, mysterious home fragrance turned rich, refined fragrance icon.",
                    Brand = "Bath and Body Works",
                    FragranceNotes = "rich mahogany, black teakwood, dark oak, lavender"
                },
                new Candle
                {
                    CandleId = 5,
                    Name = "Strawberry Swirl",
                    Description = "As you step into your favorite bakery, scents of fresh Gariguette strawberries topped with vanilla essence and Chantilly cream flood the room.",
                    Brand = "Yankee Candle",
                    FragranceNotes = "strawberry, lemon zest, cake batter, vanilla, white musk, baked notes"
                }
            );
        }
    }
}
