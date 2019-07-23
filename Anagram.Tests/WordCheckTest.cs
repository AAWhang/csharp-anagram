using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram.Models;
using System.Collections.Generic;

namespace Anagram.Tests
{
    [TestClass]
    public class AnagramCHeckTest
    {
        [TestMethod]
        public void WordChecker_catchesAnanagramSingle_rats()
        {
            AnagramCheck bananagram = new AnagramCheck();
            List<string> tester = new List<string>(1) {"rats"};
            Assert.AreEqual("rats", bananagram.WordChecker("star", tester));
        }
    }
}
