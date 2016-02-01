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
        public Node Last;
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
            if (Last != null)
            {
              
                
                Last.Next = newNode;
                Last = newNode;
            }
            else
            {
                First = newNode;
                Last = First;
            }
        }
        public void Add2()
        {
            Node newNode = new Node();
            Console.WriteLine("Добавьте число:");
            newNode.Data = int.Parse(Console.ReadLine());
            if (First != null)
            {
                if (First.Next == null)

                {
                    Last = newNode;
                }
                    newNode.Next = First.Next;
                    First.Next = newNode;

                }
            
            else
            {
                First = newNode;
                Last = First;
            }
        }
        public void Add3()
        {
            Node newNode = new Node();
            Console.WriteLine("Добавьте число:");
            newNode.Data = int.Parse(Console.ReadLine());
            if (First != null)
            {
                if (First.Next.Next == null)

                {
                    Last = newNode;
                }
                newNode.Next = First.Next.Next;
                First.Next.Next = newNode;

            }

            else
            {
                First = newNode;
                Last = First;
            }
        }
        public void Add_one()
        {
            Node newNode = new Node();
            Console.WriteLine("Добавьте число:");
            newNode.Data = int.Parse(Console.ReadLine());
            if (First != null)
            {


                newNode.Next = First;
                First = newNode;
                

                
                
               
            }
            else
            {
                First = newNode;
                Last = newNode;
            }
        }
        public void printList()
        {
            Node Last = First;
            while (Last != null)
            {
                Console.WriteLine(Last.Data);
                Last = Last.Next;
            }
        }

        public void del_first()
        {
            if (First != null)
            {
                First = First.Next;
                if (Last != null)

                {

                    Last = null;
                }

            }
            
           
           
           
           
        }
        public MyList()
        {

            Add();
            del_first();
            //Add();
            //Add();
           
            //Add();

           
            
            //Add2();
           // Add();
            //Add_one();
            //Add_one();
            //Add2();
        }

    }

}    