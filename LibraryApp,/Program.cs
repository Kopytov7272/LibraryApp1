using LibraryApp.Models;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Book myBook = new Book();
            myBook.Title = "1984";
            myBook.Author = "Джордж Оруэлл";
            myBook.Year = 1949;
            myBook.DisplayInfo();
        }
    }
}
