![排序](./sort.jpg)

# 冒泡排序

```
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
```

# 选择排序
```
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

```

# 插入排序
```
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
```
# 希尔排序
```
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
```
# 快速排序

```
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
```
# 堆排序
```
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

```


