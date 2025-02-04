﻿namespace BookAPI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public virtual List<Book> Books { get; set; }
    }
}
