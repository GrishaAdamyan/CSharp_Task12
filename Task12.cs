internal class Task12
{
    static void Main(string[] args)
    {
        int[] arr = { 3, 37, 28, 58, 13, 52, 33, 7, 76, 82 };

        A ob = new Insertion();
        ob.Sort(ref arr);
        ob = new Selection();
        ob.Sort(ref arr);
        ob = new Bubble();
        ob.Sort(ref arr);
    }
}

abstract class A
{
    public void DisplayArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }
    protected int j = 1;
    public void Sort(ref int[] arr)
    {
        for (int i = 1; i < arr.Length; i++)
        {
            int min = arr[i - 1];
            int a = i - 1;
            int k = 0;
            for (j = B(i); Part_One(j, arr, ref k) && Condition_Two(k, arr[j]); ChangeJ(ref j))
            {
                try { k = arr[j + 1]; } catch { k = 0; }
                if (Condition(arr[j], k, min))
                {
                    min = arr[j];
                    a = j;
                    Swap_One(j - 1, j, ref arr);
                }
            }
            Swap_Two(i - 1, a, ref arr);
        }
        DisplayArray(arr);
    }
    protected abstract int B(int i);
    protected abstract bool Condition(int i, int j, int k);
    protected abstract bool Part_One(int j, int[] array, ref int k);
    protected abstract bool Condition_Two(int i, int j);
    protected abstract void ChangeJ(ref int j);
    protected abstract void Swap_One(int i, int j, ref int[] array);
    protected abstract void Swap_Two(int i, int j, ref int[] array);
}


class Bubble : A
{
    protected override int B(int i)
    {
        return 0;
    }
    protected override bool Part_One(int j, int[] arr, ref int k)
    {
        try { k = arr[j - 1]; } catch { k = 0; }
        if (j < arr.Length - 1)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    protected override bool Condition_Two(int i, int j)
    {
        return true;
    }
    protected override void ChangeJ(ref int j)
    {
        j++;
    }
    protected override bool Condition(int fB1, int fB2, int k)
    {
        if (fB1 > fB2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    protected override void Swap_One(int ind1, int ind2, ref int[] arr)
    {
        int temp = arr[ind1];
        arr[ind1] = arr[ind2];
        arr[ind2] = temp;
    }
    protected override void Swap_Two(int ind1, int ind2, ref int[] arr)
    {
        return;
    }
}



class Selection : A
{
    protected override int B(int i)
    {
        return i;
    }
    protected override bool Part_One(int j, int[] arr, ref int k)
    {
        try { k = arr[j - 1]; } catch { k = 0; }
        if (j < arr.Length)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    protected override bool Condition_Two(int i, int j)
    {
        return true;
    }
    protected override void ChangeJ(ref int j)
    {
        j++;
    }
    protected override bool Condition(int fS2, int k, int fS1)
    {
        if (fS1 > fS2)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    protected override void Swap_One(int ind1, int ind2, ref int[] arr)
    {
        return;
    }
    protected override void Swap_Two(int ind1, int ind2, ref int[] arr)
    {
        int temp = arr[ind1];
        arr[ind1] = arr[ind2];
        arr[ind2] = temp;
    }
}


class Insertion : A
{
    protected override int B(int i)
    {
        return i;
    }
    protected override bool Part_One(int j, int[] arr, ref int k)
    {
        try { k = arr[j - 1]; } catch { k = 0; }
        if (j > 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    protected override void ChangeJ(ref int j)
    {
        j--;
    }
    protected override bool Condition_Two(int i, int j)
    {
        if (i > j)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    protected override bool Condition(int fB1, int fB2, int k)
    {
        return true;
    }
    protected override void Swap_One(int ind1, int ind2, ref int[] arr)
    {
        int temp = arr[ind1];
        arr[ind1] = arr[ind2];
        arr[ind2] = temp;
    }
    protected override void Swap_Two(int ind1, int ind2, ref int[] array)
    {
        return;
    }
}
