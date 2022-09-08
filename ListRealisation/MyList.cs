using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListRealisation
{
    class MyList<T>
    {
        public int Length { get; private set; }

        Node<T> root;

        public MyList(T n)
        {
            root = new Node<T>(n);
            Length = 1;
        }
        public MyList()
        {
            root = null;
            Length = 0;
        }
        public void RemoveAt(int index)
        {
            if (index == 0)
            {
                if (root == null)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (root.GetNext() != null)
                {
                    root = root.GetNext();
                    Length--;
                }
            }
            else if (index > 0 && index < Length)
            {
                Remove(index);
                Length--;
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        private void Remove(int index)
        {
            void Remove1(int ind, Node<T> node)
            {
                if (ind == 1)
                {
                    if (node.GetNext() != null)
                    {
                        if (node.GetNext().GetNext() != null)
                        {
                            node.SetNext(node.GetNext().GetNext());
                        }
                    }
                }
                else
                {
                     Remove1(ind - 1, node.GetNext());
                }
            }

            Remove1(index, root);
        }


        public void Add(T n)
        {
            if (root == null)
            {
                root = new Node<T>(n);
                Length = 1;
            }
            else
            {
                root.Add(n);
                Length++;
            }
        }

        private T GetT(int index)
        {
            T GetT1(int ind, Node<T> node)
            {
                if (ind == 0)
                {
                    return node.Value;
                }
                else
                {
                    return GetT1(ind - 1, node.GetNext());
                }
            }

            return GetT1(index, root);
        }

        private void SetT(int index, T Val)
        {
            void SetT1(int ind, Node<T> node)
            {
                if (ind == 0)
                {
                    node.Value = Val;
                }
                else
                {
                    SetT1(ind - 1, node.GetNext());
                }
            }

            SetT1(index, root);
        }


        public T this[int i]
        {
            get
            {
                if (i>=0&&i<Length)
                {
                    return GetT(i);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (i >= 0 && i < Length)
                {
                    SetT(i, value);
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
         
        }


    }
}
