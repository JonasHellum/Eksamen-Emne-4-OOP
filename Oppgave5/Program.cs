using Oppgave5;
// Filen ligger i prosjektet og blir automatisk kopiert til output slik at den kan brukes bare på filnavn!

#region Part C
string fileName = "cars.csv";
List<Car> cars = CarService.GetCarsFromCsv(fileName);

Console.WriteLine("1: Skriv ut alle biler fra og med årsmodell 2020 og nyere.");
foreach (Car car in cars
             .Where(c => c.Year >= 2020))
{
    Console.WriteLine(car);
}

Console.WriteLine("\n2: Skriv ut alle biler som har en kilometer stand mindre enn 20000km");
foreach (Car car in cars.Where(c => c.Milage < 20000))
{
    Console.WriteLine(car);
}

Console.WriteLine("\n3: Skriv ut alle biler som har gått mindre enn 30000 km og koster mindre enn 100000 kroner.");
foreach (Car car in cars.Where(c => c is { Milage: < 30000, Price: < 100000 }))
{
    Console.WriteLine(car);
}
#endregion