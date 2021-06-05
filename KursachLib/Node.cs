using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachLib
{
    class Node<T> : IComparable<Node<T>> where T : IComparable
    {
        public T Element { get; private set; }
        public Node<T> Prev { get; private set; }
        public Node<T> Next { get; private set; }
        
        public void SetNext(T value)
        {
            Node<T> node = Next;
            Next = new Node<T>(value, this, node);
        }

        public void SetPrev(T value)
        {
            Node<T> node = Prev;
            Prev = new Node<T>(value, node, this);
        }

        public bool Pop()
        {
            bool b1 = this.Prev != null;
            bool b2 = this.Next != null;

            if (b1) Prev.Next = Next;
            if (b2) Next.Prev = Prev;

            return b1 || b2;
        }

        public Node<T> Copy()
        {
            return new Node<T>(Element, Prev, Next);
        }

        public Node<T> Step(int count)
        {
            Node<T> node = this.Copy();
            if (count >= 0)
            {
                for (int i = 0; i < count; i++)
                {
                    node = node.Next;
                    if (node == null) break;
                }
            }
            else
            {
                for (int i = 0; i < -count; i++)
                {
                    node = node.Prev;
                    if (node == null) break;
                }
            }
            return node;
        }

        public Node()
        {
            Element = default;
            Next = null;
            Prev = null;
        }
        public Node(T value)
        {
            Element = value;
            Next = null;
            Prev = null;
        }
        public Node(T value, Node<T> prev, Node<T> next)
        {
            Element = value;
            Next = next;
            Prev = prev;
        }

        public int CompareTo(Node<T> value) => this.Element.CompareTo(value.Element);
        public static bool operator >(Node<T> value1, Node<T> value2) => value1.Element.CompareTo(value2.Element) > 0;
        public static bool operator <(Node<T> value1, Node<T> value2) => value1.Element.CompareTo(value2.Element) < 0;
        public static bool operator >=(Node<T> value1, Node<T> value2) => value1.Element.CompareTo(value2.Element) >= 0;
        public static bool operator <=(Node<T> value1, Node<T> value2) => value1.Element.CompareTo(value2.Element) <= 0;
    }
}
