using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    /// <summary>
    /// 奇偶排序
    /// </summary>
    public class OddEvenSort
    {
        public static void Sort(int[] arr)
        {
            bool sorted = false;
            while (!sorted)
            {
                sorted = true;
                for (int i = 0; i < arr.Length - 1; i = i + 2)
                {
                    if (arr[i] > arr[i + 1]) 
                    {
                        Util.Swap(arr, i, i + 1);
                        sorted = false;
                    }
                }

                for (int i = 1; i < arr.Length - 1; i = i + 2)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        sorted = false;
                        Util.Swap(arr, i, i + 1);
                    }
                }
            }
        }
    }
}
