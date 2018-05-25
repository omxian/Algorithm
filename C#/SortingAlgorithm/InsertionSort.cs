using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    /// <summary>
    /// 插入排序
    /// 类似扑克一张张抽，每次都排到对应位置
    /// 效率O(N平方),与冒泡排序相同
    /// </summary>
    public class InsertionSort
    {

        public static void ForSort(int[] data)
        {
            if (data.Length == 0)
            {
                return;
            }

            for (int i = 0; i < data.Length; i++)
            {
                int current = data[i];
                for (int j = i - 1; j >= 0; j--) //索引0->索引i 已经排好了
                {
                    if (data[j] > current)
                    {
                        int temp = data[j];
                        data[j] = current;
                        data[j + 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        public static void WhileSort(int[] data)
        {
            int i = 1;
            while (i < data.Length)
            {
                int j = i;
                while (j > 0 && data[j - 1] > data[j])
                {
                    int temp = data[j];
                    data[j] = data[j - 1];
                    data[j - 1] = temp;

                    j--;
                }
                i++;
            }
        }
    }
}
