using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    public class BubbleSort
    {
        /// <summary>
        /// 普通冒泡排序
        /// </summary>
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Util.Swap(arr, j, j + 1);
                    }
                }
            }
        }

        /// <summary>
        /// 鸡尾酒排序,定向冒泡排序,是冒泡排序的一种变形
        /// </summary>
        /// <param name="arr"></param>
        public static void CocktailSort(int[] arr)
        {
            bool swaped = true;
            int rightIndex = 0;
            int leftIndex = arr.Length - 1;

            while (swaped && leftIndex > rightIndex)
            {
                swaped = false;

                for (int j = rightIndex; j < leftIndex ; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Util.Swap(arr, j, j + 1);
                        swaped = true;
                    }
                }

                leftIndex--;


                for (int j = leftIndex; j >= rightIndex + 1; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Util.Swap(arr, j, j - 1);
                        swaped = true;
                    }
                }

                rightIndex++;
            }
        }
    }
}
