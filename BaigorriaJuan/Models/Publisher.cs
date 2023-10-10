namespace BaigorriaJuan.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Navigation property
        public ICollection<Book> Books { get; set; }
    }
}
