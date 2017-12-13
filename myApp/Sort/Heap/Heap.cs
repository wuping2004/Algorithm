using System;
using System.Linq;
using System.Text;

public class Heap
{
    public static int[] BuildMarxHeap()
    {
      //  System.Console.WriteLine("Input the array");
        string input = "5,8,1,9,3,5,7,1,2";
        int [] a = input.Split(',').Select(i=>int.Parse(i)).ToArray();
        

        for(int i = a.Length/2; i>=0; i --)
        {
            BuildMarxHeap(a,i);
        }

        return a;
    }

    public static void BuildMarxHeap(int[] a, int i)
    {
        int l = Left(i);
        int r = Right(i);
        int largest = i;
       // System.Console.WriteLine("index is "+ i);
        if(l < a.Length && a[l] > a[i])
        {
            largest = l;
        }
       
        if(r <a.Length && a[r] > a[largest])
        {
            largest = r;
        }

        if(largest != i)
        {
           int temp = a[i];
           a[i] = a[largest];
           a[largest] = temp;
           //PrintHeap(a);
           BuildMarxHeap(a,largest);
        }
    }

    public static int Left(int i)
    {
        var res = (i << 1) + 1;
        return res;
    }

    public static int Right(int i)
    {
        var res = (i << 1) + 2;
        return res;
    }

    private static void PrintHeap(int[] a)
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