
public class Program
{
    public static void Main(string[] args)
    {
        int[]arr = new int[1000];
        Randomize(arr);
        int time = 0;
        Timing timing = new Timing();
        for(int i=0; i<100; i++){
            timing.startTime();
            SelectionSort(arr);
            timing.StopTime();
            time += timing.Result().Milliseconds;
        }
        Console.WriteLine($"Selection Sort: {time/100f} ms");
        time = 0;
        for(int i=0; i<100; i++){
            timing.startTime();
            BubbleSort(arr);
            timing.StopTime();
            time += timing.Result().Milliseconds;
        }
        Console.WriteLine($"Bubble Sort: {time/100f} ms");
    
    }
    static void BubbleSort(int[] arr){
        for(int i=0; i<arr.Length-1; i++)
            for(int j=0; j<arr.Length-i-1; j++)
                if(arr[j] > arr[j+1])
                    Swap(ref arr[j], ref arr[j+1]);
    }

  static void Randomize(int[] arr){
        Random r = new Random();
        for(int i=0; i<arr.Length; i++)
            arr[i] = r.Next(99);
    }

    static void SelectionSort(int[] array){
        for (int i = 0; i < array.Length - 1; i++){
            int smallest = i;
            for (int j = i + 1; j < array.Length; j++){
                if (array[j] < array[smallest])
                    smallest = j;
            }
            Swap(ref array[i], ref array[smallest]);
        }
    }
    static void Swap(ref int v1, ref int v2){
        int c = v1;
        v1 = v2;
        v2 = c;
    }
}
