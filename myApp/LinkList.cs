public class Node
{
  public    object data;
   public Node Next;
}


public class LinkedManager
{
  public  static Node GetNode(string input)
    {
        Node d = null;
        Node h=d;
        foreach(var item in input.Split(','))
        {
            if(d == null)
            {
                d = new Node(){ data = item  };
                h = d;
            }
            else
            {
                d.Next = new Node(){data = item};
                d = d.Next;
            }
        }

        return h;
    }

   public   static Node ReverseLinkedNode(Node link)
    {
       Node h = null;
       Node h_pre = null;

        while(link != null)
        {
            
         h_pre = h;
         h = link;
         link = link.Next;
         
         h.Next = h_pre;   
        }
        return h;
    }
}