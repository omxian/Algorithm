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
    public class KMPAlgorithmTests
    {
        [TestMethod()]
        public void KMPTest()
        {
            KMPAlgorithm kmp = new KMPAlgorithm();
            Assert.AreEqual("ababc".IndexOf("a"), kmp.KMP("ababc", "a"));
            Assert.AreEqual("abaacabaaabaab".IndexOf("abaab"), kmp.KMP("abaacabaaabaab", "abaab"));
            Assert.AreEqual("ababaababc".IndexOf("ababc"), kmp.KMP("ababaababc", "ababc"));
            Assert.AreEqual("asdfsdf".IndexOf("tewtwe"), kmp.KMP("asdfsdf", "tewtwe"));
            Assert.AreEqual("ababsssaababc".IndexOf("sssa"), kmp.KMP("ababsssaababc", "sssa"));
            Assert.AreEqual("a".IndexOf("b"), kmp.KMP("a", "b"));
            Assert.AreEqual("a".IndexOf("a"), kmp.KMP("a", "a"));
            Assert.AreEqual("aaab".IndexOf("aab"), kmp.KMP("aaab", "aab"));
        }
    }
}