// Oppgave 3

using Oppgave2;
using Oppgave3;

// E_bok bok1 = new E_bok("Sophies Verden", "Jostein Gaarder", "978-82-02-15968-7", 540, 5.5);
// Console.WriteLine(bok1.GetInfo());

#region Part C
Bok bok1 = new Bok("Markens Grøde", "Knut Hamsun", "978-82-02-20472-2", 350);
E_bok bok2 = new E_bok("Sophies Verden", "Jostein Gaarder", "978-82-02-15968-7", 540, 5.5);
E_bok bok3 = new E_bok("Ut å stjæle hester", "Per Petterson", "978-82-525-6348-2", 264, 4.4);
Bok bok4 = new Bok("De usynlige", "Roy Jacobsen", "978-82-02-42157-9", 272);
Bok bok5 = new Bok("Berlinerpoplene", "Anne B. Ragde", "978-82-05-36239-1", 272);
E_bok bok6 = new E_bok("Naiv. Super.", "Erlend Loe", "978-82-495-0014-1", 208, 3.5);
Bok bok7 = new Bok("Hundre år", "Herbjørg Wassmo", "978-82-02-19669-8", 400);
Bok bok8 = new Bok("Kongens Nei", "Alf R. Jacobsen", "978-82-02-48757-4", 320);
E_bok bok9 = new E_bok("Beatles", "Lars Saabye Christensen", "978-82-05-16317-4", 560, 6.8);
E_bok bok10 = new E_bok("Snømannen", "Jo Nesbø", "978-82-02-26753-8", 384, 5.2);

List<Bok> boks = [];
// boks.Add(new Bok("Markens Grøde", "Knut Hamsun", "978-82-02-20472-2", 350));
// boks.Add(new E_bok("Sophies Verden", "Jostein Gaarder", "978-82-02-15968-7", 540, 5.5));
// boks.Add(new E_bok("Ut å stjæle hester", "Per Petterson", "978-82-525-6348-2", 264, 4.4));
// boks.Add(new Bok("De usynlige", "Roy Jacobsen", "978-82-02-42157-9", 272));
// boks.Add(new Bok("Berlinerpoplene", "Anne B. Ragde", "978-82-05-36239-1", 272));
// boks.Add(new E_bok("Naiv. Super.", "Erlend Loe", "978-82-495-0014-1", 208, 3.5));
// boks.Add(new Bok("Hundre år", "Herbjørg Wassmo", "978-82-02-19669-8", 400));
// boks.Add(new Bok("Kongens Nei", "Alf R. Jacobsen", "978-82-02-48757-4", 320));
// boks.Add(new E_bok("Beatles", "Lars Saabye Christensen", "978-82-05-16317-4", 560, 6.8));
// boks.Add(new E_bok("Snømannen", "Jo Nesbø", "978-82-02-26753-8", 384, 5.2));
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


foreach (Bok book in boks)
{
    Console.WriteLine(book.GetInfo());
}
#endregion


#region Part D
Console.WriteLine($"\nBeregner total størrelsen for e-bøker i listen: \n" +
                  $"Total størrelsen for e-bøker i listen er: {CalculateSizeOfEBooks(boks)} MB");

double CalculateSizeOfEBooks(List<Bok> books)
{
    double size = 0d;
    foreach (Bok book in books)
    {
        // Adder FileSize til Size hvis boken er en E-bok.
        if (book is E_bok ebok) 
        {
            size += ebok.FileSize;
        }
    }
    return size;
}
#endregion