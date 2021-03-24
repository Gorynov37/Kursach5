﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursachLib
{
    class SortInMassive
    {
        int[] mass;

        public SortInMassive(int[] M)
        {
            mass = M;
        }
        public SortInMassive(int size)
        {
            Random rnd = new Random();
            mass = new int[size];
            for(int i = 0; i < size; i++)
            {
                mass[i] = rnd.Next(-size, size);
            }
        }

        private void Swap(int first, int second)
        {
            int f = mass[first];
            mass[first] = mass[second];
            mass[second] = f;
        }

        public void QuickSort(int left, int right)
        {

        }

        public void SelectionSort(int left, int right)
        {
            for (int i = right; i >= left; i--)
            {
                Swap(i, FindMax(left, i));
            }
        }

        public int FindMax(int left, int right)
        {
            int max = right;
            for (int i = right - 1; i >= left; i--)
            {
                if (mass[i] > mass[max]) max = i;
            }
            return max;
        }
    }
}
