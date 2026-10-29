using LibraryManagementSystemEFCORE.Services;

var service = new LibraryService();

// Testing AddBook method
service.AddBook("Clean Code", "Robert C. Martin");
service.AddBook("The Pragmatic Programmer", "Andrew Hunt");