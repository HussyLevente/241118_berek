using _241118_berek;
using System.Security.Cryptography.X509Certificates;
using System.Text;

List<Berek> berek = new List<Berek>();

using StreamReader sr = new("..\\..\\..\\src\\berek2020.txt", Encoding.UTF8);
while (!sr.EndOfStream)
{
    berek.Add(new(sr.ReadLine()));
}


Console.WriteLine($"3. Feladat: Dolgozók száma: {berek.Count} fő");

double osszeg = 0;
for (int i = 0; i < berek.Count; i++)
{
    osszeg += berek[i].ber;
}

Console.WriteLine($"4. Feladat: Bérek átlaga: {(osszeg/berek.Count)/1000:0.0} eFt");


Console.Write("5. Feladat: Kérem a részleg nevét: ");
string neve = Console.ReadLine();

int max = 0;
bool find = false;
int j = 0;

while (find != true)
{
    for (int i = 0; i < berek.Count; i++)
    {
        if (berek[i].ber > max && berek[i].reszleg == neve)
        {
            max = berek[i].ber;
            j = i;
            find = true;
        }
    }
}
if (find == true)
{
    Console.WriteLine($"6. Feladat: A legtöbbet kereső dolgozó a megadott részlegen\n\tNév: {berek[j].nev}\n\tNem: {berek[j].nem}\n\tBelépés: {berek[j].belepes}\n\tBér: {berek[j].ber} Forint");
}
else
{
    Console.WriteLine($"6. Feladat: A megadott részleg nem létezik a cégnél!");
}

var f7 = berek.GroupBy(v => v.reszleg);
Console.WriteLine("7. Feladat: Statisztika");
foreach (var grp in f7)
{
    Console.WriteLine($"\t{grp.Key} - {grp.Count()} fő");
}