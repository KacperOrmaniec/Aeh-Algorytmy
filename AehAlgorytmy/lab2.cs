namespace AehAlgorytmy;

public class lab2
{
    // Kacper Ormaniec 51333 

    // Zadanie 1 
    public static (int maxValue, int lastIndex) FindMaxAndIndex(int[] array)
    {
        int maxValue = int.MinValue;
        int lastIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] >= maxValue)
            {
                maxValue = array[i];
                lastIndex = i;
            }
        }

        return (maxValue, lastIndex);
    }

    // Zadanie 2 - Odwrócenie kolejności elementów
    public static void ReverseArray(int[] array)
    {
        int left = 0;
        int right = array.Length - 1;

        while (left < right)
        {
            int temp = array[left];
            array[left] = array[right];
            array[right] = temp;

            left++;
            right--;
        }
    }

    // Zadanie 3 
    public static int CountDivisibleByX(int[] array, int x)
    {
        int count = 0;

        foreach (var item in array)
        {
            if (item % x == 0)
            {
                count++;
            }
        }

        return count;
    }

    // Zadanie 4
    public static void CompareArrays(int[] array1, int[] array2)
    {
        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] == array2[i])
            {
                Console.WriteLine($"Indeks: {i}, Wartość: {array1[i]}");
            }
        }
    }

    // Zadanie 5 
    public static void SwapElements(int[] array, int x, int y)
    {
        int temp = array[x];
        array[x] = array[y];
        array[y] = temp;
    }

    // Zadanie 6 
    public static void BubbleSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    // Zadanie 7
    public static void InsertionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 1; i < n; i++)
        {
            int key = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = key;
        }
    }

    // Zadanie 8 
    public static void SelectionSort(int[] array)
    {
        int n = array.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }

            // Swap
            int temp = array[minIndex];
            array[minIndex] = array[i];
            array[i] = temp;
        }
    }

    // Zadanie 9 
    public static string DecimalToOctal(int a)
    {
        if (a == 0)
        {
            return "0";
        }

        return DecimalToOctalHelper(a);
    }

    private static string DecimalToOctalHelper(int a)
    {
        if (a == 0)
        {
            return "";
        }

        return DecimalToOctalHelper(a / 8) + (a % 8).ToString();
    }

    // Zadanie 10 
    public static string DecimalToBase(int a, int baseValue)
    {
        if (a == 0)
        {
            return "0";
        }

        return DecimalToBaseHelper(a, baseValue);
    }

    private static string DecimalToBaseHelper(int a, int baseValue)
    {
        if (a == 0)
        {
            return "";
        }

        return DecimalToBaseHelper(a / baseValue, baseValue) + (a % baseValue).ToString();
    }

    // Zadanie 11 
    public static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }

        return GCD(b, a % b);
    }
}