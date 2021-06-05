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
            return null;
        }
    }

    class SelectionSort<T> : SortClass<T> where T : IComparable
    {
        public override List<T> Sort(List<T> list)
        {
            return null;
        }
    }
}
