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
            if (startIndex < endIndex)
            {
                //分区操作
                int pivotIndex = Partition(arr, startIndex, endIndex);
                //将其他未排序的排好
                Sort(arr, startIndex, pivotIndex - 1);
                Sort(arr, pivotIndex + 1, endIndex);
            }
        }


        /// <summary>
        /// 分区Partition：
        ///     找到一个pivot,比它小的放到arr前面，比他大的放到arr后面，最后将pivot放到指定位置，一轮下来最少排好一个数字
        /// </summary>
        public static int Partition(int[] arr, int startIndex, int endIndex)
        {
            //循环结束pivot应该替换的位置,循环未结束，则是较大arr的开头
            int pivotIndex = startIndex;
            //需要比较的值,不同的快排此处可能有所不同
            int pivotVal = arr[endIndex];

            for (int i = startIndex; i < endIndex; i++)
            {
                if (arr[i] < pivotVal)
                {
                    Util.Swap(arr, i, pivotIndex);
                    pivotIndex++;
                }
            }

            //将pivot放到指定位置
            Util.Swap(arr, endIndex, pivotIndex);

            return pivotIndex;
        }
    }
}
