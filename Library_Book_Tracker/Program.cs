using Library_Book_Tracker;

var book1 = new Book();
var book2 = new Book("1984", "George Orwell");
var book3 = new Book("Dune", "Frank Herbert", "978-0441172719");

book1.DisplayBookInfo();
book2.DisplayBookInfo();
book3.DisplayBookInfo();