namespace JatekboltOOP;

class Program
{
    static void Main(string[] args)
    {
        Jatek jatek1= new Jatek("The Witcher 3", "RPG", 12000);
        Jatek jatek2= new Jatek("Cyberpunk 2077", "RPG", 15000);
        Jatek jatek3=new Jatek("FIFA 23", "Sport", 18000);
        
        JatekBolt JatekBolt= new JatekBolt();
        JatekBolt.JatekHozzaadas(jatek1);
        JatekBolt.JatekHozzaadas(jatek2);
        JatekBolt.JatekHozzaadas(jatek3);
        
        
        Felhasznalo adam= new Felhasznalo("Adam", 20000);
        JatekBolt.FelhasznaloHozzaadas(adam);
        Jatek withcer= JatekBolt.KeresesJatek("The Witcher 3");
        adam.Vasarlas(withcer);
        
        adam.Feltoltes(10000);
        Jatek cyberounk= JatekBolt.KeresesJatek("Cyberpunk 2077");
        adam.Vasarlas(cyberounk);
        
        adam.KonyvtarMegtekintes();
    }
}