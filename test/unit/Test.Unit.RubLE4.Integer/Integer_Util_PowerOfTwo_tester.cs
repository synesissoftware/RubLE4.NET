
namespace Test.Unit.RubLE4.Integer
{
    using IntegerUtil = global::RubLE4.Integer.Util;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.Linq;

    [TestClass]
    public class Integer_Util_PowerOfTwo_tester
    {
        [TestMethod]
        public void Test_various_non_negative_numbers()
        {
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(0));
            Assert.AreEqual(0, IntegerUtil.PowerOfTwo(1));
            Assert.AreEqual(1, IntegerUtil.PowerOfTwo(2));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(3));
            Assert.AreEqual(2, IntegerUtil.PowerOfTwo(4));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(5));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(6));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(7));
            Assert.AreEqual(3, IntegerUtil.PowerOfTwo(8));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(15));
            Assert.AreEqual(4, IntegerUtil.PowerOfTwo(16));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(17));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(31));
            Assert.AreEqual(5, IntegerUtil.PowerOfTwo(32));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(33));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(63));
            Assert.AreEqual(6, IntegerUtil.PowerOfTwo(64));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(65));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(127));
            Assert.AreEqual(7, IntegerUtil.PowerOfTwo(128));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(129));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(255));
            Assert.AreEqual(8, IntegerUtil.PowerOfTwo(256));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(257));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(255));
            Assert.AreEqual(9, IntegerUtil.PowerOfTwo(512));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(257));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(1023));
            Assert.AreEqual(10, IntegerUtil.PowerOfTwo(1024));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(1025));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(2047));
            Assert.AreEqual(11, IntegerUtil.PowerOfTwo(2048));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(2049));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(4095));
            Assert.AreEqual(12, IntegerUtil.PowerOfTwo(4096));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(4097));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(8191));
            Assert.AreEqual(13, IntegerUtil.PowerOfTwo(8192));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(8193));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(16383));
            Assert.AreEqual(14, IntegerUtil.PowerOfTwo(16384));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(16385));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(32767));
            Assert.AreEqual(15, IntegerUtil.PowerOfTwo(32768));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(32769));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(65535));
            Assert.AreEqual(16, IntegerUtil.PowerOfTwo(65536));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(65537));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(131071));
            Assert.AreEqual(17, IntegerUtil.PowerOfTwo(131072));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(131073));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(262143));
            Assert.AreEqual(18, IntegerUtil.PowerOfTwo(262144));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(262145));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(524287));
            Assert.AreEqual(19, IntegerUtil.PowerOfTwo(524288));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(524289));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(1048575));
            Assert.AreEqual(20, IntegerUtil.PowerOfTwo(1048576));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(1048577));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(2097151));
            Assert.AreEqual(21, IntegerUtil.PowerOfTwo(2097152));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(2097153));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(4194303));
            Assert.AreEqual(22, IntegerUtil.PowerOfTwo(4194304));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(4194305));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(8388607));
            Assert.AreEqual(23, IntegerUtil.PowerOfTwo(8388608));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(8388609));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(16777215));
            Assert.AreEqual(24, IntegerUtil.PowerOfTwo(16777216));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(16777217));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(33554431));
            Assert.AreEqual(25, IntegerUtil.PowerOfTwo(33554432));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(33554433));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(67108863));
            Assert.AreEqual(26, IntegerUtil.PowerOfTwo(67108864));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(67108865));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(134217727));
            Assert.AreEqual(27, IntegerUtil.PowerOfTwo(134217728));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(134217729));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(268435455));
            Assert.AreEqual(28, IntegerUtil.PowerOfTwo(268435456));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(268435457));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(536870911));
            Assert.AreEqual(29, IntegerUtil.PowerOfTwo(536870912));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(536870913));

            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(1073741823));
            Assert.AreEqual(30, IntegerUtil.PowerOfTwo(1073741824));
            Assert.AreEqual(-1, IntegerUtil.PowerOfTwo(1073741825));
        }

        [TestMethod]
        public void Test_negative_numbers()
        {
            ;
        }
    }
}
