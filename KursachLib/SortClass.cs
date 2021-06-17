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
            if ((left == null) || (right == null)) return;
            if ((left == right) || (left == right.Next) || ((left.Prev == right))) return;

            Node p = null;
            Node R = right;

            while(R != left)
            {
                comparisons++;
                if ((p == null) && (R < left)) p = R;
                if ((p != null) && (R > left))
                {
                    transpositions++;
                    Node.Swap(R, p);
                    p = p.Prev;
                }
                R = R.Prev;
            }
            if (p == null) p = left;

            if (p != R)
            {
                transpositions++;
                Node.Swap(p, R);
            }

            QSort(left, p.Prev);
            QSort(p.Next, right);

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
                
                Node j = FindMax(list.FirstNode, i);
                if (i != j) 
                {
                    transpositions++;
                    Node.Swap(i, j);
                }
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
