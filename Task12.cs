using System;
Sorter ob1 = new Bubble();
Console.WriteLine("Bubble");
ob1.DoSort();
Console.WriteLine();
Sorter ob2 = new Insert();
Console.WriteLine("Insert");
ob2.DoSort();
Console.WriteLine();
Sorter ob3 = new Select();
Console.WriteLine("Select");
ob3.DoSort();
abstract class Sorter
{
    public void DoSort() //Template Method
    {
        init();
        Sort();
        output();
    }
    protected int N = 15;
    protected int[] arr;
    protected void init()
    {
        arr = new int[N];
        Random r = new Random();
        for (int i = 0; i<N; i++)
            arr[i] = r.Next(1, 100);
        for (int i = 0; i < N; i++)
            Console.Write(arr[i] + " ");
            Console.WriteLine();
    }
    protected void output()
    {
        for (int i = 0; i < N; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    protected abstract void Sort();
}
class Bubble : Sorter
{
    protected override void Sort()
    {
        for (int i = 0; i < N - 1; i++)
        {
            for (int j = 0; j < N - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    var tempVar = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = tempVar;
                }
            }
        }
    }
}
class Insert : Sorter
{
    protected override void Sort()
    {
        for (int i = 1; i < N; ++i)
        {
            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
}
class Select : Sorter
{
    protected override void Sort()
    {
        for (int i = 0; i < N - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < N; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            int tempVar = arr[minIndex];
            arr[minIndex] = arr[i];
            arr[i] = tempVar;
        }
    }
}