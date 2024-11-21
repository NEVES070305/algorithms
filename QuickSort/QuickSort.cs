
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class QuickSort
    {
        public static void QuickSortFunction(List<int> array, int low, int high)
        {
            if (low < high) 
            { 
                int pivotIndex = Partition(array, low, high);

                // Ordena recursivamente as sublistas
                QuickSortFunction(array, low, pivotIndex - 1); // Sublista esquerda
                QuickSortFunction(array, pivotIndex + 1, high); // Sublista direita
            }
        }
        public static int Partition(List<int> array, int low, int high)
        {
            // Escolhe o último elemento como pivô
            int pivot = array[high];
            int i = low - 1; // Índice para elementos menores que o pivô

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    // Troca os elementos
                    (array[i], array[j]) = (array[j], array[i]);
                }
            }

            // Coloca o pivô na posição correta
            (array[i + 1], array[high]) = (array[high], array[i + 1]);

            return i + 1; // Retorna o índice do pivô
        }

    }
}
