using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class BubbleSort
    {
        public static void Sort(int[] arr) {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if(arr[j] > arr[j+1])
                    {
                        Util.Swap(arr, j, j + 1);
                    }
                }
            }
        }
    }
}
