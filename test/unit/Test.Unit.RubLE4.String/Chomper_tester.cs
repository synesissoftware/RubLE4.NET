
namespace Test.Unit.RubLE4.String
{
    using Chomper = global::RubLE4.String.Chomper;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;

    [TestClass]
    public class Chomper_tester
    {
        [TestMethod]
        public void Test_1()
        {
            Assert.AreEqual("", Chomper.Chomp(""));
            Assert.AreEqual("a", Chomper.Chomp("a"));
            Assert.AreEqual("abc", Chomper.Chomp("abc"));
        }

        [TestMethod]
        public void Test_2()
        {
            Assert.AreEqual("", Chomper.Chomp("\n"));
            Assert.AreEqual("a", Chomper.Chomp("a\n"));
            Assert.AreEqual("abc", Chomper.Chomp("abc\n"));
        }
    }
}
