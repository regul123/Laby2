using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

class Laby2
{
    static void Main(string[] args)
    {
        Ex8();
        Console.ReadLine();
    }


    //Zmodyfikować przykład 2.1 w taki sposób, by program obliczał średnią z ocen pozytywnych.
    static void Ex1()
    {
        int sum = 0;
        int mark;
        int amm = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("podaj ocene: ");
            mark = int.Parse(Console.ReadLine());
            if (mark >2 )
            {
                sum += mark;
                amm++;
            }
        }
        double mean = sum / amm;
        Console.WriteLine("srednia wynosi: {0:N}", mean);
    }

    //Klient banku deponuje na lokacie X letniej kwotę Y. Lokata jest oprocentowana 6% rocznie. Kapitalizacja odsetek odbywa się na koniec każdego roku. Napisać program do obliczania, ile wyniesie wartość tej inwestycji po X latach.
    static void Ex2()
    {
        Console.WriteLine("Podaj kwote ktora chcesz zdeponowac: ");
        double kwota = Double.Parse(Console.ReadLine());
        Console.WriteLine("Podaj liczbe lat: ");
        int lata = int.Parse(Console.ReadLine());
        for (int i = 0;i<lata; i++)
        {
            kwota = kwota * (1.06);
            Console.WriteLine("kapitalizacja po roku {0} wynosi {1}", i+1, kwota);
        }
        Console.WriteLine("wyplata uwzgledniajac kapitalizacje roczna wynosi " + kwota);

    }

    //Napisać program do znajdowania największej (najmniejszej) liczby wśród 5-ciu liczb podanych przez użytkownika.
    static void Ex3()
    {
        int[] tab = new int[5];

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("podaj liczbe: ");
            tab[i] = int.Parse(Console.ReadLine());

        }
        Console.WriteLine("twoje liczby:\n ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(tab[i]+" ");
        }

        int najwieksza = tab[0];
        for (int i = 0; i < 5; i++)
        {
            if (tab[i] > najwieksza) { najwieksza = tab[i]; };
        }
        Console.WriteLine("\nnajwieksza liczba {0}", najwieksza);
    }
    /*Napisać program do obliczania liczby punktów zdobytych przez skoczka narciarskiego. Na liczbę punków (p), jakie otrzymuje skoczek składają się z dwa elementy: punkty zdobyte za długość skoku (pd) i punkty zdobyte za styl
p = pd + ps
Punkty zdobyte za długość skoku oblicza się według reguły:
pd = 60 + (d - K)*S,
gdzie d oznacza długość skoku, K jest punktem konstrukcyjnym skoczni, a S pewną stałą zależną od wielkości skoczni. W zadaniu należy przyjąć K = 120 oraz S = 1.8.
Punkty zdobyte za styl oblicza się następująco: 5-ciu sędziów wystawia oceny w skali 0 do 20, najlepsza i najgorsza z tych ocen są odrzucane, a pozostałe są sumowane.
Program powinien wczytać długość skoku (d) i oceny wystawione przez pięciu sędziów i na tej podstawie obliczyć liczbę punktów.
*/
    static void Ex4()
    {
        Console.WriteLine("Podaj dlugosc skoku: ");
        int d = int.Parse(Console.ReadLine());
        int[] oceny = new int[5];
        for (int i = 0; i < 5; i++)
        {
            Console.Write("podaj liczbe: ");
            oceny[i] = int.Parse(Console.ReadLine());

        }

        Console.Write("twoje liczby:\n ");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(oceny[i] + " ");
        }

        double p = 0;
        double pd = (60 + (d - 120) * 1.8);
        int ps = 0;
        int najwieksza = oceny[0];
        for(int i = 0; i < 5; i++)
        {
            if (oceny[i] > najwieksza) { najwieksza = oceny[i]; };
        }
        int najmniejsza = oceny[0];
        for (int i = 0; i < 5; i++)
        {
            if (oceny[i] < najmniejsza) { najmniejsza = oceny[i]; };
        }
        int suma = 0;
        for (int i = 0; i < 5; i++)
        {
            suma += oceny[i];
        }
        ps = suma - najwieksza - najmniejsza;
        p = ps + pd;
        Console.WriteLine("\nSuma punktow {0}", p);
    }
    //Napisać program do obliczania silni metodą tradycyjną (nie rekurencyjne).
    static double silnia(double a)
    {
        double wynik = 1;
        if(a < 0) 
        { 
            Console.WriteLine("niepoprawne dane ");
            return -1;
        }
        for( int i = (int)a; i > 1; i--)
        {
            wynik *= i;
        }
        Console.WriteLine("silnia z {0} wynosi {1}",a, wynik);
        return wynik;
    }
    //Napisać program do sprawdzania czy wczytana liczba jest pierwsza.
    static bool test_ex6(int liczba)
    {
        if (liczba < 2)
        {
            return false;
        }
        for (int i = 2; i <= Math.Sqrt(liczba); i++)
        {
            if (liczba % i == 0)
            {
                return false;
            }
        }
        return true;

    }
    static void Ex6()
    {
        Console.WriteLine("podaj liczbe ktora chcesz sprawdzic: ");
        int a = int.Parse(Console.ReadLine());

        if (test_ex6(a))
        {
            Console.WriteLine("liczba pierwsza");
        }
        else { Console.WriteLine("liczba nie jest pierwsza"); }
    }

   // Napisać program, który wczytuje dwie liczby całkowite: a i b, gdzie b > a, a następnie wypisuje wszystkie liczby pierwsze z przedziału[a b].
   static void Ex7()
    {
        Console.WriteLine("podaj liczbe a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("podaj liczbe b: ");
        int b = int.Parse(Console.ReadLine());
        if (a > b) { Console.Write("niepoprawne dane(liczba a jest wieksza od liczby b");  }

        Console.WriteLine("liczby pierwsze z tego przedzialu: ");
        for (int i = a; i<=b; i++)
        {
            if (test_ex6(i))
            {
                Console.WriteLine(i);
            }
        }

    }

    static void Ex8()
    {
        Console.WriteLine("Podaj n ");
        double n = double.Parse(Console.ReadLine());
        Console.WriteLine("podaj k");
        double k = double.Parse(Console.ReadLine());
        double dwumian = silnia(n) / (silnia(k)*(silnia(n - k)));
        Console.WriteLine("dwumian wynosi "+dwumian);
    }
}


