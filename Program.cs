using FirstNumberSort;
using System;
using System.Diagnostics;
using System.Reflection.Metadata;

class Program
{
    private static SortedArray sortedArray;
    private static UnsortedArray unsortedArray;
    private static Stopwatch stopwatch = new Stopwatch();
    static void Main()
    {
        sortedArray = new SortedArray(new int[] { 1, 2, 3, 4, 5});
        unsortedArray = new UnsortedArray(new int[] {4, 3, 5, 1, 2 });
        startMenu();
    }

    public static void startMenu()
    {
        Console.WriteLine("\n" + "Kies een van de menu's:" + "\n" + "1. Toevoegen" + "\n" + "2. Verwijderen" + "\n" + "3. Index opzoeken");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1: add(); break;
            case 2: remove(); break;
            case 3: indexSearch(); break;
        }
    }

    public static void add()
    {
        int choice = classChoice();

        if (choice == 1)
        {
            int element = getNumber("toevoegen");

            startStopwatch();
            unsortedArray.Add(element);
            Console.WriteLine("Element " + element + " toegevoegd aan unsorted index.");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            startMenu();
        }
        else if (choice == 2)
        {
            int element = getNumber("toevoegen");

            startStopwatch();
            sortedArray.Add(element);
            Console.WriteLine("Element " + element + " toegevoegd aan sorted index.");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            startMenu();
        }
        else
        {
            Console.WriteLine("Error: niet bestaand nummer gekozen");
            startMenu();
        }

    }

    public static void remove()
    {
        int choice = classChoice();

        if (choice == 1)
        {
            int element = getNumber("verwijderen");

            startStopwatch();
            unsortedArray.Remove(element);
            Console.WriteLine("Element " + element + " verwijderd aan unsorted index.");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            startMenu();
        }
        else if (choice == 2)
        {
            int element = getNumber("verwijderen");

            startStopwatch();
            sortedArray.Remove(element);
            Console.WriteLine("Element " + element + " verwijderd aan sorted index.");
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            startMenu();
        }
        else
        {
            Console.WriteLine("Error: niet bestaand nummer gekozen");
            startMenu();
        }
    }

    public static void indexSearch()
    {
        int choice = classChoice();

        if (choice == 1)
        {
            int element = getNumber("zoeken");

            startStopwatch();
            Console.WriteLine("Element " + element + " gevonden op unsorted index: " + unsortedArray.IndexOf(element));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            startMenu();
        }
        else if (choice == 2)
        {
            int element = getNumber("zoeken");

            startStopwatch();
            Console.WriteLine("Element " + element + " gevonden op sorted index: " + sortedArray.IndexOf(element));
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);

            startMenu();
        }
        else
        {
            Console.WriteLine("Error: niet bestaand nummer gekozen");
            startMenu();
        }
    }

    public static int classChoice()
    {
        Console.WriteLine("\n" + "Welke arrayList wil je?" + "\n" + "1. UnsortedArray" + "\n" + "2. SortedArray");
        switch (Convert.ToInt32(Console.ReadLine()))
        {
            case 1: return 1;
            case 2: return 2;
        }

        return -1; // Error
    }

    public static int getNumber(String text)
    {
        Console.WriteLine("\n" + "Welk getal wilt u " + text + "?");
        return Convert.ToInt32(Console.ReadLine());
    }

    public static void startStopwatch()
    {
        stopwatch.Reset();
        stopwatch.Start();
    }
}

