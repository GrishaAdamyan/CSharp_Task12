int[] arr1 = { 73, 57, 49, 99, 133, 20, 1 };
int[] arr2 = { 73, 57, 49, 99, 133, 20, 1 };
int[] arr3 = { 73, 57, 49, 99, 133, 20, 1 };
B ob = new A();
ob.Methods(arr1, arr2, arr3);
abstract class B
{
    public void Methods(int[] arr1, int[] arr2, int[] arr3)
    {
        Bubble(arr1);
        Insertion(arr2);
        Selection(arr3);
    }
    public abstract void Bubble(int[] arr);
    public abstract void Insertion(int[] arr);
    public abstract void Selection(int[] arr);
}
class A : B
{
    public override void Bubble(int[] arr)
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Unsorted array");
        DisplayArray(arr);
        Console.WriteLine("-------------------------------------");
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    var tempVar = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tempVar;
                }
            DisplayArray(arr);
        }
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Sorted by Bubble sort:");
        DisplayArray(arr);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
    public override void Insertion(int[] arr)
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Unsorted array");
        DisplayArray(arr);
        Console.WriteLine("-------------------------------------");
        int n = arr.Length;
        for (int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
            DisplayArray(arr);
        }
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Sorted by Insertion sort:");
        DisplayArray(arr);
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
    }
    public override void Selection(int[] arr)
    {
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Unsorted array");
        DisplayArray(arr);
        Console.WriteLine("-------------------------------------");
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int tempVar = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = tempVar;
            DisplayArray(arr);
        }
        Console.WriteLine("-------------------------------------");
        Console.WriteLine("Sorted by Selection sort:");
        DisplayArray(arr);
        Console.WriteLine("-------------------------------------");
    }

    private void DisplayArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}