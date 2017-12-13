using System;
using System.Text;

namespace myApp
{
    class Program
    {

        static int[] array = {1,2,4,7,11,15};

        static void Main(string[] args)
        {
             Node node = LinkedManager.ReverseLinkedNode( LinkedManager.GetNode("a,b,c,d,e"));

            while(node != null)
            {
                System.Console.Write(node.data);
                node = node.Next;
            }
           
        }

      static string GetBinary(int input)
      {
            int number = input;
            StringBuilder builder = new StringBuilder();
            while(number != 0)
            {
              builder.Append(number % 26);
              number = number/26;
            }
        return  builder.ToString();

      }


        static string ReverseStr(string input)
        {
            StringBuilder builder = new StringBuilder();
            for(int i = input.Length -1; i >= 0; i --)
            {
                builder.Append(input[i]);
            }
            return builder.ToString();
        }
       static int ReturnLongestString(string abc,out string output)
        {
            string result = string.Empty;
            System.Text.StringBuilder builder = new System.Text.StringBuilder();


            foreach(var item in abc)
            {
                int val = (int)item;
                if(val >=48 && val <=57)
                {
                    if(result.Length < builder.Length) result = builder.ToString();
                    if(builder.Length != 0)
                    {
                        
                        builder.Clear();
                    }
                }
                else
                {
                    builder.Append(item);
                }
            }

            if(result == string.Empty) result = builder.ToString();
             output = result;
            return result.Length;
        }


        static int[] Bubble(int [] input)
        {
            for(int i = 0; i<= input.Length-2; i ++)
              for(int j = i+1; j <= input.Length -1; j++)
              {
                  if(input[i] > input[j])
                  {
                      int buf;
                     buf = input[i];
                     input[i] = input[j];
                     input[j] = buf;
                  }
                
              }

              return input;
        }
        static LinkedNode ReverseLinkedNode(LinkedNode node)
        {
            LinkedNode head = node;
            LinkedNode previouse = null;
            while(head.Next != null)
            {
            
              LinkedNode temp = head;
              head= head.Next;
              temp.Next = previouse;
              previouse = temp;
               
            }

            head.Next = previouse;

            return head;
        }

        static int FBNQ(int n){
            if(n == 1|| n == 2)
            {
             return 1;
            }

            return FBNQ(n-1) + FBNQ(n-2);
        }

        static void IsDuplicateChar(Char[] input)
        {
            bool[] array = new bool [255];
            foreach(var item in input)
            {

              if(array[(int)item] == true)
              {
                  System.Console.WriteLine("this char is duplicated {0}", item);
              }
              else
              {
                  array[(int)item] = true;
              }
            }
        }


  static  LinkedNode IntialLinkedNode()
    {
        LinkedNode node1 = new LinkedNode(){data = "1"};
        LinkedNode node2= new LinkedNode(){data = "2"};
        LinkedNode node3 = new LinkedNode(){data = "3"};
        LinkedNode node4 = new LinkedNode(){data = "4"};

        node1.Next = node2;
        node2.Next = node3;
        node3.Next = node4;
   return node1;
        
    }

        static bool PrintTwoNumberSumAs(int sum, int[] array)
        {
            int first = 0;
            int end = array.Length -1;

            while(first< end)
            {
               var total = array[first] + array[end];
                if( total == sum)
                {
                     Console.WriteLine("{0} {1}", array[first], array[end]);
                     return true;
                }
                else if(total < sum)
                {
                    first ++;
                }
                else if(total > sum)
                {
                    end --;
                }
            }
          return false;

        }
    }

    class LinkedNode
    {
       public LinkedNode Next;
       public object data;
    }

   
   

}
