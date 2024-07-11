
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BookAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;

        public bool IsAvailable { get; set; }

        public string GenreId { get; set; }
        [ForeignKey("GenreId")]

        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]

        [JsonIgnore]
        public virtual Genre? gnr { get; set; }

        [JsonIgnore]
        public virtual Author? auth { get; set; }

    }
}
