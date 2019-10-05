using System;
using LatinizeThis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest
{
    [TestClass]
    public class LatinizeGreek_Test
    {
        [TestMethod]
        public void Test()
        {
            var text = "αβγδεζηθικλμνξοπρστυφχψωάέίήόώ";
            var expected = "abgdezithiklmnksoprstufchpsoaeiioo";
            var latinized = LatinizeGreek.FromGreek(text);
            Assert.AreEqual(latinized, expected);
        }
    }
}
