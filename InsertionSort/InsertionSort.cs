using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    internal class InsertionSort
    {
        public static List<int> InsertionSortFunction(List<int> listToOrg) 
        {
            for (int i = 1; i < listToOrg.Count; i++)
            {
                int key = listToOrg[i];
                int j = i - 1;
                while (j >= 0 && listToOrg[j] > key)
                {
                    listToOrg[j + 1] = listToOrg[j];
                    j--;
                }
                listToOrg[j + 1] = key;
         
            }
            return listToOrg;
        }
    }
}
