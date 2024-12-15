using ConsoleApp1;
//RunOsoba();
//RunBankAccount();
//RunStudent();
RunSumator();
static void RunOsoba()
{
    Console.WriteLine("Podaj imie: ");
    string firstName = Console.ReadLine();

    Console.WriteLine("Podaj nazwisko: ");
    string secondName = Console.ReadLine();

    Console.WriteLine("Podaj wiek: ");
    int wiek = int.Parse(Console.ReadLine());

    Osoba osoba = new Osoba(firstName, secondName, wiek);
    osoba.WyswietlInformacje();
}

static void RunBankAccount()
{
    BankAccount konto = new BankAccount(1000, "Jan Nowak");
    konto.Wplata(-2);
    konto.View();
    konto.Wyplata(2000);
    konto.View();
    Console.WriteLine($"Saldo: {konto.Saldo}");
}

static void RunStudent()
{
    Student student = new Student("Agata", "Szin");
    student.DodajOcene(5);
    student.DodajOcene(4);
    Console.WriteLine(student.SredniaOcen);
}


static void RunSumator()
{
    Sumator sumator = new Sumator([2, 3, 5, 6, 7]);

    Console.WriteLine($"Suma: {sumator.Suma()}");
    Console.WriteLine($"Suma dzielonych przez 2: {sumator.SumaPodziel2()}");
    Console.WriteLine($"Ilość elementów: {sumator.IleElementow()}");
    sumator.WszystkieElementy();
    sumator.IndeksyElementy(3, 5);
}