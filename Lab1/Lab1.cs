

zadanie1();

static void zadanie1()
{
    Console.WriteLine("Podaj a:");
    double a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Podaj b:");
    double b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Podaj c:");
    double c = Convert.ToDouble(Console.ReadLine());

    double delta, x1, x2;

    if (a != 0)
    {
        delta = Math.Pow(b, 2) - (4 * a * c);
        Console.WriteLine(delta);
        if (delta > 0)
        {
            x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("Dwa rozwiązania: x1= " + x1 + " i x2= " + x2);
        }
        else if (delta == 0)
        {
            x1 = -b / (2 * a);
            Console.WriteLine("Jedno rozwiązanie: x0= " + x1);
        }
        else if (delta < 0)
        {
            Console.WriteLine("Brak rozwiązań!");
        }
    }

}



using System;

zadanie();

static void zadanie()
{
    menu();
}

static void menu()
{
ViewMenu:
    Console.WriteLine("--------------------------- Kalkulator ----------------------------");
    Console.WriteLine("1. Suma\n2. Różnica\n3. Iloczyn\n4. Iloraz\n5. Potęgowanie\n6. Pierwiastek\n7. Funkcje trygonometryczne\n8. Wyjście");
    Console.WriteLine("Wybierz opcję!");
    int choise = Convert.ToInt32(Console.ReadLine());
    switch (choise)
    {
        case 1: Total(); break;
        case 2: Difference(); break;
        case 3: ProductNumber(); break;
        case 4: QuationNumber(); break;
        case 5: PotentiationNumber(); break;
        case 6: SquareNumber(); break;
        case 7: Trigonometry(); break;
        case 8: Close(); break;
        default: Console.WriteLine("Błędny wybór, wybierz opcję jeszcze raz"); goto ViewMenu;
    }
}

static void Trigonometry()
{
    double a = DoubleInput();
    double b = (a * Math.PI) / 180;
    Console.WriteLine("sin(" + a + ", " + Math.Sin(b));
    Console.WriteLine("sin(" + a + ", " + Math.Cos(b));
    Console.WriteLine("sin(" + a + ", " + Math.Tan(b));
    Console.WriteLine("sin(" + a + ", " + Math.Tanh(b));
}

static void SquareNumber()
{
    double a = DoubleInput();
    Console.WriteLine("Pierwiastek" + Math.Sqrt(a));
}

static void PotentiationNumber()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine("Potęga = " + Math.Pow(a, b));
}

static void QuationNumber()
{
    double a = DoubleInput();
    double b = DoubleInput();
    if (b == 0) Console.WriteLine("Nie dziel przez 0!");
    else
    {
        Console.WriteLine($"Dzielenie {a} / {b} = {a / b}");
    }
}

static void ProductNumber()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Mnożenie {a} * {b} = {a * b}");
}

static void Difference()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Różnica {a} - {b} = {a - b}");
}

static void Total()
{
    double a = DoubleInput();
    double b = DoubleInput();
    Console.WriteLine($"Suma {a} + {b} = {a + b}");
}

static void Close()
{
    Console.WriteLine("Koniec programu");
    System.Environment.Exit(1);
}

static double DoubleInput()
{
    Console.WriteLine("Podaj liczbę: ");
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}


zadanie();



static void menu()
{
    double[] tablica = new double[10];
    for (int i = 0; i < 10; i++)
    {
        tablica[i] = DoubleInput();
    }

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine(tablica[i]);
    }

    for (int i = 9; i >= 0; i--)
    {
        Console.WriteLine(tablica[i]);
    }

    for (int i = 0; i < 10; i++)
    {
        if (i % 2 != 0)
            Console.WriteLine(tablica[i]);
    }

    for (int i = 0; i < 10; i++)
    {
        if (i % 2 == 0)
            Console.WriteLine(tablica[i]);
    }

}

static double DoubleInput()
{
    Console.WriteLine("Podaj liczbę: ");
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}

using System.Linq;

zadanie();

static void zadanie()
{
    menu();
}

static void menu()
{
    double[] tablica = new double[10];
    for (int i = 0; i < 10; i++)
    {
        tablica[i] = DoubleInput();
    }

    Console.WriteLine($"Suma: {tablica.Sum()}");
    Console.WriteLine($"Iloczyn: {tablica.Aggregate(1, (double a, double b) => a * b)}");
    Console.WriteLine($"Średnia: {tablica.Average()}");
    Console.WriteLine($"Min: {tablica.Min()}");
    Console.WriteLine($"Max: {tablica.Max()}");
}


static double DoubleInput()
{
    Console.WriteLine("Podaj liczbę: ");
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}

using System.Linq;

zadanie();

static void zadanie()
{
    menu();
}

static void menu()
{
    double[] odrzucone = { 2, 6, 9, 15, 19 };



    for (int i = 20; i >= 0; i--)
    {
        if (odrzucone.Contains(i)) continue;
        Console.WriteLine(i);
    }
}


static double DoubleInput()
{
    Console.WriteLine("Podaj liczbę: ");
    double input = Convert.ToDouble(Console.ReadLine());
    return input;
}


using System.Linq;

zadanie();

static void zadanie()
{
    menu();
}

static void menu()
{
    while (true)
    {
        int input = (int)IntInput();
        if (input < 0) break;
    }


}


static double IntInput()
{
    Console.WriteLine("Podaj liczbę: ");
    int input = Convert.ToInt32(Console.ReadLine());
    return input;
}
using System.Linq;

zadanie();

static void zadanie()
{
    menu();
}

static void menu()
{
    Console.WriteLine("Podaj liczbe n:");
    int n = Convert.ToInt32(Console.ReadLine());
    int[] tablica = new int[n];
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Podaj liczbę:");
        tablica[i] = Convert.ToInt32(Console.ReadLine());
    }

    Console.WriteLine("Podaj sortowanie: 1- babelkowe; 2- przez wstawianie");
    int sortowanie = Convert.ToInt32(Console.ReadLine());

    switch (sortowanie)
    {
        case 1:
            BubbleSort(tablica);
            break;
        case 2:
            InsertionSort(tablica);
            break;

    }

    foreach (int j in tablica)
    {
        Console.WriteLine(j);
    }

}


static void BubbleSort(int[] tablica)
{
    int n = tablica.Length;
    for (int i = 0; i < n - 1; i++)
    {
        for (int j = 0; j < n - i - 1; j++)
        {
            if (tablica[j] > tablica[j + 1])
            {
                int temp = tablica[j];
                tablica[j] = tablica[j + 1];
                tablica[j + 1] = temp;
            }
        }
    }
}


static void InsertionSort(int[] tablica)
{
    int n = tablica.Length;
    for (int i = 1; i < n; i++)
    {
        int klucz = tablica[i];
        int j = i - 1;


        while (j >= 0 && tablica[j] > klucz)
        {
            tablica[j + 1] = tablica[j];
            j--;
        }

        tablica[j + 1] = klucz;
    }
}
