
using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        StudentDictionary studs = new StudentDictionary();
        studs.Add("SV001", new Student("SV001", 20, 7.5f));
        studs.Add("SV002", new Student("SV002", 21, 8.3f));
        IDictionaryEnumerator e = studs.GetEnumerator();
        while(e.MoveNext())
            Console.WriteLine($"{e.Key} => {e.Value}");
        /*
        int total = 100;
        int[] arr = new int[total];
        Randomize(arr);
        int time = 0;
        int[] cpy = new int[total];

        Timing timing = new Timing();
        arr.CopyTo(cpy, 0);
        for (int i = 0; i < 100; i++)
        {
            timing.startTime();
            SelectionSort(arr);
            timing.StopTime();
            time += timing.Result().Milliseconds;
        }
        Console.WriteLine($"Selection Sort: {time / 100f} ms");
        time = 0;
        cpy.CopyTo(arr, 0);
        for (int i = 0; i < 100; i++)
        {
            timing.startTime();
            BubbleSort(arr);
            timing.StopTime();
            time += timing.Result().Milliseconds;
        }
        Console.WriteLine($"Bubble Sort: {time / 100f} ms");
        time = 0;
        cpy.CopyTo(arr, 0);
        for (int i = 0; i < 100; i++)
        {
            timing.startTime();
            QuickSort(arr, 0, arr.Length - 1);
            timing.StopTime();
            time += timing.Result().Milliseconds;
        }
        Console.WriteLine($"Quick Sort: {time / 100f} ms");
        */
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int p = Partition(arr, low, high);
            if (p > 1)
                QuickSort(arr, low, p - 1);
            if (p + 1 < high)
                QuickSort(arr, p + 1, high);
        }
    }
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int j = low;
        for (int i = low; i < high; i++)
            if (arr[i] < pivot)
            {
                Swap(ref arr[i], ref arr[j]);
                j++;
            }
        Swap(ref arr[j], ref arr[high]);
        return j;
    }

    static void BubbleSort(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
            for (int j = 0; j < arr.Length - i - 1; j++)
                if (arr[j] > arr[j + 1])
                    Swap(ref arr[j], ref arr[j + 1]);
    }

    static void Randomize(int[] arr)
    {
        Random r = new Random();
        for (int i = 0; i < arr.Length; i++)
            arr[i] = r.Next(99);
    }

    static void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int smallest = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[smallest])
                    smallest = j;
            }
            Swap(ref array[i], ref array[smallest]);
        }
    }
    static void Swap(ref int v1, ref int v2)
    {
        int c = v1;
        v1 = v2;
        v2 = c;
    }
}
