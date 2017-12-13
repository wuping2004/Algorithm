using System;
using System.Collections.Generic;
using System.Linq;
public class Graph
{
    public const int MARXVAL= int.MaxValue;
   
    internal string[] Vertex;

    internal Dictionary<string, int> mapping = new Dictionary<string, int>();

    internal int[][] Matrix;
   public Graph(IInputService inputService)
   {
       Vertex = inputService.GetVertex().ToArray();
       Matrix = InitialMatrix(Vertex, inputService.GetGraphInput().ToArray());
       ShowMatrix();
   }

   private void ShowMatrix()
   {
       for(int i = 0; i< Matrix.Length; i++)
        {
            for(int j = 0; j< Matrix.Length; j++)
            {
                System.Console.Write(string.Format("{0}  ", Matrix[i][j]));
                
            }
            System.Console.WriteLine();
        }
   }

   private void ShowVertex()
   {
       foreach(var item in mapping)
       {
           Console.Write(string.Format("{0} {1}",item.Value, item.Key));
           System.Console.WriteLine();
       }
   }
    private  int[][] InitialMatrix(string[] Vertex, string[] input)
    {
        int length = Vertex.Length;
        int[][] mat = new int[length][];
        for(int index = 0; index <length; index ++ )
        {
            mat[index] = new int[length];
            for(int column = 0; column < length; column ++)
                mat[index][column] = MARXVAL;
        }

        for(int index = 0 ; index< Vertex.Length; index ++)
        {
            if(!mapping.ContainsKey(Vertex[index]))
            {
                mapping.Add(Vertex[index],index);
            }
        }

        foreach(var item in input)
        {
            int start = mapping[item.Substring(0,1).Trim()];
            int end = mapping[item.Substring(1,1).Trim()];
            int data = int.Parse(item.Substring(2,1).Trim());
            mat[start][end] = data; 
        }
        

        return  mat;
    }
}