﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class MergeSort
    {
        public static void MergeSortFunction(int[] array)
        {
            if (array.Length <= 1)
                return;

            int mid = array.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[array.Length - mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);

            MergeSortFunction(left);
            MergeSortFunction(right);

            // Mesclar as duas metades ordenadas
            Merge(array, left, right);
        }

        public static void Merge(int[] array, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length) 
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }
                k++;
            }

            while (i < left.Length)
            {
                array[k] = left[i];
                i++;
                k++;
            }
            // Adicionar elementos restantes de right
            while (j < right.Length)
            {
                array[k] = right[j];
                j++;
                k++;
            }
        }
    }
}
