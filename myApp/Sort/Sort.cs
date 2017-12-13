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
        System.Console.WriteLine("Heap sort: T= O(n), better for big number");
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


 private static void Print(int[] a)
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