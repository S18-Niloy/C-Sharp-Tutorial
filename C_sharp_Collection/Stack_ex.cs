using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp
{
    internal class Stack_ex
    {
        public static void Main(String[] args)
        {
            Stack st = new Stack();

            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Pop();

            foreach(var item in st)
            {
                Console.WriteLine(item);
            }

            Queue q = new Queue();

            q.Enqueue(2);
            q.Enqueue(3);
            q.Enqueue(4);
            q.Dequeue();

            foreach (var item in q)
            {
                Console.WriteLine(item);
            }

        }

       
    }
}
