// Oppgave 4
using Bok_Interface;
using Oppgave2;

#region Part D
Bok bok1 = new Bok("Markens Grøde", "Knut Hamsun", "978-82-02-20472-2", 350);
Bok bok2 = new Bok("Sophies Verden", "Jostein Gaarder", "978-82-02-15968-7", 540);
Bok bok3 = new Bok("Ut å stjæle hester", "Per Petterson", "978-82-525-6348-2", 264);
Bok bok4 = new Bok("De usynlige", "Roy Jacobsen", "978-82-02-42157-9", 272);
Bok bok5 = new Bok("Berlinerpoplene", "Anne B. Ragde", "978-82-05-36239-1", 272);
Bok bok6 = new Bok("Naiv. Super.", "Erlend Loe", "978-82-495-0014-1", 208);
Bok bok7 = new Bok("Hundre år", "Herbjørg Wassmo", "978-82-02-19669-8", 400);
Bok bok8 = new Bok("Kongens Nei", "Alf R. Jacobsen", "978-82-02-48757-4", 320);
Bok bok9 = new Bok("Beatles", "Lars Saabye Christensen", "978-82-05-16317-4", 560);
Bok bok10 = new Bok("Snømannen", "Jo Nesbø", "978-82-02-26753-8", 384);

List<IFormatable> boks = [];
boks.Add(bok1);
boks.Add(bok2);
boks.Add(bok3);
boks.Add(bok4);
boks.Add(bok5);
boks.Add(bok6);
boks.Add(bok7);
boks.Add(bok8);
boks.Add(bok9);
boks.Add(bok10);

ExportToCSV(boks, "book.csv");
#endregion

#region Part C
bool ExportToCSV(List<IFormatable> objects, string fileName) 
    // Ser at formateringen i eksempelet er annerledes enn alt annet av CSV jeg har sett så endret
    // formateringen til vanlig CSV format.
{
    var header = "\"ISBN\",\"Title\",\"Author\",\"PageCount\"";
    Console.WriteLine("Skriver ut opprettet objekter i CSV format til consolen.\n");
    Console.WriteLine(header);
    foreach (IFormatable objectt in objects)
    {
        Console.WriteLine(objectt.ToCSV());
    }
    
    Console.WriteLine($"\nSkriver objektene i csv format til fil: {fileName}");
    try
    {
        var lines = objects.Select(i => i.ToCSV());
        // Legger til header inn i CSV filen i tillegg til å legge inn objektene.
        File.WriteAllLines(fileName, new[] {header}.Concat(lines), System.Text.Encoding.UTF8);
        Console.WriteLine($"Suksess: CSV fil lagret -> '{fileName}'");
        return true;
    }
    catch (Exception e)
    {
        Console.WriteLine($"Feil: CSV fil er ikke lagret: {e.Message}");
        return false;
    }
}
#endregion