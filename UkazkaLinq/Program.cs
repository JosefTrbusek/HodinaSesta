using UkazkaLinq;

List<Auto> parkoviste = new List<Auto>();

var prvniAuto = parkoviste.FirstOrDefault();
if (prvniAuto != null)
{
    Console.WriteLine(prvniAuto.Nazev);
}
else
{
    Console.WriteLine("Není první auto");
}
parkoviste.Add(new Auto() { Barva = "bílá", Nazev = "Octavia", Vyrobce = "Škoda", VykonMotoru = 110, PocetKol = 4 });
parkoviste.Add(new Auto() { Barva = "hnědá", Nazev = "Velorex", Vyrobce = "Velorex", VykonMotoru = 12, PocetKol = 3 });
parkoviste.Add(new Auto() { Barva = "bílá", Nazev = "Ceed", Vyrobce = "Kia", VykonMotoru = 100, PocetKol = 4 });
parkoviste.Add(new Auto() { Barva = "červená", Nazev = "813", Vyrobce = "Tatra", VykonMotoru = 168, PocetKol = 6 });

prvniAuto = parkoviste.FirstOrDefault();
if (prvniAuto != null)
{
    Console.WriteLine(prvniAuto.Nazev);
}
else
{
    Console.WriteLine("Není první auto");
}

Console.WriteLine("Počet aut na parkovišti: " + parkoviste.Count);
Console.WriteLine("Počet bílých aut na parkovišti: " + parkoviste.Count(x => x.Barva == "bílá"));
Console.WriteLine("Počet aut se 4mi koly: " + parkoviste.Where(x => x.PocetKol == 4).Count());
Console.WriteLine("Prumerny výkon motoru: " + parkoviste.Average(x => x.VykonMotoru));
Console.WriteLine("Nejvetsi výkon motoru: " + parkoviste.MaxBy(x => x.VykonMotoru).Nazev);

foreach(var item in parkoviste.OrderBy(x=>x.Vyrobce))
{
    Console.WriteLine(item.Vyrobce + " " + item.Nazev);
}

Console.ReadLine();