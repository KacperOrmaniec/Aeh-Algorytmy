namespace AehAlgorytmy;

public class lab1
{
    //Kacper Ormaniec 51333 
    //zad1 C# - .NET 8.0
    public static int HighestNumber(int num1, int num2, int num3)
    {
        var highestValue = Math.Max(num1, num2);
        highestValue = Math.Max(highestValue, num3);
        
        return highestValue;
    }
    
    //zad2 C# - .NET 8.0
    public static bool IsTriangle(int num1, int num2, int num3)
        => num1 < num2 && num1 < num3 && num2 < num3;
    
    
    //zad3 C# - .NET 8.0
    public static int WartoscSkokuJednostkowego(int p, int x)
        => x > p ? 1 : 0;
    
    
    //zad4 
    public static string IsEven(int n)
        => n % 2 == 0 ? "even" : "odd";
    
    //zad5
    public static bool IsFirstNumber(int n)
    {
        if (n == 2)
        {
            return true;
        }

        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                return false; 
            }
        }
        return true;
    }
    //zad6
    /*
    static void Main()
    {
        Console.Write("Podaj wartość progową p: ");
        int p = int.Parse(Console.ReadLine());

        bool foundGreaterThanP = false;
        int number;

        Console.WriteLine("Wprowadź liczby całkowite dodatnie (0 kończy wprowadzanie):");

        while (true)
        {
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break; 
            }

            if (number > p)
            {
                foundGreaterThanP = true;
                Console.WriteLine($"Liczba {number} jest większa niż {p}.");
            }
        }

        if (!foundGreaterThanP)
        {
            Console.WriteLine($"Nie wprowadzono żadnej liczby większej niż {p}.");
        }
    }
    */
    
    //zad7
    /*
    static void Main()
    {
        Console.Write("Podaj wartość progową p: ");
        int p = int.Parse(Console.ReadLine());

        int countGreaterThanP = 0;
        int number;

        Console.WriteLine("Wprowadź liczby całkowite dodatnie (0 kończy wprowadzanie):");

        while (true)
        {
            number = int.Parse(Console.ReadLine());

            if (number == 0)
            {
                break; 
            }

            if (number > p)
            {
                countGreaterThanP++;
            }
        }

        Console.WriteLine($"Liczb większych niż {p} jest: {countGreaterThanP}");
    }
    */
    
    
    //zad8
    /*
      static void Main()
       {
           int minValue = int.MaxValue; // Inicjalizacja z maksymalną wartością liczby całkowitej
           int number;

           Console.WriteLine("Wprowadź liczby całkowite dodatnie (0 kończy wprowadzanie):");

           while (true)
           {
               number = int.Parse(Console.ReadLine());

               if (number == 0)
               {
                   break; 
               }

               if (number < minValue)
               {
                   minValue = number; 
               }
           }

           if (minValue == int.MaxValue)
           {
               Console.WriteLine("Nie wprowadzono żadnych liczb dodatnich.");
           }
           else
           {
               Console.WriteLine($"Minimalna wartość w ciągu wynosi: {minValue}");
           }
       }
     */
    
    //zad9
    /*
     static void Main()
       {
           Console.Write("Podaj liczbę całkowitą n: ");
           int n = int.Parse(Console.ReadLine());

           if (n < 0)
           {
               Console.WriteLine("Silnia jest zdefiniowana tylko dla liczb nieujemnych.");
               return;
           }

           long factorial = CalculateFactorial(n);
           Console.WriteLine($"{n}! = {factorial}");
       }

       static long CalculateFactorial(int n)
       {
           long result = 1;
           for (int i = 2; i <= n; i++)
           {
               result *= i;
           }
           return result;
       }
     */
    
    //zad10
    /*
     static void Main()
       {
           Console.Write("Podaj wartość n: ");
           int n = int.Parse(Console.ReadLine());

           if (n < 0)
           {
               Console.WriteLine("Wartość n musi być nieujemna.");
               return;
           }

           long fibonacci = CalculateFibonacci(n);
           Console.WriteLine($"{n}-ty wyraz ciągu Fibonacciego to: {fibonacci}");
       }

       static long CalculateFibonacci(int n)
       {
           if (n == 0 || n == 1)
           {
               return 1; 
           }

           long a = 1, b = 1, c = 0;
           for (int i = 2; i <= n; i++)
           {
               c = a + b;
               a = b;
               b = c;
           }
           return c;
       }
     */
    
    //zad11
    /*
    static void Main(string[] args)
    {
        var limit = 10000; //inaczej dzialanie bedzie nieskonczone
        double wynik = ObliczSume(limit);
        Console.WriteLine($"Suma ciągu do n = {limit} wynosi: {wynik}");
    }

    static double ObliczSume(int limit)
    {
        var suma = 0.0;

        for (int n = 1; n <= limit; n++)
        {
            var wyraz = 1.0 / (n * (n + 1));
            suma += wyraz;
        }

        return suma;
    }
    */
}