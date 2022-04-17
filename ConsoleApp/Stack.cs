using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thang_BT
{
    internal class Stack
    {
        private int t;
        private int[] st;
        public bool empty()
        {
            return (t == -1);
        }
        public bool full()
        {
            return (t >= st.Length);
        }
        public Stack()
        {
            t = -1;
            st = new int[3];
            
        }
        public void Push(int x)
        {
           t++;
            if (!full())
            {
                st[t] = x;
            }
            else
                 Console.WriteLine("Stack full");
        }
        public int Pop()
        {
            if (empty())
            {
                Console.WriteLine("Stack rong");
                return 0;
            }
            else
            {
                if (full())
                {
                    t = st.Length-1;
                }
                
                 return st[t--];
            }
        }
        public class stack
        {
             public stack()
             {
                Stack showStack = new Stack();
                int n;
                Console.Write("Nhap so phan tu cua Stack n=");
                n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    int a;
                    Console.Write($"Nhap so can them vao Stack:{i} ");
                    a=int.Parse(Console.ReadLine());
                    showStack.Push(a);

                }
                Console.WriteLine("Show cac phan tu da them vao, Pop");
                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine(showStack.Pop());
                }
             }

        }
    }
}
