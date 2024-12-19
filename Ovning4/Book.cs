using System;

namespace Ovning4;

class Book
{
    // Privata variabler
    private string name;
    private int pages;
    private int currentPage;

    // Konstruktor
    public Book(string n, int p)
    {
        name = n;
        pages = p;
        currentPage = 0; // Börjar på 0
    }

    // Metod för att hämta bokens namn
    public string GetName()
    {
        return name;
    }

    // Metod för att hämta bokens sidantal
    public int GetPages()
    {
        return pages;
    }

    // Metod för att öka currentPage
    public void TurnPage()
    {
        if (currentPage < pages)
        {
            currentPage++;
        }
        else
        {
            Console.WriteLine("Du är redan på sista sidan!");
        }
    }

    // Metod för att hämta värdet på currentPage
    public int GetCurrentPage()
    {
        return currentPage;
    }
}

class Program
{
    static void Main()
    {
        // Skapa tre instanser av Book
        Book book1 = new Book("Bok 1", 100);
        Book book2 = new Book("Bok 2", 200);
        Book book3 = new Book("Bok 3", 150);

        // Testa GetName och GetPages
        Console.WriteLine($"Bokens namn: {book1.GetName()}, Sidantal: {book1.GetPages()}");
        Console.WriteLine($"Bokens namn: {book2.GetName()}, Sidantal: {book2.GetPages()}");
        Console.WriteLine($"Bokens namn: {book3.GetName()}, Sidantal: {book3.GetPages()}");

        // Testa TurnPage och GetCurrentPage
        Console.WriteLine($"{book1.GetName()} - Current Page: {book1.GetCurrentPage()}");
        book1.TurnPage();
        Console.WriteLine($"{book1.GetName()} - Current Page after turning a page: {book1.GetCurrentPage()}");
    }
}   