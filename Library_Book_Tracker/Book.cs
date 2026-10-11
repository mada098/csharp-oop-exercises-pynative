namespace Library_Book_Tracker;

public class Book
{
    private string _title;
    private string _author;
    private string _isbn;

    public Book(string title = "Unknown Title", string author = "Unknown Author", string isbn = "N/A")
    {
        _title = title;
        _author = author;
        _isbn = isbn;
    }

    public void DisplayBookInfo()
    {
        Console.WriteLine($"Title: {_title},  Author: {_author}, ISBN: {_isbn}");
    }
}