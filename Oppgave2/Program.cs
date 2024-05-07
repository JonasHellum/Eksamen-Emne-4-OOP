// Oppgave 2

using Oppgave2;

#region Part D
Bok bok1 = new Bok("Sult", "Knut Hamsun", "978-82-05-20472-2", 350);

Console.WriteLine($"Opprettet bok objekt: \n" +
                  $"{bok1.GetInfo()}");

Console.WriteLine();

bok1.IncreasePageCount(10);
Console.WriteLine(bok1.GetInfo());

Console.WriteLine();

bok1.DecreasePageCount(60);
Console.WriteLine(bok1.GetInfo());
#endregion