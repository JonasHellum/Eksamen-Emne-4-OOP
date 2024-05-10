namespace Oppgave5;

public class CarService
{
    public static List<Car> GetCarsFromCsv(string cvsFile)
    {
        #region Part B
        
        if (!File.Exists(cvsFile)) 
        {
            throw new FileNotFoundException("CSV fil ikke funnet.", cvsFile);
        }
        
        StreamReader sr = new StreamReader(cvsFile);
        List<Car> cars = new List<Car>();
        int lineNr = 0;
        
        sr.ReadLine();
        lineNr++;
        
        using (sr)
        {
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] values = line.Split(',');
                
                if (values.Length != 5)
                {
                    Console.WriteLine($"Feil på linje: {lineNr + 1}: Ugyldig format.");
                }

                string model = values[0];
                string color = values[2];
                int year = 0;
                int milage = 0;
                decimal price = 0;
                bool parseError = false;
                
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