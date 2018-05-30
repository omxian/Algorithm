using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    /// <summary>
    /// 桶排序
    /// 可以使用List型或者使用ListNode
    /// 创建n个桶，每个桶有其区间
    /// 将数据依次插入某个特定桶
    /// 进行插入排序操作
    /// 从桶中取出归并
    /// </summary>
    public class BucketSort
    {
        private static int BUCKET_NUM = 20;
        public static void Sort(int[] arr)
        {
            //构建Bucket List
            List<List<int>> bucketList = new List<List<int>>();
            for (int i = 0; i < BUCKET_NUM; i++)
            {
                bucketList.Add(new List<int>());
            }

            //装桶
            int max = arr.Max();
            int min = arr.Min();
            float step = (max - min) / 1.0f / (BUCKET_NUM - 1);
            for (int i = 0; i < arr.Length; i++)
            {
                int num = arr[i];
                int bucketIdx = (int)Math.Floor((num - min) / step);
                bucketList[bucketIdx].Add(num);
            }

            //桶内排序
            for (int i = 0; i < bucketList.Count; i++)
            {
                InsertSort(bucketList[i]);
            }

            //归并
            Merge(arr,bucketList);
        }

        //插入排序
        private static void InsertSort(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                int current = list[i];
                for (int j = i - 1; j >= 0; j--) //索引0->索引i 已经排好了
                {
                    if (list[j] > current)
                    {
                        int temp = list[j];
                        list[j] = current;
                        list[j + 1] = temp;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        //将数据归并
        private static void Merge(int[] origin, List<List<int>> bucketList)
        {
            int idx = 0;

            for (int i = 0; i < bucketList.Count; i++)
            {
                for (int j = 0; j < bucketList[i].Count; j++)
                {
                    origin[idx] = bucketList[i][j];
                    idx++;
                }
            }
        }
    }
}
