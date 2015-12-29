using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList list = new MyList();
            Console.WriteLine("Числа : ");
            list.printList();
            Console.ReadLine();
        }
    }

    class MyList
    {
       
        public Node First;
       
        public class Node
        {
            public int Data;
            public Node Next;
        }
        
        public void Add()
        {
            Node newNode = new Node();
            Console.WriteLine("Добавьте число:");
            newNode.Data = int.Parse(Console.ReadLine());
            if (First != null)
            {
                Node Second = First;
                while (Second.Next != null) Second = Second.Next;
                Second.Next = newNode;
            }
            else
            {
                First = newNode;
            }
        }
     
        public void printList()
        {
            Node Second = First;
            while (Second != null)
            {
                Console.WriteLine(Second.Data);
                Second = Second.Next;
            }
        }
        
        
        public MyList()
        {
            for (int i = 0; i < 3; i++) Add();
        }

    }

}    