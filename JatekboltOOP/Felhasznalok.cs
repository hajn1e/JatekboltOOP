namespace JatekboltOOP;

internal class Felhasznalo
{
    public string Nev { get; set; }
    public int Egyenleg { get; set; }
    public List<Jatek> Konyvtar  { get; set; }

    public Felhasznalo(string nev, int egyenleg)
    {
        Nev = nev;
        Egyenleg = egyenleg;
        Konyvtar = new List<Jatek>();
    }

    public bool Vasarlas(Jatek jatek)
    {
        if (Konyvtar.Contains(jatek) && Egyenleg < jatek.Ar)
        {
            Console.WriteLine($"A {jatek.Cim} már a könyvtárban van és nincs elég pénz a vásárláshoz");
            return false;
        }
        else
        {
            Console.WriteLine($"A {jatek.Cim} sikeresen megvásárolva");
            Konyvtar.Add(jatek);
            Egyenleg -= jatek.Ar;
            return true;
        }
    }

    public void KonyvtarMegtekintes()
    {
        Console.WriteLine("Megvásárolt játékok:");
        foreach (var jatek in Konyvtar)
        {
            Console.WriteLine(jatek.Cim);
        }
    }

    public void Feltoltes(int osszeg)
    {
        Egyenleg += osszeg;
        Console.WriteLine($"{osszeg} sikeresen feltöltve");
    }
    
}