int[] arr1 = { 17, 18, 15, 19, 14, 20, 12, 24, 30, 10 };
int[] arr2 = { 155, 160, 153, 158, 165, 167, 169, 170, 190, 180, 185 };
int[] arr3 = { 5, 4, 8, 7, 3, 6, 10, 9, 2, 1 };

Algorithm bubble = new Bubble();
Console.WriteLine("Bubble");
bubble.Methods(arr1);
Algorithm insertion = new Insertion();
Console.WriteLine("Insertion");
insertion.Methods(arr2);
Algorithm selection = new Selection();
Console.WriteLine("Selection");
selection.Methods(arr3);

abstract class Algorithm
{
    public void Methods(int[] numbers)
    {
        Print(numbers);
        int numLength = numbers.Length;
        Sort(numbers, numLength);
        Print(numbers);
        Console.WriteLine();
    }

    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    public int Compare(int a, int b)
    {
        if (a > b)
        {
            return 1;
        }
        else
        {
            return 0;
        }

    }

    public abstract void Sort(int[] numbers, int numLength);

    public void Print(int[] numbers)
    {
        foreach (var num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}

class Bubble : Algorithm
{
    public override void Sort(int[] numbers, int numLength)
    {
        for (int i = 0; i < numLength - 1; i++)
        {
            for (int j = 0; j < numLength - i - 1; j++)
                if (Compare(numbers[j], numbers[j + 1]) == 1)
                {
                    Swap(ref numbers[j], ref numbers[j + 1]);
                }
        }

    }
}
class Insertion : Algorithm
{
    public override void Sort(int[] numbers, int numLength)
    {
        for (int i = 1; i < numLength; i++)
        {
            int key = numbers[i];
            int j = i - 1;

            while (j >= 0 && Compare(numbers[j], key) == 1)
            {
                numbers[j + 1] = numbers[j];
                j = j - 1;
            }
            numbers[j + 1] = key;
        }
    }
}
class Selection : Algorithm
{
    public override void Sort(int[] numbers, int numLength)
    {
        for (int i = 0; i < numLength - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < numLength; j++)
            {
                if (Compare(numbers[j], numbers[minIndex]) == 0)
                {
                    minIndex = j;
                }
            }
            Swap(ref numbers[minIndex], ref numbers[i]);
        }
    }
}