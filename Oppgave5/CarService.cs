namespace Oppgave5;

public class CarService
{
    public static List<Car> GetCarsFromCsv(string cvsFile)
    {
        #region Part B
        
        if (!File.Exists(cvsFile)) 
        {
            Console.WriteLine($"CSV fil ikke funnet. \"{cvsFile}\"");
            return null;
        }
        
        StreamReader sr = new StreamReader(cvsFile);
        List<Car> cars = new List<Car>();
        int lineNr = 0;
        
        // For å ignorere header linjen.
        sr.ReadLine();
        lineNr++;
        
        using (sr)
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split(',');
                string[] columns = { "Model", "Year", "Color", "Milage", "Price" };
                
                string model = values[0];
                string color = values[2];
                int year = 0;
                int milage = 0;
                decimal price = 0;
                
                // For at objektene som det er feil i ikke skal lagre seg men at den
                // fortsatt skal gå gjennom alle parsene for å gi tilbakemelding på alt.
                bool parseError = false;
                
                if (values.Length != 5) // Sjekker at formatet er riktig.
                {
                    Console.WriteLine($"Feil på linje: {lineNr + 1}: Ugyldig format.");
                    parseError = true;
                }
                
                for (int i = 0; i < values.Length; i++) // Sjekker at det er data i hver kolonne.
                {
                    if (string.IsNullOrWhiteSpace(values[i]))
                    {
                        Console.WriteLine($"Feil på linje: {lineNr + 1}: Kolonne {columns[i]} mangler data.");
                        parseError = true;
                    }
                }
                
                // Laget flere try/catch for å kunne fange opp og komme
                // med riktig kommentar til hvor feilen er.
                try
                {
                    year = int.Parse(values[1]);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Feil i \"Year\" kolonne på linje: {lineNr + 1}: {e.Message}");
                    parseError = true;
                }

                try
                {
                    milage = int.Parse(values[3]);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Feil i \"Milage\" kolonne på linje: {lineNr + 1}: {e.Message}");
                    parseError = true;
                }

                try
                {
                    price = decimal.Parse(values[4]);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Feil i \"Price\" kolonne på linje: {lineNr + 1}: {e.Message}");
                    parseError = true;
                }

                // Hvis det ikke er noen feil så lagres objektet til en liste.
                if (!parseError)
                {
                    Car car = new Car(model, year, color, milage, price);
                    cars.Add(car);
                }
                
                lineNr++;
            }
        }

        return cars;
        #endregion
    }
}