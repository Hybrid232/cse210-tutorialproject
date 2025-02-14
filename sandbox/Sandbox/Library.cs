using System.Diagnostics.Contracts;

public class Library
{
  private List<Book> _catalog;

  public Library()
  {
    _catalog = new List<Book>();

  }

  public void DisplayCatalog()
  {
    Console.WriteLine("The catalog is: ");

    foreach (Book b in _catalog)
    {
        b.Display();
    }
  }

    public void AddBook(Book theBook)
    {
        _catalog.Add(theBook);
    }

}