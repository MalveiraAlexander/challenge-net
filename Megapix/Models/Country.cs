namespace Megapix.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FlagImg { get; set; }
        public string? CapitalName { get; set; }
        public double? Area { get; set; }
        public int? PopulationCount { get; set; }
        public string? AllTimezones { get; set; }
        public string? ContinentName { get; set; }
        public float? Latitude { get; set; }
        public float? Longitude { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
