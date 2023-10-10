namespace BaigorriaJuan.Models
{
    public class Publisher
{
    public int Id { get; set; }
    public string Name { get; set; }
    
    // Navigation property
    public ICollection<Book> Books { get; set; }

    public Publisher()
    {
        // Constructor vacío requerido para Entity Framework
        Books = new List<Book>();
    }

    public Publisher(string name)
    {
        Name = name;
        Books = new List<Book>();
    }
}

}
