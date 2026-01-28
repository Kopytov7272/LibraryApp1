using System;

namespace LibraryApp.Models
{
    public class Book
    {
        public string Title;
        public string Author;
        public int Year;

        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Год: {Year}");
        }
    }
}
