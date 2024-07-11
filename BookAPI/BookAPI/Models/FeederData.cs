using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
    public static class FeederData
    {
        public static void Feeder(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Genre>().HasData(
                    new Genre { Id = "A", Name = "Fiction" },
                    new Genre { Id = "B", Name = "History" },
                    new Genre { Id = "C", Name = "Action and Adventure" },
                    new Genre { Id = "D", Name = "Casual" },
                    new Genre { Id = "E", Name = "Faith" });
            
            modelBuilder.Entity<Author>().HasData(
                    new Author { Id = 11, Name = "Sinjin Van Cleef" },
                    new Author { Id = 15, Name = "Roberts Liardon" },
                    new Author { Id = 29, Name = "Benjamin Hayes" },
                    new Author { Id = 2, Name = "Lucas Steele" },
                    new Author { Id = 13, Name = "Harper Quinn" },
                    new Author { Id = 12, Name = "Ava Jensen" },
                    new Author { Id = 34, Name = "Liam Montgomery" },
                    new Author { Id = 9, Name = "Nathan Wolfe" },
                    new Author { Id = 40, Name = "Sophia Blake" },
                    new Author { Id = 36, Name = "Evelyn Rivers" },
                    new Author { Id = 22, Name = "Isabella Hart" });

            modelBuilder.Entity<Book>().HasData(
                    new Book { Id = 1, GenreId = "A", AuthorId = 11, Name = "Arabian Nights", IsAvailable = true },
                    new Book { Id = 2, GenreId = "B", AuthorId = 13, Name = "Chronicles of the Ages", IsAvailable = true },
                    new Book { Id = 3, GenreId = "C", AuthorId = 9, Name = "Rogue Legacy", IsAvailable = true },
                    new Book { Id = 4, GenreId = "D", AuthorId = 40, Name = "Whispers in the Wind", IsAvailable = true },
                    new Book { Id = 5, GenreId = "E", AuthorId = 15, Name = "Path of Grace", IsAvailable = true },
                    new Book { Id = 6, GenreId = "A", AuthorId = 22, Name = "The Time Weaver", IsAvailable = true },
                    new Book { Id = 7, GenreId = "B", AuthorId = 12, Name = "Echoes of Antiquity", IsAvailable = true },
                    new Book { Id = 8, GenreId = "C", AuthorId = 29, Name = "Quest for the Lost City", IsAvailable = true },
                    new Book { Id = 9, GenreId = "D", AuthorId = 2, Name = "Coffee Shop Chronicles", IsAvailable = true },
                    new Book { Id = 10, GenreId = "E", AuthorId = 36, Name = "Miracles in the Making", IsAvailable = true },
                    new Book { Id = 11, GenreId = "A", AuthorId = 34, Name = "Illusions of Tomorrow", IsAvailable = true },
                    new Book { Id = 12, GenreId = "B", AuthorId = 15, Name = "Legacy of Empires", IsAvailable = true },
                    new Book { Id = 13, GenreId = "C", AuthorId = 9, Name = "Blades of Destiny", IsAvailable = true },
                    new Book { Id = 14, GenreId = "D", AuthorId = 34, Name = "The Cozy Corner", IsAvailable = true },
                    new Book { Id = 15, GenreId = "E", AuthorId = 36, Name = "The Divine Covenant", IsAvailable = true },
                    new Book { Id = 16, GenreId = "A", AuthorId = 11, Name = "Parallel Realms", IsAvailable = true },
                    new Book { Id = 17, GenreId = "B", AuthorId = 40, Name = "Threads of Civilization", IsAvailable = true },
                    new Book { Id = 18, GenreId = "C", AuthorId = 9, Name = "Storm Riders", IsAvailable = true },
                    new Book { Id = 19, GenreId = "D", AuthorId = 12, Name = "Gentle Waves", IsAvailable = true },
                    new Book { Id = 20, GenreId = "E", AuthorId = 15, Name = "Sacred Journeys", IsAvailable = true },
                    new Book { Id = 21, GenreId = "A", AuthorId = 29, Name = "Echoes of Eternity", IsAvailable = true },
                    new Book { Id = 22, GenreId = "B", AuthorId = 13, Name = "Footprints of the Ancients", IsAvailable = true },
                    new Book { Id = 23, GenreId = "C", AuthorId = 22, Name = "The Last Stand", IsAvailable = true },
                    new Book { Id = 24, GenreId = "D", AuthorId = 2, Name = "Lazy Afternoons", IsAvailable = true },
                    new Book { Id = 25, GenreId = "E", AuthorId = 15, Name = "Beyond Belief", IsAvailable = true },
                    new Book { Id = 26, GenreId = "A", AuthorId = 34, Name = "The Enigma Factor", IsAvailable = true },
                    new Book { Id = 27, GenreId = "B", AuthorId = 36, Name = "The Forgotten Era", IsAvailable = true },
                    new Book { Id = 28, GenreId = "C", AuthorId = 15, Name = "Shadows of Valor", IsAvailable = true },
                    new Book { Id = 29, GenreId = "D", AuthorId = 9, Name = "Summer Escapes", IsAvailable = true },
                    new Book { Id = 30, GenreId = "E", AuthorId = 11, Name = "Sanctuary of Hope", IsAvailable = true });


        
        
        }
    }
}
