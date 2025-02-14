//using System;
//using System.Collections.Generic;

////enum Operacja
////{
////    Dodawanie = 1,
////    Odejmowanie,
////    Mnożenie,
////    Dzielenie
////}

////class Kalkulator
////{
////    static double WykonajOperacje(Operacja operacja, double liczbaA, double liczbaB)
////    {
////        switch (operacja)
////        {
////            case Operacja.Dodawanie:
////                return liczbaA + liczbaB;
////            case Operacja.Odejmowanie:
////                return liczbaA - liczbaB;
////            case Operacja.Mnożenie:
////                return liczbaA * liczbaB;
////            case Operacja.Dzielenie:
////                if (liczbaB == 0)
////                {
////                    throw new DivideByZeroException();
////                }
////                return liczbaA / liczbaB;
////            default:
////                throw new InvalidOperationException("Nieprawidłowa operacja.");
////        }
////    }

////    static void Main()
////    {
////        List<double> historia = new List<double>();

////        while (true)
////        {
////            Console.WriteLine("\nWybierz operację:");
////            Console.WriteLine("1 - Dodawanie");
////            Console.WriteLine("2 - Odejmowanie");
////            Console.WriteLine("3 - Mnożenie");
////            Console.WriteLine("4 - Dzielenie");
////            Console.WriteLine("0 - Zakończ");
////            Console.Write("Wybór: ");

////            int wybor;
////            if (!int.TryParse(Console.ReadLine(), out wybor) || wybor < 0 || wybor > 4)
////            {
////                Console.WriteLine("Nieprawidłowy wybór.");
////                continue;
////            }

////            if (wybor == 0)
////            {
////                break;
////            }

////            try
////            {
////                Console.Write("Podaj pierwszą liczbę: ");
////                double liczbaA = double.Parse(Console.ReadLine());

////                Console.Write("Podaj drugą liczbę: ");
////                double liczbaB = double.Parse(Console.ReadLine());

////                Operacja operacja = (Operacja)wybor;
////                double wynik = WykonajOperacje(operacja, liczbaA, liczbaB);

////                Console.WriteLine("Wynik: " + wynik);
////                historia.Add(wynik);

////                Console.WriteLine("\nHistoria wyników:");
////                foreach (double wynikHistoria in historia)
////                {
////                    Console.WriteLine(wynikHistoria);
////                }
////            }
////            catch (DivideByZeroException)
////            {
////                Console.WriteLine("Błąd: Nie można dzielić przez zero.");
////            }
////            catch (FormatException)
////            {
////                Console.WriteLine("Błąd: Nieprawidłowy format liczby.");
////            }
////            catch (Exception ex)
////            {
////                Console.WriteLine("Wystąpił błąd: " + ex.Message);
////            }
////        }

////        Console.WriteLine("Kalkulator zakończył działanie.");
////    }
////}


//enum StatusZamowienia
//{
//    Oczekujace = 1,
//    Przyjete,
//    Zrealizowane,
//    Anulowane
//}

//class Program
//{
//    static Dictionary<int, List<string>> listaZamowien = new Dictionary<int, List<string>>()
//    {
//        { 1, new List<string> { "Masło", "Bułka" } },
//        { 2, new List<string> { "Ciastko", "Mleko" } }
//    };

//    static Dictionary<int, StatusZamowienia> statusyZamowien = new Dictionary<int, StatusZamowienia>()
//    {
//        { 1, StatusZamowienia.Oczekujace },
//        { 2, StatusZamowienia.Przyjete }
//    };

//    static void WyswietlZamowienia()
//    {
//        Console.WriteLine("\nLista zamówień:");
//        foreach (var zamowienie in listaZamowien)
//        {
//            int numerZamowienia = zamowienie.Key;
//            Console.WriteLine($"Zamówienie {numerZamowienia}:");
//            Console.WriteLine($"Produkty: {string.Join(", ", zamowienie.Value)}");
//            Console.WriteLine($"Status: {statusyZamowien[numerZamowienia]}");
//        }
//    }

//    static void ZmienStatus(int numerZamowienia, StatusZamowienia nowyStatus)
//    {
//        if (!statusyZamowien.ContainsKey(numerZamowienia))
//        {
//            throw new KeyNotFoundException($"Zamówienie o numerze {numerZamowienia} nie istnieje.");
//        }

//        if (statusyZamowien[numerZamowienia] == nowyStatus)
//        {
//            throw new ArgumentException("Nie można zmienić statusu na taki sam jak obecny.");
//        }

//        statusyZamowien[numerZamowienia] = nowyStatus;
//        Console.WriteLine($"Status zamówienia {numerZamowienia} został zmieniony na {nowyStatus}.");
//    }

//    static void Main()
//    {
//        while (true)
//        {
//            Console.WriteLine("\nMenu:");
//            Console.WriteLine("1 - Wyświetl zamówienia");
//            Console.WriteLine("2 - Zmień status zamówienia");
//            Console.WriteLine("0 - Zakończ");
//            Console.Write("Wybierz opcję: ");

//            if (!int.TryParse(Console.ReadLine(), out int opcja) || opcja < 0 || opcja > 2)
//            {
//                Console.WriteLine("Nieprawidłowy wybór.");
//                continue;
//            }

//            if (opcja == 0)
//            {
//                Console.WriteLine("Zakończono program.");
//                break;
//            }

//            try
//            {
//                if (opcja == 1)
//                {
//                    WyswietlZamowienia();
//                }
//                else if (opcja == 2)
//                {
//                    Console.Write("Podaj numer zamówienia: ");
//                    int numerZamowienia = int.Parse(Console.ReadLine());

//                    Console.WriteLine("Wybierz nowy status:");
//                    Console.WriteLine("1 - Oczekujące");
//                    Console.WriteLine("2 - Przyjęte");
//                    Console.WriteLine("3 - Zrealizowane");
//                    Console.WriteLine("4 - Anulowane");
//                    Console.Write("Wybór: ");
//                    int nowyStatus = int.Parse(Console.ReadLine());

//                    if (!Enum.IsDefined(typeof(StatusZamowienia), nowyStatus))
//                    {
//                        Console.WriteLine("Nieprawidłowy status.");
//                        continue;
//                    }

//                    ZmienStatus(numerZamowienia, (StatusZamowienia)nowyStatus);
//                }
//            }
//            catch (KeyNotFoundException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            catch (ArgumentException ex)
//            {
//                Console.WriteLine(ex.Message);
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Nieprawidłowy format danych.");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
//            }
//        }
//    }
//}
