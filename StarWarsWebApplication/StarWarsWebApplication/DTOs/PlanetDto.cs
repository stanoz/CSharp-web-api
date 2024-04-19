namespace StarWarsWebApplication.DTOs
{
    public class PlanetDto
    {
        public string Name { get; set; } = string.Empty;
        public int Diameter { get; set; }
        public int RotationPeriod { get; set; }
        public int OrbitalPeriod { get; set; }
        public int Gravity { get; set; }
        public int Population { get; set; }
        public IEnumerable<string>? Climate { get; set; }
        public IEnumerable<string>? Terrain { get; set; }
    }
}
