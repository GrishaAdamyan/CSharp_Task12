int[] arr1 = { 17, 18, 15, 19, 14, 20, 12, 24, 30, 10 };
int[] arr2 = { 155, 160, 153, 158, 165, 167, 169, 170, 190, 180, 185 };
int[] arr3 = { 5, 4, 8, 7, 3, 6, 10, 9, 2, 1 };

A ob = new Bubble();
Console.WriteLine(ob.ToString());
ob.Methods(arr1);
ob = new Insertion();
Console.WriteLine(ob.ToString());
ob.Methods(arr2);
ob = new Selection();
Console.WriteLine(ob.ToString());
ob.Methods(arr3);

abstract class A
{
    public void Methods(int[] arr)
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Unsorted array");
        PrintArray(arr);
        Console.WriteLine("------------------------------------------");
        int n = arr.Length;
        Sort(arr, n);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("Sorted array");
        PrintArray(arr);
        Console.WriteLine("------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();

    }

    public abstract void Sort(int[] arr, int n);

    public void PrintArray(int[] arr)
    {
        foreach (var item in arr)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Bubble : A
{
    public override void Sort(int[] arr, int n)
    {
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
                if (arr[j] > arr[j + 1])
                {
                    var tempVar = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tempVar;
                }
            PrintArray(arr);
        }

    }
}
class Insertion : A
{
    public override void Sort(int[] arr, int n)
    {
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
            PrintArray(arr);
        }
    }
}
class Selection : A
{
    public override void Sort(int[] arr, int n)
    {
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
            PrintArray(arr);
        }
    }
}