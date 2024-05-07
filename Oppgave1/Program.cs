// Tips: Legg gjerne funksjoner som brukes nederst i denne filen!

#region Part A
// Oppgave 1A
Console.WriteLine("Oppgave 1A");
// ... oppgave A her 
int tallInt = 20;
float saldo = 2500.50f;
double pI = 3.14159d;
char karakter = 'A';
bool sant = true;
string brukerNavn = "User123";

Console.WriteLine($"Karakter: {karakter}, Type: {karakter.GetType()}");
Console.WriteLine($"Saldo: {saldo}, Type: {saldo.GetType()}");
Console.WriteLine($"logged in: {sant}, Type: {sant.GetType()}");
Console.WriteLine($"UserName: {brukerNavn}, Type: {brukerNavn.GetType()}");
Console.WriteLine($"PI: {pI}, Type: {pI.GetType()}");
Console.WriteLine($"tall: {tallInt}, Type: {tallInt.GetType()}");
#endregion

#region Part B
// Oppgave 1B
Console.WriteLine("\nOppgave 1B");
// ... oppgave B her 
Console.Write("Skriv inn en setning: ");
string input = Console.ReadLine();
Console.WriteLine($"Antall ord i setningen er: {input.Split(' ',
                                                StringSplitOptions.RemoveEmptyEntries).Length}");
#endregion

#region Part C
// Oppgave 1C
Console.WriteLine("\nOppgave 1C");
// ... oppgave C her 
Console.WriteLine("Reversert setning: ");
Console.WriteLine(ReverseString(input));
#endregion

#region Part D
// Oppgave 1D
Console.WriteLine("\nOppgave 1D");
// ... oppgave D her 
double[] tallArray = new[]
{
    1.4d,
    5.7d,
    65.34d,
    23.12d,
    98.43d
};

foreach (double tall in tallArray)
{
    Console.WriteLine(tall);
}
#endregion

#region Part E
// Oppgave 1E
Console.WriteLine("\nOppgave 1E");
// ... oppgave E her 
Console.WriteLine($"Summen av tallene i arrayet er: {CalculateSum(tallArray)}");
#endregion

// Funksjoner kan defineres her 
// ... funksjoner ...

#region Function for part C
// For oppgave 1C
static string ReverseString(string input)
{
    input = new string(input.Reverse().ToArray());
    return input;
}
#endregion

#region Function for part E
// For oppgave 1E
static double CalculateSum(double[] arr)
{
    double sum = 0;
    foreach (double num in arr)
    {
        sum += num;
    }

    return sum;
}
#endregion