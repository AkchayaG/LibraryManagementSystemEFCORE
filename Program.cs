using LibraryManagementSystemEFCORE.Services;

var service = new LibraryService();

// Testing ReturnBook
service.ReturnBook(1);

// Verify status change back to True
service.GetBookById(1);