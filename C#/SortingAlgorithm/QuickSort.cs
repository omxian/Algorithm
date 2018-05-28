using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    /// <summary>
    /// 快速排序
    /// </summary>
    public class QuickSort
    {
        public static void Sort(int[] arr,int startIndex, int endIndex)
        {
            if (endIndex <= startIndex)
            {
                return;
            }

            int i = startIndex; //用于遍历arr[startIndex -> endIndex]
            int p = startIndex; //循环结束pivot应该替换的位置,循环未结束，则是较大arr的开头
            int pivot = arr[endIndex];//需要比较的值,不同的快排此处可能有所不同
            for (; i < endIndex; i++)
            {
                if (arr[i] < pivot)
                {
                    Util.Swap(arr,i,p);
                    p++;
                }
            }
            Util.Swap(arr, endIndex, p);
            Sort(arr, startIndex, p - 1);
            Sort(arr, p + 1, endIndex);
        }
    }
}
