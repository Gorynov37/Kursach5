using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachLib
{

    public abstract class List
    {
        public int Length { get; protected set; }
        public abstract Node FirstNode { get; protected set; }
        public abstract Node LastNode { get; protected set; }
        public abstract void Remove(Node node);
        public abstract void Sort(SortClass sortObj);
        public abstract List Copy();
    }
    public class List<T> : List where T : IComparable
    {
        private Node<T> firstNode;
        private Node<T> lastNode;

        public override Node FirstNode
        {
            get
            {
                return firstNode;
            }
            protected set
            {

                firstNode = new Node<T>((value as Node<T>).Element, null, value.Next as Node<T>);
            }
        }
        public override Node LastNode
        {
            get
            {
                return lastNode;
            }
            protected set
            {
                lastNode = new Node<T>((value as Node<T>).Element, value.Prev as Node<T>, null);
            }
        }
        public override void Remove(Node node)
        {
            node.Pop();
            Length--;
        }
        public List()
        {
            firstNode = null;
            lastNode = null;
            Length = 0;
        }


        public void PushFront(T value)
        {
            if (Length == 0)
            {
                firstNode = new Node<T>(value);
                lastNode = firstNode;
                Length++;
            }
            else
            {
                firstNode.SetPrev(value);
                firstNode = firstNode.Prev as Node<T>;
                Length++;
            }
        }
        public void PushBack(T value)
        {
            if(Length == 0)
            {
                lastNode = new Node<T>(value);
                firstNode = lastNode;
                Length++;
            }
            else
            {
                lastNode.SetNext(value);
                lastNode = lastNode.Next as Node<T>;
                Length++;
            }
        }
        public void PopBack()
        {
            if (Length == 0) return;
            Node<T> node = lastNode;
            lastNode = lastNode.Prev as Node<T>;
            Remove(node);
        }
        public void PopFront()
        {
            if (Length == 0) return;
            Node<T> node = firstNode;
            firstNode = firstNode.Next as Node<T>;
            Remove(node);
        }

        public override List Copy()
        {
            List<T> list = new List<T>();
            Node<T> node = firstNode;
            list.PushBack(node.Element);

            while(node != lastNode)
            {
                node = node.Next as Node<T>;
                list.PushBack(node.Element);
            }

            return list;
        }
        public override void Sort(SortClass sortObj) => sortObj.Sort(this);

        public override string ToString()
        {
            string str = String.Empty;
            Node<T> node = firstNode;
            while (node != lastNode)
            {
                str += Convert.ToString(node.Element) + " ";
                node = node.Next as Node<T>;
            }
            str += Convert.ToString(node.Element);

            return str;
        }
    }
}
