namespace WebApplication3.Models
{
    public struct Contact
    {
        public string Email { get; set; }
    }

    public class Country
    {
        public string Name { get; set; }
        public string Capital { get; set; }
        public double Gdp { get; set; }
        public long Population { get; set; }
        public string Continent { get; set; }
    }
}
