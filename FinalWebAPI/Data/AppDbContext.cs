using Microsoft.EntityFrameworkCore;
using FinalWebAPI.Models;

namespace FinalWebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Candle> Candles { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<Animal> Animals { get; set; }

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
                    CandleId = 4,
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

            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    CarId = 1,
                    VIN = "1FTFW1C85MKF12816",
                    Brand = "Ford",
                    Model = "F-150",
                    Year = 2021,
                    Milage = 65000
                },
                new Car
                {
                    CarId = 2,
                    VIN = "WVWJL9AN8AE059036",
                    Brand = "Volkswagen",
                    Model = "Passat",
                    Year = 2010,
                    Milage = 325356
                },
                new Car
                {
                    CarId = 3,
                    VIN = "1G8ZF5284YZ202749",
                    Brand = "Saturn",
                    Model = "SL",
                    Year = 2000,
                    Milage = 426965
                },
                new Car
                {
                    CarId = 4,
                    VIN = "2A8GF68X88R144021",
                    Brand = "Chrysler",
                    Model = "Pacifica",
                    Year = 2008,
                    Milage = 183260
                },
                new Car
                {
                    CarId = 5,
                    VIN = "WP0AG2A9XPS252314",
                    Brand = "Porsche",
                    Model = "911",
                    Year = 2023,
                    Milage = 54721
                }
            );

            modelBuilder.Entity<Animal>().HasData(
                new Animal
                {
                    AnimalId = 1,
                    Name = "Lisa",
                    Species = "Cow",
                    Age = 5,
                    Gender = "Female",
                    FavoriteFood = "Grain"
                },
                new Animal
                {
                    AnimalId = 2,
                    Name = "Larry",
                    Species = "Goat",
                    Age = 3,
                    Gender = "Male",
                    FavoriteFood = "Grass"
                },
                new Animal
                {
                    AnimalId = 3,
                    Name = "Gold Ship",
                    Species = "Horse",
                    Age = 17,
                    Gender = "Male",
                    FavoriteFood = "Hay"
                },
                new Animal
                {
                    AnimalId = 4,
                    Name = "Bugs",
                    Species = "Bunny",
                    Age = 30,
                    Gender = "Male",
                    FavoriteFood = "Carrots"
                },
                new Animal
                {
                    AnimalId = 5,
                    Name = "John Pork",
                    Species = "Pig",
                    Age = 5,
                    Gender = "Male",
                    FavoriteFood = "Stuff"
                }
            );
        }
    }
}
