// See https://aka.ms/new-console-template for more information
Random random= new Random();
int[] poleCisel=new int[100];
for (int i = 0; i < 100; i++)
{
    poleCisel[i] = random.Next(0,100);
}

var zgrupovaneCisla = poleCisel.GroupBy(x=>x);
foreach(var item in zgrupovaneCisla)
{
    Console.WriteLine(item.Key + " " + item.Count());
}
Console.WriteLine("Prumer: " + poleCisel.Average());
Console.WriteLine("Minimum: " + poleCisel.Min());
Console.WriteLine("Maximum: " + poleCisel.Max());
Console.ReadLine();
