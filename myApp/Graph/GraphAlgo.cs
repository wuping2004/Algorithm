using System;
using System.Collections.Generic;
using System.Linq;
public class GraphAlgo
{

  // Graph is the graph object that algo apply on.
  // Start is start point.
  // End is end point.
  // Stops is stops number.
  // isExact true means exact and false means maxnium number.
  public static int GetTripsNumber(Graph graph, string start, string end, int stops, bool isExact)
  {
     int n = 1;
     int numbers = 0;
     int startIndex = graph.mapping[start];
     int endIndex = graph.mapping[end];
    
    Queue<int> queue  = new Queue<int>();
    

    for(int i = 0; i < graph.Vertex.Length; i ++)
    {
        if(graph.Matrix[startIndex][i] != Graph.MARXVAL)
        {
            queue.Enqueue(i);
          
        }
    }

    queue.Enqueue(Graph.MARXVAL);

    while(queue.Count > 0 && n <= stops )
    {
        int val = queue.Dequeue();
       
        if(val == Graph.MARXVAL)
        {
            n++;
            queue.Enqueue(Graph.MARXVAL);

        }
        else
        {
           if(val == endIndex)
           {
               if(isExact && n == stops)
               {
                 numbers ++;
               } 
               else if (!isExact)
               {
                   numbers ++;
               }
           }
           
            for(int i = 0; i< graph.Vertex.Length; i ++)
            {
                if(graph.Matrix[val][i] != Graph.MARXVAL)
                {
                    queue.Enqueue(i);
                }
            }
        }
    }

    System.Console.WriteLine(numbers);
    return numbers;
  }

    // isExact true means exact and false means maxnium number.
  public static int GetTripsNumber(Graph graph, string start, string end, int distance)
  {
   int[][] temp = new int[graph.Vertex.Length][]; 
   for(int i = 0;i< graph.Vertex.Length; i ++)
   {
       temp[i] = new int[graph.Vertex.Length];
   }

   Stack<int> stack = new Stack<int>();

   int startIndex = graph.mapping[start];
   int endIndex = graph.mapping[end];
   int number = 0;
   stack.Push(startIndex);

   while(stack.Count > 0)
   {
      int val = stack.Pop();
      int previouse  = startIndex;
      Console.Write(graph.Vertex[val]);
      for(int i = 0; i< graph.Vertex.Length; i ++)
      {
          
        if(graph.Matrix[val][i] != Graph.MARXVAL)
        {
           
            int sum = temp[val][i] + graph.Matrix[val][i];
                
                if(sum < 30)
                {
                    if(i == endIndex)
                    {   
                       number ++;
                        Console.Write(graph.Vertex[endIndex]);
                        System.Console.WriteLine();
                      }
                     stack.Push(i);

                temp[val][i] += graph.Matrix[val][i];
                }
        }  
      }


   }
   System.Console.WriteLine(number);
   return number;
  }

      public static int GetShortest(Graph graph, string start, string end)
      {

        int[][] result = graph.Matrix.Clone() as int[][];
        int startIndex = graph.mapping[start];
        int endIndex = graph.mapping[end];

          for(int k = 0; k < graph.Vertex.Length; k ++)          
             for(int i = 0; i < graph.Vertex.Length; i ++)
                  for(int j = 0; j < graph.Vertex.Length; j ++)
                  {
                      if(
                       result[i][k] != Graph.MARXVAL
                      && result[k][j] != Graph.MARXVAL)
                      {
                        if(result[i][j] > result[i][k] + result[k][j])
                        {
                            result[i][j] = result[i][k] + result[k][j];
                        }
                      }
                  }

         System.Console.WriteLine(result[startIndex][endIndex]);
        return result[startIndex][endIndex];
      }

   public static int GetRoutesWeight(Graph graph, string route)
    {
        string[] input = route.Split('-');
        int[] routePath = new int[input.Length];

        int index =0;

        foreach(var item in input)
        {
            routePath[index] = graph.mapping[item];
            index++;
        }
    
       int sum = 0;
       for(int i = 0; i< routePath.Length -1; i ++)
       {
          int weight = graph.Matrix[routePath[i]][routePath[i+1]];

          if(weight == Graph.MARXVAL)
          {
              System.Console.WriteLine("NO SUCH ROUTE");
              return 0;
          }

          sum += weight;

       }
       System.Console.WriteLine(sum);
       return sum;

    }

}