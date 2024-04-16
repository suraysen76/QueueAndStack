using System;
using System.Collections;
using System.Net.Security;

namespace CollectionsApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            char[] input = {'B','C','A','F' };
           
            Queue q = new Queue();

            foreach (char val in input)
            {
                q.Enqueue(val);
            }

            Console.WriteLine("************Queue******");

            PrintQueue(q);

            Console.WriteLine("Adding more in Queue");
            char[] input2 = { 'M', 'O', 'S', 'V' };
            foreach (char val in input2)
            {
                q.Enqueue(val);
            }
            Console.WriteLine("Removing some values ");
            RemoveFromQueue(q);
            RemoveFromQueue(q);
            RemoveFromQueue(q);

            PrintQueue(q);

            Console.WriteLine();
            Console.WriteLine("******Stack******");
            Stack st = new Stack();
            char[] input3 = { 'L', 'M', 'N', 'O' };
            foreach (char val in input3)
            {
                st.Push(val);
            }

            PrintStack(st);
            Console.WriteLine();
            Console.WriteLine("Removing values ");

            RemoveFromStack(st);
            RemoveFromStack(st);
            Console.WriteLine();


            PrintStack(st);
            Console.ReadKey();
        }
        private static void RemoveFromQueue(Queue q)
        {
            if (q.Count > 0)
            {
                char ch = (char)q.Dequeue();
                Console.WriteLine("The removed value: {0}", ch);
            }
        }
        private static void RemoveFromStack(Stack st)
        {
            if (st.Count > 0)
            {
                Console.WriteLine("The next poppable value in stack tp be removed: {0}", st.Peek());
                st.Pop();
            }
        }
        private static void PrintQueue(Queue q)
        {
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " ");
            Console.WriteLine();
        }
        private static void PrintStack(Stack st)
        {
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
        }
    }

    
  
}
