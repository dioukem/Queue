using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_using_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Patient p = new Patient("Baron Smith", 2003);
            Patient p1 = new Patient("Karl To", 1978);
            Patient p2 = new Patient("Chun ch", 1999);
            Patient p3 = new Patient("Mars Kelo", 1980);
            LinkedQueue<Patient> q = new LinkedQueue<Patient>();

            q.Enqueue(p);
            q.Enqueue(p1);
            q.Enqueue(p2);
            q.Enqueue(p3);


            q.PrintQueu(); 
            q.Dequeue();

            Console.WriteLine("-------------------");
            q.PrintQueu();
            

            Console.WriteLine("\nPress enter to finish");
            Console.Read();
        }
    }

    public class Node<T>
    {
        public T Data { get; private set; }
        public Node<T> Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedQueue<T>
    {
        Node<T> first;
        Node<T> last;

        public LinkedQueue()
        {
            first = null;
            last = null;
        }

        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (first == null)
            {

                newNode.Next = null;
                first = newNode;
                last = newNode;
                
            }else
            {
                last.Next = newNode;
                last = newNode;

            }
            //Console.WriteLine("Enqueued " + data);
            
        }
        public void Dequeue()
        {
            if (first == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            Console.WriteLine("Value dequeue is "+first.Data);
            first = first.Next;
            
        }

        public void PrintQueu()
        {
            Node<T> iter = first;
            if (iter == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while(iter != null)
            {
                Console.WriteLine(iter.Data.ToString());
                iter = iter.Next;

            }


        }

        

    }
    public class Patient
    {
        public string Name { get; set; }
        public int Dob { get; set; }

        public Patient(string name, int dob)
        {
            Name = name;
            Dob = dob;
        }

        public override string ToString()
        {
            return ("Name: " + Name + " DOB: " + Dob);
        }
        


    }
}
