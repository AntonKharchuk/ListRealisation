using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRealisation
{
    class Node<T>
    {
        public T Value;

        private Node<T> Next;

        public Node(T v)
        {
            Value = v;
            
        }

        public void SetNext(Node<T> val) => Next = val;

        public Node<T> GetNext() => Next;

        public void Add(T val)
        {
            if (Next == null)
            {
                Next = new Node<T>(val);
            }
            else
            {
                Next.Add(val);
            }
        }


    }
}
