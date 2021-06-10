using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachLib
{
    public abstract class SortClass
    {
        public int comparisons;
        public int transpositions;
        abstract public void Sort(List list);
    }

    public class QuickSort : SortClass
    {
        public override void Sort(List list)
        {
            comparisons = 0;
            transpositions = 0;

            QSort(list.FirstNode, list.LastNode);
        }

        public void QSort(Node left, Node right)
        {
            if ((left == right) || (left == right.Next)) return;
            Node p = left;
            Node L = left.Next;
            Node R = right;

            while (L != right.Next)
            {
                comparisons++;
                if (L < p) L = L.Next;
                else break;
            }


            while (R != left)
            {
                comparisons++;
                if (R >= p) R = R.Prev;
                else break;

            }

            bool b = false;
            Node node = R;
            if ((R != L) && (R.Prev != L)) do
            {
                node = node.Next;
                if (node == L)
                {
                    b = true;
                    break;
                }

            } while (node != right.Next);


            transpositions++;
            if (b)
            {
                Node.Swap(p, R);
                QSort(left, R);
                QSort(L, right);
            }
            else
            {
                Node.Swap(L, R);
                QSort(left, right);
            }
        }
    }

    public class SelectionSort : SortClass
    {
        public override void Sort(List list)
        {
            comparisons = 0;
            transpositions = 0;
            Node i = list.LastNode;
            while (i != list.FirstNode)
            {
                transpositions++;
                Node.Swap(i, FindMax(list.FirstNode, i));
                i = i.Prev;
            }
        }

        public Node FindMax(Node left, Node right)
        {
            Node max = right;
            Node i = right.Prev;

            while (i != left)
            {
                comparisons++;
                if (i > max) max = i;
                i = i.Prev;
            }
            comparisons++;
            if (left > max) max = left;

            return max;
        }
    }
}
