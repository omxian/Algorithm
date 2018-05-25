using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    /// <summary>
    /// 归并排序,
    /// </summary>
    public class MergeSort
    {
        public static void Sort(int[] arr, int from, int to)
        {
            if (to > from)
            {
                int mid = (from + to) / 2;
                Sort(arr, from, mid);
                Sort(arr, mid + 1, to);
                Merge(arr, from, mid, to);
            }
        }

        private static void Merge(int[] arr,int from,int mid,int to)
        {
            int[] cloneArr = (int [])arr.Clone();
            int prevIndex = from;
            int nextIndex = mid + 1;
            int arrIndex = from;
            while (prevIndex <= mid && nextIndex <= to)
            {
                if (cloneArr[prevIndex] < cloneArr[nextIndex])
                {
                    arr[arrIndex] = cloneArr[prevIndex];
                    prevIndex++;
                }
                else
                {
                    arr[arrIndex] = cloneArr[nextIndex];
                    nextIndex++;
                }
                arrIndex++;
            }

            while (prevIndex <= mid)
            {
                arr[arrIndex] = cloneArr[prevIndex];
                prevIndex++;
                arrIndex++;
            }

            while (nextIndex <= to)
            {
                arr[arrIndex] = cloneArr[nextIndex];
                nextIndex++;
                arrIndex++;
            }
        }
    }
}
