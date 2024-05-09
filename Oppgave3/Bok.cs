namespace Oppgave3;

public class Bok
{
    #region Part A
    private int _pageCount;
    public string ISBN { get; init; }
    public string Title { get; set; }
    public string Author { get; set; }
    public int PageNumber 
    { 
        get
        {
            return _pageCount;
        } 
    }
    #endregion

    #region Part B
    public bool IncreasePageCount(int numberOfPages)
    {
        Console.WriteLine($"Prøver å øke antall sider med {numberOfPages}");
        
        if (numberOfPages <= 0)
        {
            Console.WriteLine($"Kan ikke øke antall sider med negativt nummer eller 0");
            return false;
        }
        
        _pageCount += numberOfPages;
        return true;
    }

    public bool DecreasePageCount(int numberOfPages)
    {
        Console.WriteLine($"Prøver å redusere antall sider med {numberOfPages}");

        if (numberOfPages <= 0 || numberOfPages > _pageCount)
        {
            Console.WriteLine($"Kan ikke redusere antall sider med negativt nummer, " +
                              $"flere sider enn total antall sider eller 0");
            return false;
        }

        _pageCount -= numberOfPages;
        return true;
    }

    public virtual string GetInfo()
    {
        return $"Title: {Title}, Author: {Author}, ISBN: {ISBN}, PageCount: {PageNumber}";
    }
    #endregion

    #region Part C
    public Bok(string title, string author, string iSBN, int pageNumber)
    {
        this.Title = title;
        this.Author = author;
        this.ISBN = iSBN;
        this._pageCount = pageNumber;
    }
    #endregion
}