﻿using System;
using System.Collections.Generic;

namespace SortingAlgorithm
{
    public class Util
    {
        /// <summary>
        /// string需要另行处理
        /// string是引用型，Equals判断的是引用是否相同
        /// </summary>
        public static bool CompareList(string[,] list1, string[,] list2)
        {
            if (list1.Length != list2.Length ||
                list1.GetUpperBound(0) != list2.GetUpperBound(0) ||
                list1.GetUpperBound(1) != list2.GetUpperBound(1))
            {
                return false;
            }

            for (int row = 0; row <= list1.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= list1.GetUpperBound(1); column++)
                {
                    if (list1[row, column] as string != list2[row, column] as string)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool CompareList<T>(T[,] list1, T[,] list2)
        {
            if (list1.Length != list2.Length ||
                list1.GetUpperBound(0) != list2.GetUpperBound(0) ||
                list1.GetUpperBound(1) != list2.GetUpperBound(1))
            {
                return false;
            }

            for (int row = 0; row <= list1.GetUpperBound(0); row++)
            {
                for (int column = 0; column <= list1.GetUpperBound(1); column++)
                {
                    if (!list1[row, column].Equals(list2[row, column]))
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// string需要另行处理
        /// string是引用型，Equals判断的是引用是否相同
        /// </summary>
        public static bool CompareList(IList<string> list1, IList<string> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (list1[i] as string != list2[i] as string)
                {
                    return false;
                }
            }

            return true;
        }


        public static bool CompareList<T>(IList<T> list1, IList<T> list2)
        {
            if (list1.Count != list2.Count)
            {
                return false;
            }

            for (int i = 0; i < list1.Count; i++)
            {
                if (!list1[i].Equals(list2[i]))
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 从数组中截取一部分成新的数组
        /// </summary>
        /// <param name="source">原数组</param>
        /// <param name="startIndex">原数组的起始位置</param>
        /// <param name="endIndex">原数组的截止位置</param>
        /// <returns></returns>
        public static T[] SplitArray<T>(T[] source, int startIndex, int endIndex)
        {
            try
            {
                T[] result = new T[endIndex - startIndex + 1];
                for (int i = 0; i <= endIndex - startIndex; i++)
                    result[i] = source[i + startIndex];
                return result;
            }
            catch (IndexOutOfRangeException ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private const int MaxIntNum = 1000;
        public static int[] GenRandomIntArr(int len = -1, int randomSeed = -1)
        {
            Random rd;
            if (randomSeed == -1)
            {
                rd = new Random();
            }
            else
            {
                rd = new Random(randomSeed);
            }

            if (len == -1)
            {
                len = rd.Next(0, MaxIntNum);
            }

            int[] result = new int[len];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = rd.Next();
            }
            return result;
        }
    }
}
