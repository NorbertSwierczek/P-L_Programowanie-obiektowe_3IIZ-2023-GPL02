using Lab4;


public static class OsobaZad3
{
    public static void WypiszOsoby(this List<IOsoba> osoby)
    {
        foreach (var osoba in osoby)
        {
            osoba.GetFullName();
        }
    }

    public static void WypiszOsoby(this List<IStudent> osoby)
    {
        foreach (var osoba in osoby)
        {
            Console.WriteLine(osoba.GetFullNameAndSchool());
        }
    }

    public static void PosortujOsobyPoNazwisku(this List<IOsoba> osoby)
    {
        osoby.Sort((o1, o2) => string.Compare(o1.LastName, o2.LastName, StringComparison.Ordinal));
    }
}

internal class Program
{

    static void Main()
    {
        // Zadanie 1
        //List<Shape> shapes = new List<Shape>();
        //shapes.Add(new Rectangle(10, 20, 30, 40));
        //shapes.Add(new Triangle(15, 25, 35, 55));
        //shapes.Add(new Circle(15, 55, 10));

        //foreach (Shape shape in shapes)
        //{
        //    shape.Draw();
        //}

        
        Uczen uczen1 = new Uczen("Enest", "Adamski", "61041185857", "WSIZ");
        Uczen uczen2 = new Uczen("Mariusz", "Maziarz", "06282628475", "PRZ");
        Nauczyciel nauczyciel = new Nauczyciel("Jerzy", "Nowak", "86062377373", "WSIZ", "mgr", [uczen1, uczen2]);
        nauczyciel.WhichStudentCanGoHomeAlone(DateTime.Today);

     
    }
}