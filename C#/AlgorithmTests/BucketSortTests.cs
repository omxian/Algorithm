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
    public class BucketSortTests
    {
        [TestMethod()]
        public void BucketSortTest()
        {
            for (int i = 0; i < 100; i++)
            {
                int[] originData = Util.GenRandomIntArr();
                int[] sortedData = (int[])originData.Clone();
                Array.Sort(sortedData);
                BucketSort.Sort(originData);
                Assert.IsTrue(Util.CompareList(originData, sortedData));
            }
        }
    }
}