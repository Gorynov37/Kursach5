using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachLib
{
    public abstract class Node : IComparable<Node>
    {
        public Node Prev { get; protected set; }
        public Node Next { get; protected set; }
        public void SetPrev(Node node)
        {
            Node n = node.Copy();
            n.Prev = Prev;
            n.Next = this;
            Prev.Next = n;
            Prev = n;
        }
        public void SetNext(Node node)
        {
            Node n = node.Copy();
            n.Prev = Prev;
            n.Next = this;
            Prev.Next = n;
            Prev = n;
        }
        public Node Pop()
        {
            Node node = this;
            bool b1 = this.Prev != null;
            bool b2 = this.Next != null;

            if (b1) Prev.Next = Next;
            if (b2) Next.Prev = Prev;

            node.Next = null;
            node.Prev = null;

            return node;
        }
        public static void Swap(Node node1, Node node2) => node1.Swap(node2);
        protected abstract void Swap(Node node);
        public abstract Node Copy();
        public abstract int CompareTo(Node value);
        public static bool operator >(Node value1, Node value2) => value1.CompareTo(value2) > 0;
        public static bool operator <(Node value1, Node value2) => value1.CompareTo(value2) < 0;
        public static bool operator >=(Node value1, Node value2) => value1.CompareTo(value2) >= 0;
        public static bool operator <=(Node value1, Node value2) => value1.CompareTo(value2) <= 0;
    }

    public class Node<T> : Node where T : IComparable
    {
        public T Element { get; private set; }
        protected override void Swap(Node node)
        {
            if (!(node is Node<T> n)) throw new Exception("node as Node<T> = 0");

            T value = n.Element;
            n.Element = Element;
            Element = value;
        }

        public void SetNext(T value)
        {
            Node node = Next;
            Next = new Node<T>(value, this, (Node<T>)node);
        }

        public void SetPrev(T value)
        {
            Node node = Prev;
            Prev = new Node<T>(value, (Node<T>)node, this);
        }

        public override Node Copy()
        {
            return new Node<T>(Element, Prev as Node<T>, Next as Node<T>);
        }

        public Node<T> Step(int count)
        {
            Node node = this;
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
            return node as Node<T>;
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

        public override int CompareTo(Node value)
        {
            if (value == null) throw new Exception("value == null");
            if (!(value is Node<T> node)) throw new Exception("node == null");
            else return this.Element.CompareTo(node.Element);
        }
        
    }
}
