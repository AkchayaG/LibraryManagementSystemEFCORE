using LibraryManagementSystemEFCORE.Data;

using var context = new LibraryContext();
context.Database.EnsureCreated();

Console.WriteLine("Database created and connected successfully!");