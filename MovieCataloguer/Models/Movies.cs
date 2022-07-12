namespace MovieCataloguer.Models
{
    public class Movies
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }
        public string? Image { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

        // Default constructor
        public Movies()
        {

        }

    }
}
