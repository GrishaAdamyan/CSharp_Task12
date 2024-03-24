int[] arr1 = { 17, 18, 15, 19, 14, 20, 12, 24, 30, 10 };
int[] arr2 = { 155, 160, 153, 158, 165, 167, 169, 170, 190, 180, 185 };
int[] arr3 = { 5, 4, 8, 7, 3, 6, 10, 9, 2, 1 };

A ob = new Bubble();
Console.WriteLine("Bubble");
ob.Methods(arr1);
ob = new Insertion();
Console.WriteLine("Insertion");
ob.Methods(arr2);
ob = new Selection();
Console.WriteLine("Selection");
ob.Methods(arr3);

abstract class A
{
    public void Methods(int[] numbers)
    {
        Console.WriteLine();
        Console.WriteLine("Unsorted");
        Print(numbers);
        Console.WriteLine();
        int numLength = numbers.Length;
        Sort(numbers, numLength);
        Console.WriteLine();
        Console.WriteLine("Sorted");
        Print(numbers);
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();

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

class Bubble : A
{
    public override void Sort(int[] numbers, int numLength)
    {
        int t;
        for (int i = 0; i < numLength - 1; i++)
        {
            for (int j = 0; j < numLength - i - 1; j++)
                if (numbers[j] > numbers[j + 1])
                {
                    t = numbers[j + 1];
                    numbers[j + 1] = numbers[j];
                    numbers[j] = t;
                }
            Print(numbers);
        }

    }
}
class Insertion : A
{
    public override void Sort(int[] numbers, int numLength)
    {
        for (int i = 1; i < numLength; i++)
        {
            int key = numbers[i];
            int j = i - 1;

            while (j >= 0 && numbers[j] > key)
            {
                numbers[j + 1] = numbers[j];
                j = j - 1;
            }
            numbers[j + 1] = key;
            Print(numbers);
        }
    }
}
class Selection : A
{
    public override void Sort(int[] numbers, int numLength)
    {
        for (int i = 0; i < numLength - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < numLength; j++)
            {
                if (numbers[j] < numbers[minIndex])
                {
                    minIndex = j;
                }
            }
            int tempVar = numbers[minIndex];
            numbers[minIndex] = numbers[i];
            numbers[i] = tempVar;
            Print(numbers);
        }
    }
}