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
    protected int N = 15;
    protected int[] arr;
    public void init()
    {
        arr = new int[N];
        Random r = new Random();
        for (int i = 0; i < N; i++)
            arr[i] = r.Next(1, 100);
        for (int i = 0; i < N; i++)
            Console.Write(arr[i] + " ");
        Console.WriteLine();
    }
    public bool Cond(ref int a, ref int b)
    {
        return a > b;
    }
    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
    public void output()
    {
        for (int i = 0; i < N; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    public void DoSort() //Template Method
    {
        init();
        Sort();
        output();
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
                if (Cond(ref arr[j], ref arr[j + 1]))
                {
                    Swap(ref arr[j], ref arr[j + 1]);
                }
            }
        }
    }
}
class Insert : Sorter
{
    protected override void Sort()
    {
        for (int i = 1; i < N; i++)
        {
            int j = i - 1;

            while (j >= 0 && Cond(ref arr[j], ref arr[j + 1]))
            {
                Swap(ref arr[j], ref arr[j + 1]);
                j -= 1;
            }
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
                if (Cond(ref arr[minIndex], ref arr[j]))
                {
                    minIndex = j;
                }
            }
            Swap(ref arr[i], ref arr[minIndex]);
        }
    }
}