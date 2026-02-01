using System;
using System.Collections.Generic;
using System.Linq;
using LibraryApp.Models;
namespace LibraryApp.Services
{
    public class Library
    {
        private readonly List<LibraryItem> _items = new();

        public void AddItem(LibraryItem item) => _items.Add(item);

        public List<LibraryItem> GetAllItems() => new(_items);

        public List<Book> GetBooksByAuthor(string author)
        {
            return _items
                .OfType<Book>()
                .Where(b => b.Author != null && b.Author.IndexOf(author, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
        }

        public List<string> GetModernBookTitles(int yearThreshold = 2000)
        {
            return _items
                .OfType<Book>()
                .Where(b => b.Year > yearThreshold)
                .Select(b => b.Title)
                .ToList();
        }

        internal void BorrowItem(object item, string v)
        {
            throw new NotImplementedException();
        }

        internal IEnumerable<object> FindByAuthor(string author)
        {
            throw new NotImplementedException();
        }

        internal object FindItemByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}