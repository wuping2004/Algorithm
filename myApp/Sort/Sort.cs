using System.Text;

public class Sort
{
   public static void Test()
    {
        int[] a = {5,8,1,9,3,5,7,1,2};
        Print(a);
        System.Console.WriteLine("Bubble sort: T=O(n^2)");
        BubbleSort(a);
        Print(a);
        int[] b = {5,8,1,9,3,5,7,1,2};

        System.Console.WriteLine("Simple selection sort: T=O(n^2), swap count less than bubble sort.");
        SimpleSelectionSort(b);
        Print(b);

        Heap.BuildMarxHeap();
        System.Console.WriteLine("Heap sort: T= O(nlogn), better for big number");

        b = new int[]{5,8,1,9,3,5,7,1,2};
        InsertionSort(b);
        System.Console.WriteLine("Insert sort: T= O(n^2), better for big number");
        
        Print(b);
        System.Console.WriteLine("Quick Sort O(nlogn)");
        b = new int[]{5,8,1,9,3,5,7,1,2};
    
        QuickSort(b);
        Print(b);        
        System.Console.WriteLine("Shell Sort O(nlogn)");
        b = new int[]{5,8,1,9,3,5,7,1,2};
    
        ShellShort(b);
        Print(b);
    }
    
    //
    // Bubble sort  T = O(n^2)
    public static void BubbleSort(int[] a)
    {
        for (int i = 0; i < a.Length -1; i++)
        for (int j = i + 1; j < a.Length; j++)
        
        {
            if(a[i] > a[j])
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
        }
    }

    // Simple select sort T = O(n^2), swap time is less than bubble sort
    public static void SimpleSelectionSort(int[] a)
    {

        int min, minIndex;
        for (int i = 0; i < a.Length -1; i++)
        {
             min = a[i];
             minIndex = i;
            for (int j = i + 1; j < a.Length; j++)
            {
                if(min > a[j])
                {
                    min = a[j];
                    minIndex = j;
                }
            }

            if(minIndex != i)
            {
                int temp = a[i];
                a[i] = a[minIndex];
                a[minIndex] = temp;
            }   
        }
    }


    #region Shell Sort


public static void ShellShort(int[] a)
{
    int d = a.Length/2;
    while(d >= 1)
    {
        InsertionSort(a, d);
        d/=2;
    }
}

public static void InsertionSort(int[] a, int d)
    {
        for (int i = d; i < a.Length; i=i+d)
        {
            int j = i;
            int target = a[j];

            while(j-d >=0 && a[j-d] > target)
            {
                a[j] = a[j-d];
                j-=d;
            }

           
            a[j] = target;
        }
        
    }
    #endregion

    // O(n^2)
    public static void InsertionSort(int[] a)
    {
        for (int i = 1; i < a.Length; i++)
        {
            int j = i;
            int target = a[j];

            while(j>0 && a[j-1] > target)
            {
                a[j] = a[j-1];
                j--;
            }

            a[j] = target;
        }
        
    }

    public static void QuickSort(int[] a)
    {
        QuickSort(a, 0, a.Length-1);
    }

    public static void QuickSort(int[] a, int left, int right)
    {
        if(left < right) 
        {

        int position = Partition(a, left, right);

        QuickSort(a,left, position -1);
        QuickSort(a,position + 1, right);
        }
    }

    public static int Partition(int[] a, int left, int right)
    {
        int target = a[left];

        while(left < right)
        {
            while(left < right && a[right] >= target)
            {
                 right --;  
            }

             a[left] = a[right];
             a[right] = target;

            while(left < right && a[left] <= target)
            {
                left ++;
            }
            
            a[right] = a[left];
            a[left] = target;
        }

        return left;
    }

 public static void Print(int[] a)
    {
        StringBuilder builder = new StringBuilder();
       for (int i = 0; i < a.Length; i++)
       {
           if(builder.Length == 0) builder.Append(a[i]);
           else
           {
               builder.Append(",").Append(a[i]);
           }
        }

       System.Console.WriteLine(builder.ToString());
    }

}