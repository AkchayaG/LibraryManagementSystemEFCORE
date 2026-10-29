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
        public void GetAllBooks()
        {
            var books = _context.Books.ToList();

            Console.WriteLine("\n--- Library Books List ---");
            if (!books.Any())
            {
                Console.WriteLine("No books found in the library.");
                return;
            }

            foreach (var book in books)
            {
                Console.WriteLine($"ID: {book.Id} | Title: {book.Title} | Author: {book.Author} | Available: {book.IsAvailable}");
            }

        }
    }
}