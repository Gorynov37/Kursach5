using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachLib
{
    abstract class SortClass<T> where T : IComparable
    {
        public int comparisons;
        public int transpositions;
        abstract public List<T> Sort(List<T> list);
    }

    class QuickSort<T> : SortClass<T> where T : IComparable
    {
        public override List<T> Sort(List<T> list)
        {
            //int p = left;
            //int L = left + 1;
            //int R = right;

            //while ((L <= right) && (mass[L] < mass[p])) L++;
            //while ((R >= left) && (mass[R] > mass[p])) R--;

            //if (R < L)
            //{
            //    Swap(p, R);
            //    QuickSort(left, R);
            //    QuickSort(L, right);
            //}
            //else Swap(L, R);
            return null;
        }
    }

    class SelectionSort<T> : SortClass<T> where T : IComparable
    {
        public override List<T> Sort(List<T> list)
        {
            Node<T> i = list.LastNode;
            while (!(i == list.FirstNode))
            {
                Node<T>.Swap(i, FindMax(list.FirstNode, i));
            }
            return list;
        }

        public Node<T> FindMax(Node<T> left, Node<T> right)
        {
            Node<T> max = right;
            Node<T> i = right.Prev;

            while (!(i == left))
            {
                if (i > max) max = i;
                i = i.Prev;
            }

            return max;
        }
    }
}
