using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class BubbleSort
    {
        public static List<int> BubbleSortFunction(List<int> list) 
        {
            for (int i = 0; i < list.Count; i++) 
            {
                bool swapped = false;
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int key = list[j];
                        list[j] = list[j+1];
                        list[j+1] = key;
                        swapped = true;
                    }
                }
                if (!swapped)
                    break;
            }
            return list;
        }
    }
}
