using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm.Tests
{
    [TestClass()]
    public class BubbleSortTests
    {
        [TestMethod()]
        public void BubbleSortTest()
        {
            for (int i = 0; i < 100; i++)
            {
                int[] originData = Util.GenRandomIntArr();
                int[] sortedData = (int[])originData.Clone();
                Array.Sort(sortedData);
                BubbleSort.Sort(originData);
                Assert.IsTrue(Util.CompareList(originData, sortedData));
            }
        }

        [TestMethod()]
        public void CocktailSortTest()
        {
            for (int i = 0; i < 100; i++)
            {
                int[] originData = Util.GenRandomIntArr();
                int[] sortedData = (int[])originData.Clone();
                Array.Sort(sortedData);
                BubbleSort.CocktailSort(originData);
                Assert.IsTrue(Util.CompareList(originData, sortedData));
            }
        }
    }
}