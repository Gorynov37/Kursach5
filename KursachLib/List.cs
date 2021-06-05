using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachLib
{
    class List<T> where T : IComparable
    {
        private Node<T> firstNode;
        private Node<T> lastNode;

        public int Length { get; private set; }
        public Node<T> FirstNode
        {
            get
            {
                return firstNode;
            }
            private set
            {
                firstNode = new Node<T>(value.Element, null, value.Next);
            }
        }
        public Node<T> LastNode
        {
            get
            {
                return lastNode;
            }
            private set
            {
                lastNode = new Node<T>(value.Element, value.Prev, null);
            }
        }
        public List()
        {
            FirstNode = null;
            LastNode = null;
            Length = 0;
        }

        public void PushFront(T value)
        {
            lastNode.SetPrev(value);
            lastNode = lastNode.Prev;
            Length++;
        }
        public void PushBack(T value)
        {
            lastNode.SetNext(value);
            lastNode = lastNode.Next;
            Length++;
        }
        public void PopBack()
        {
            if (Length == 0) return;
            Node<T> node = lastNode;
            lastNode = lastNode.Prev;
            if (node.Pop()) Length--;
        }
        public void PopFront()
        {
            if (Length == 0) return;
            Node<T> node = firstNode;
            lastNode = lastNode.Next;
            if (node.Pop()) Length--;
        }



    }
}
