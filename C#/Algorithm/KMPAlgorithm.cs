using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class KMPAlgorithm
    {
        public int KMP(string main, string pattern)
        {
            List<int> next = GetNext(pattern);

            int i = 0, j = 0;

            while (i < main.Length && j < pattern.Length)
            {
                if (j == -1 || main[i] == pattern[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    j = next[j];
                }
            }

            return j == pattern.Length ? i - j : -1;
        }

        //其实执行的就是自己和自己错一位比较
        //计算出最长共同子串
        public List<int> GetNext(string pattern)
        {
            //出于编程方便原因，首位设置为-1
            List<int> next = new List<int>() { -1, 0 };

            int j = 0;
            //没有必要判断完，后面的一位没有用的
            for (int i = 1; i < pattern.Length - 1; i++)
            {
                if (pattern[i] == pattern[j])
                {
                    j++;
                    next.Add(j);
                }
                else
                {
                    j = 0;
                    next.Add(j);
                }
            }

            return next;
        }
    }
}
