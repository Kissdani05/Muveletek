using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using ConsoleApp1;


List<Kifejezes> kifejezesekListaja = new List<Kifejezes>();
using (StreamReader sr = new StreamReader("kifejezesek.txt"))
{
    while (!sr.EndOfStream)
    {
        string sor = sr.ReadLine();
        Kifejezes sor1 = new Kifejezes(sor);
        kifejezesekListaja.Add(sor1);
    }
}

Console.WriteLine(kifejezesekListaja.Count());
int modulokSzama = 0;
foreach (var kifejezes in kifejezesekListaja)
{
    if (kifejezes.Muvelet == "mod")
    {
        modulokSzama++;
    }
}

modulokSzama = kifejezesekListaja.Count(x => x.Muvelet == "mod");

Console.WriteLine(modulokSzama);
int tizzel = 0;
foreach (var kifejezes in kifejezesekListaja.Where(x => x.Szam1 % 10 == 0 & x.Szam2 % 10 == 0))
{
    tizzel++;
    if (tizzel > 0)
    {
        Console.WriteLine("Van ilyen");
        break;
    }
}

if (kifejezesekListaja.Where(x => x.Szam1 % 10 == 0 & x.Szam2 % 10 == 0).Count() > 0)
{
        Console.WriteLine("Van ilyen");
}

Console.WriteLine(kifejezesekListaja.Count(x => x.Muvelet == "mod"));
Console.WriteLine(kifejezesekListaja.Count(x => x.Muvelet == "/"));
Console.WriteLine(kifejezesekListaja.Count(x => x.Muvelet == "div"));
Console.WriteLine(kifejezesekListaja.Count(x => x.Muvelet == "-"));
Console.WriteLine(kifejezesekListaja.Count(x => x.Muvelet == "*"));
Console.WriteLine(kifejezesekListaja.Count(x => x.Muvelet == "+"));