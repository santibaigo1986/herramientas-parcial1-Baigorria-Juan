namespace BaigorriaJuan.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublicationYear { get; set; }
        public string Genre { get; set; }
        public bool IsBestSeller { get; set; }
        public decimal Price { get; set; }
        public string Author { get; set; }
        public string CoverImage { get; set; }

        public int? PublisherId { get; set; }

        public virtual Publisher Publisher { get; set; }
    }
}
