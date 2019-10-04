namespace SimplBlazor.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
        public string Thumbnail { get; set; }
        public string Image { get; set; } // just a demo so don't blame it :)
        public decimal Price { get; set; }
        public decimal? OldPrice { get; set; }
        public string Specification { get; set; }
        public string Details { get; set; }
        public int Rating { get; set; }
    }
}
