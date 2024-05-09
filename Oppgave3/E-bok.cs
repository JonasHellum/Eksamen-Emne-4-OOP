namespace Oppgave3;

public class E_bok : Bok
{
    #region Part A
    public double FileSize { get; set; }
    public E_bok(string title, string author, string iSBN, int pageNumber, double fileSize) : base(title, author, iSBN, pageNumber)
    {
        this.FileSize = fileSize;
    }
    #endregion
    
    #region Part B
    public override string GetInfo()
    {
        return base.GetInfo() + $", FileSize: {FileSize}";
    }
    #endregion
}