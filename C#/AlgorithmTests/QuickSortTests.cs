using Microsoft.VisualStudio.TestTools.UnitTesting;
using Algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm.Tests
{
    [TestClass()]
    public class QuickSortTests
    {
        [TestMethod()]
        public void QuickSortTest()
        {
            for (int i = 0; i < 100; i++)
            {
                int[] originData = Util.GenRandomIntArr();
                int[] sortedData = (int[])originData.Clone();
                Array.Sort(sortedData);
                QuickSort.Sort(originData, 0, originData.Length - 1);
                Assert.IsTrue(Util.CompareList(originData, sortedData));
            }
        }
    }
}