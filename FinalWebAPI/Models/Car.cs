namespace FinalWebAPI.Models
{
    public class Car
    {
        public int CarId { get; set; }

        public string VIN { get; set; } = "";

        public string Brand { get; set; } = "";

        public string Model { get; set; } = "";

        public int Year { get; set; }

        public int Milage { get; set; }
    }
}
