using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    /// <summary>
    /// 选择排序，每次循环找出最大/最小的值放置到相应位置
    /// </summary>
    public class SelectionSort
    {
        private static int FindMin(int[] arr, int startIndex)
        {
            int minVal = arr[startIndex];
            int minIdx = startIndex;

            for (int i = startIndex + 1; i < arr.Length; i++)
            {
                if (minVal > arr[i])
                {
                    minVal = arr[i];
                    minIdx = i;
                }
            }

            return minIdx;
        }

        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = FindMin(arr, i);
                Util.Swap(arr, minIndex, i);
            }
        }
    }
}
