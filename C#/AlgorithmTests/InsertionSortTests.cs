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
    public class InsertionSortTests
    {
        [TestMethod()]
        public void InsertionSortTest()
        {
            for (int i = 0; i < 100; i++)
            {
                int[] originData = Util.GenRandomIntArr();
                int[] sortedData = (int[])originData.Clone();
                Array.Sort(sortedData);
                InsertionSort.ForSort(originData);
                Assert.IsTrue(Util.CompareList(originData, sortedData));
            }
        }

        [TestMethod()]
        public void InsertionSortWhileTest()
        {
            for (int i = 0; i < 100; i++)
            {
                int[] originData = Util.GenRandomIntArr();
                int[] sortedData = (int[])originData.Clone();
                Array.Sort(sortedData);
                InsertionSort.WhileSort(originData);
                Assert.IsTrue(Util.CompareList(originData, sortedData));
            }
        }
    }
}