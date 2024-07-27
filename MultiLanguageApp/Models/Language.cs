namespace MultiLanguageApp.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UsedInCountry { get; set; }
        public int Lifetime { get; set; }
        public string Continent { get; set; }
    }
}
