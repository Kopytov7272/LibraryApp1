using System;
using System.Collections.Generic;
using LibraryApp.Models;

class Program
{
    static void Main()
    {
        var items = new List<LibraryItem>
        {
            new Book("1984", "Оруэлл", 1949, 328),
            new Magazine("Science", "Редколлегия", 2023, 5),
            new Book("Анна Каренина", "Толстой", 1877, 850)
        };

        foreach (var item in items)
        {
            item.DisplayInfo();
        }
    

var book = new Book("1984", "Оруэлл", 1949, 328);
IBorrowable borrowable = book;

borrowable.Borrow("Анна");
borrowable.Borrow("Иван"); // попытка повторного взятия
borrowable.Return();
    }
}