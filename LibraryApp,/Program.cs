using System;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Year { get; set; }

    // Конструктор с параметрами
    public Book(string title, string author, int year)
    {
        // Добавьте валидацию, если нужно
        if (string.IsNullOrWhiteSpace(title))
            throw new ArgumentException("Title cannot be empty");
        if (string.IsNullOrWhiteSpace(author))
            throw new ArgumentException("Author cannot be empty");
        if (year <= 0)
            throw new ArgumentException("Year must be positive");

        Title = title;
        Author = author;
        Year = year;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{Title} by {Author}, {Year}");
    }
}