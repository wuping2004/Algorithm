using System;
using System.Collections.Generic;

public class InputConsoleService : IInputService
{

    public IEnumerable<string> GetGraphInput()
    {
        string inputLine;
        System.Console.WriteLine("Please input graph inital data: (AB5, BC4, CD8, DC8, DE6, AD5, CE2, EB3, AE7 etc):");
        //inputLine = Console.ReadLine();
        inputLine = "AB5, BC4, CD8, DC8, DE6, AD5, CE2, EB3, AE7";
        foreach(var item in inputLine.Split(','))
        {
            yield return item.Trim();
        }
    }

   public IEnumerable<string> GetVertex()
    {
        string inputLine;
        System.Console.WriteLine("Please input graph Vertex: (A,B,C,D,E):");
       // inputLine = Console.ReadLine();
        inputLine = "A,B,C,D,E";
        foreach(var item in inputLine.Split(','))
        {
            yield return item.Trim();
        }
    }

}