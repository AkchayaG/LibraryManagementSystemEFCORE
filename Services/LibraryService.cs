using LibraryManagementSystemEFCORE.Data;
using LibraryManagementSystemEFCORE.Models;

namespace LibraryManagementSystemEFCORE.Services
{
    public class LibraryService
    {
        private readonly LibraryContext _context;

        public LibraryService()
        {
            _context = new LibraryContext();
        }

        public void AddBook(string title, string author)
        {
            var book = new Book
            {
                Title = title,
                Author = author,
                IsAvailable = true
            };

            _context.Books.Add(book);
            _context.SaveChanges();
            Console.WriteLine($"Book '{title}' added successfully!");
        }
    }
}