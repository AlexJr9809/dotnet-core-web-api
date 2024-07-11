namespace BookAPI.Models
{
    public class Genre
    {
        public string Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<Book> Books { get; set; }



    }
}
