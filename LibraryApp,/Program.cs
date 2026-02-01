using System;
using System.Linq;
using LibraryApp.Models;
using LibraryApp.Services;

var library = new Library();
bool running = true;

while (running)
{
    Console.Clear();
    Console.WriteLine("=== Библиотека ===");
    Console.WriteLine("1. Добавить книгу");
    Console.WriteLine("2. Добавить журнал");
    Console.WriteLine("3. Показать все");
    Console.WriteLine("4. Поиск по автору");
    Console.WriteLine("5. Выдать книгу");
    Console.WriteLine("0. Выход");
    Console.Write("Выбор: ");

    string choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            AddBook(library); break;
        case "2":
            AddMagazine(library); break;
        case "3":
            ShowAll(library); break;
        case "4":
            SearchByAuthor(library); break;
        case "5":
            BorrowBook(library); break;
        case "0":
            running = false; break;
        default:
            Console.WriteLine("Неверный выбор. Нажмите любую клавишу..."); Console.ReadKey(); break;
    }
}

static void AddBook(Library library)
{
    try
    {
        Console.Write("Название: "); string title = Console.ReadLine();
        Console.Write("Автор: "); string author = Console.ReadLine();
        Console.Write("Год: "); int year = int.Parse(Console.ReadLine());
        Console.Write("Страницы: "); int pages = int.Parse(Console.ReadLine());
        library.AddItem(new Book(title, author, year, pages));
        Console.WriteLine("Книга добавлена!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    Console.ReadKey();
}

static void AddMagazine(Library library)
{
    try
    {
        Console.Write("Название: "); string title = Console.ReadLine();
        Console.Write("Автор: "); string author = Console.ReadLine();
        Console.Write("Год: "); int year = int.Parse(Console.ReadLine());
        Console.Write("Выпуск: "); int issueNumber = int.Parse(Console.ReadLine());
        library.AddItem(new Magazine(title, author, year, issueNumber));
        Console.WriteLine("Журнал добавлен!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    Console.ReadKey();
}

static void ShowAll(Library library)
{
    try
    {
        var result = library.GetAllItems();

        if (result.Count == 0)
        {
            Console.WriteLine("Ничего не найдено.");
        }
        else
        {
            foreach (var item in result)
            {
                item.DisplayInfo();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    Console.ReadKey();
}

static void SearchByAuthor(Library library)
{
    try
    {
        Console.Write("Введите автора: "); string author = Console.ReadLine();
        var result = library.GetBooksByAuthor(author);

        if (result.Count == 0)
        {
            Console.WriteLine("Ничего не найдено.");
        }
        else
        {
            foreach (var item in result)
            {
                item.DisplayInfo();
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    Console.ReadKey();
}

static void BorrowBook(Library library)
{
    try
    {
        Console.Write("Введите название книги: "); string title = Console.ReadLine();

        var book = library.GetAllItems()
            .OfType<Book>()
            .FirstOrDefault(b => b.Title.Equals(title));

        book.Borrow("Пользователь");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Ошибка: {ex.Message}");
    }
    Console.ReadKey();
}