using Doga1024;
using System.Text;

var bolygok = new List<Bolygo>();

var sr = new StreamReader(path:@"..\..\..\src\solsys.txt", encoding: Encoding.UTF8);

while (!sr.EndOfStream)
    bolygok.Add(new Bolygo(sr.ReadLine()));


Console.WriteLine($"3. 1: {bolygok.Count()} bolygó van a naprendszerben");

var f4 = bolygok.Average(b => b.HoldakSzama);

Console.WriteLine($"3. 2: a naprendszerben egy bolygónak átlagban {f4: 0.00} holdja van");

var f5 = bolygok
    .Where(b => b.Arany == bolygok.Max(b => b.Arany))
    .First();

Console.WriteLine($"3. 3:a legnagyobb térfogattal rendelkező bolygó: {f5.BolygoNeve}");

Console.WriteLine($"3. 4 Írd be a keresett bolygó nevét:   ");

var keresett = Console.ReadLine();

var f6 = bolygok
    .Where(b => b.BolygoNeve.Contains(keresett));


if (f6.Count() >= 1)
{
    Console.WriteLine("\tVan ilyen nevű bolygó a naprendszerben!");
}
else
{
    Console.WriteLine("\tNincs ilyen nevű bolygó a naprendszerben!");
}

Console.WriteLine("3.5 Írj be egy egész számot:");
 int keresettSzam = int.Parse(Console.ReadLine());

var f7 = bolygok.Where(b => b.HoldakSzama > keresettSzam)
    .ToList();

Console.WriteLine($"Ezeknek a boylgóknak van {keresettSzam} -nál több holdjuk");
Console.WriteLine("\t[");
foreach (var f in f7)
    Console.WriteLine($"'{f.BolygoNeve}', ");
Console.WriteLine("]");