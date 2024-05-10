namespace Oppgave5;

public class Car
{
    #region Part A
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Milage { get; set; }
    public decimal Price { get; set; }

    public Car(string model, int year, string color, int milage, decimal price)
    {
        this.Model = model;
        this.Year = year;
        this.Color = color;
        this.Milage = milage;
        this.Price = price;
    }

    public override string ToString()
    {
        return $"Model: {Model}, Year: {Year}, Color: {Color}, Milage: {Milage}, Price: {Price}";
    }
    #endregion
}