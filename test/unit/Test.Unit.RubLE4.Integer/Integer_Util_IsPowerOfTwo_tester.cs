
namespace Test.Unit.RubLE4.Integer
{
    using IntegerUtil = global::RubLE4.Integer.Util;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using System;
    using System.Linq;

    [TestClass]
    public class Integer_Util_IsPowerOfTwo_tester
    {
        private static readonly uint[] TwoPowers =
        {
            1,
            2,
            4,
            8,
            16,
            32,
            64,
            128,
            256,
            512,
            1024,
            2048,
            4096,
            8192,
            16384,
            32768,
            65536,
            131072,
            262144,
            524288,
            1048576,
            2097152,
            4194304,
            8388608,
            16777216,
            33554432,
            67108864,
            134217728,
            268435456,
            536870912,
            1073741824,
            2147483648,
        };

        [TestMethod]
        public void Test_valid_values_for_int()
        {
            foreach(uint i in TwoPowers)
            {
                Assert.IsTrue(IntegerUtil.IsPowerOfTwo((int)i), String.Format("{0} is not a power of two!", i));
            }
        }

        [TestMethod]
        public void Test_valid_values_for_uint()
        {
            foreach(uint i in TwoPowers)
            {
                Assert.IsTrue(IntegerUtil.IsPowerOfTwo((uint)i), String.Format("{0} is not a power of two!", i));
            }
        }

        [TestMethod]
        public void Test_valid_values_for_long()
        {
            foreach(uint i in TwoPowers)
            {
                Assert.IsTrue(IntegerUtil.IsPowerOfTwo((long)i), String.Format("{0} is not a power of two!", i));
            }
        }

        [TestMethod]
        public void Test_valid_values_for_ulong()
        {
            foreach(uint i in TwoPowers)
            {
                Assert.IsTrue(IntegerUtil.IsPowerOfTwo((ulong)i), String.Format("{0} is not a power of two!", i));
            }
        }

        [TestMethod]
        public void Test_negative_values()
        {
            Random rng = new Random(12345678);

            for(int i = 0; i != 2000000; ++i)
            {
                int v = rng.Next(int.MinValue, 0);

                Assert.IsFalse(IntegerUtil.IsPowerOfTwo(v), String.Format("{0} is a power of two!", v));
            }
        }

        [TestMethod]
        public void Test_some_invalid_values()
        {
            Random rng = new Random(12345678);

            for(int i = 0; i != 100000; ++i)
            {
                int v = rng.Next();

                if(!TwoPowers.Contains((uint)v))
                {
                    Assert.IsFalse(IntegerUtil.IsPowerOfTwo(v));
                }
            }
        }
    }
}
