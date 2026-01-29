using LibraryApp;
using System;

namespace LibraryApp.Models
{
    public class Book : LibraryItem, IBorrowable
    {
        public bool IsAvailable { get; set; } = true;
        public int Pages { get; set; }

        // Конструктор
        public Book(string title, string author, int year, int pages)
            : base(title, author, year)
        {
            Pages = pages;
        }

        // Переопределение метода DisplayInfo
        public override void DisplayInfo()
        {
            Console.WriteLine($"Книга: {Title} / {Author} ({Year}) — {Pages} страниц");
        }

        // Реализация интерфейса IBorrowable
        public void Borrow(string borrowerName)
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Книга '{Title}' выдана пользователю {borrowerName}");
            }
            else
            {
                Console.WriteLine($"Книга '{Title}' уже выдана");
            }
        }

        public void Return()
        {
            IsAvailable = true;
            Console.WriteLine($"Книга '{Title}' возвращена");
        }
    }
}