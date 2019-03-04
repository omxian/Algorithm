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
            int[] next = new int[pattern.Length];
            GetNext(pattern, next);

            //主串索引i不会重复索引
            //模式串索引j在遇到失配的时会从next[j]继续查找
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

        //其实执行的就是自己和自己错开一位比较
        //计算出串 前缀、后缀 的最长共同子串
        //next是固定长度的，因此使用array节省性能
        public void GetNext(string pattern, int[] next)
        {
            //出于编程方便原因，首位设置为-1
            next[0] = -1;
            int i = 0;
            int j = -1;
            //没有必要判断完，后面的一位没有用的
            while (i < pattern.Length - 1)
            {
                if (j == -1 || pattern[i] == pattern[j])
                {
                    //观察可以知道第二位数next[1],如果有的话恒为0
                    //这个0出于共同子串的定义：前缀、后缀的共同子串不能包括自己（如串"a"没有共同子串）
                    j++;
                    i++;
                    next[i] = j;
                }
                else
                {
                    j = next[j];
                }
            }
        }
    }
}
