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
        public Node Second;
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
                if (First.Next == null)

                {
                    First.Next = newNode;
                    Second = newNode;
                }
                else
                {
                    Second.Next = newNode;
                    Second = newNode;
                }
                
            }
            else
            {
                First = newNode;
            }
        }
        public void Add2()
        {
            Node newNode = new Node();
            Console.WriteLine("Добавьте число:");
            newNode.Data = int.Parse(Console.ReadLine());
            if (First != null)
            {
                if (Second == null)
                {
                    First.Next = newNode;
                    Second = newNode;
                }
               else
                {
                    Second = First.Next;
                    First.Next = newNode;
                    newNode.Next = Second;
                    
                    

                     

                }
            }
            else
            {
                Console.WriteLine("нет первого числа");
            }
        }
        public void Add_one()
        {
            Node newNode = new Node();
            Console.WriteLine("Добавьте число:");
            newNode.Data = int.Parse(Console.ReadLine());
            if (First != null)
            {
                Second = First ;
                First = newNode;
                First.Next = Second;
               
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
            Add();
            Add();
            Add();
            Add();
            Add2();
            Add_one();
        }

    }

}    