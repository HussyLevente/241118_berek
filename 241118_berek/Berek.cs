namespace _241118_berek;

internal class Berek
{
    public string nev { get; set; }
    public string nem { get; set; }
    public string reszleg { get; set; }
    public int belepes { get; set; }
    public int ber { get; set; }


    public Berek(string sor)
    {
        string[] s = sor.Split(";");
        nev = s[0];
        nem = s[1];
        reszleg = s[2];
        belepes = Convert.ToInt32(s[3]);
        ber = Convert.ToInt32(s[4]);
    }
}
