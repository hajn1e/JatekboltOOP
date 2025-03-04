namespace JatekboltOOP;

internal class JatekBolt
{
    public List<Jatek> Jatekok { get; set; }
    public List<Felhasznalo> Felhasznalok { get; set; }

    public JatekBolt()
    {
        Jatekok = new List<Jatek>();
        Felhasznalok = new List<Felhasznalo>();
    }

    public void JatekHozzaadas(Jatek jatek)
    {
        Jatekok.Add(jatek);
    }

    public void FelhasznaloHozzaadas(Felhasznalo felhasznalo)
    {
        Felhasznalok.Add(felhasznalo);
    }

    public Jatek KeresesJatek(string cim)
    {
        foreach (var jatek in Jatekok)
        {
            if (jatek.Cim == cim)
            {
                return jatek;
            }
        }

        return null;
    }

    public Felhasznalo KeresesFelhasznalo(string nev)
    {
        foreach (var felhasznalo in Felhasznalok)
        {
            if (felhasznalo.Nev == nev)
            {
                return felhasznalo;
            }
        }

        return null;
    }
}