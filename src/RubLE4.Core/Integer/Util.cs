
namespace RubLE4.Integer
{
    using System;

    /// <summary>
    ///  Utility functions for dealing with integral types
    /// </summary>
    public static class Util
    {
        #region types

        #endregion

        #region constants

        #endregion

        #region fields

        private static readonly int[] PowersOfTwo256 = new int[256];
        #endregion

        #region construction

        static Util()
        {
            for(int i = 0; i != 256; ++i)
            {
                PowersOfTwo256[i] = -1;
            }

            PowersOfTwo256[1] = 0;
            PowersOfTwo256[2] = 1;
            PowersOfTwo256[4] = 2;
            PowersOfTwo256[8] = 3;
            PowersOfTwo256[16] = 4;
            PowersOfTwo256[32] = 5;
            PowersOfTwo256[64] = 6;
            PowersOfTwo256[128] = 7;
        }
        #endregion

        #region properties

        #endregion

        #region operations

        /// <summary>
        ///  Evaluates whether a given integer value is a power of 2
        /// </summary>
        /// <param name="i">
        ///  The integer
        /// </param>
        /// <returns>
        ///  <b>true</b> if a <paramref name="i"/> is a value of 2;
        ///  <b>false</b> otherwise
        /// </returns>
        public static bool IsPowerOfTwo(int i)
        {
            if(0 == i)
            {
                return false;
            }

            return 0 == (i & (i -1 ));
        }

        /// <summary>
        ///  Evaluates whether a given integer value is a power of 2
        /// </summary>
        /// <param name="i">
        ///  The integer
        /// </param>
        /// <returns>
        ///  <b>true</b> if a <paramref name="i"/> is a value of 2;
        ///  <b>false</b> otherwise
        /// </returns>
        [CLSCompliant(false)]
        public static bool IsPowerOfTwo(uint i)
        {
            if(0 == i)
            {
                return false;
            }

            return 0 == (i & (i -1 ));
        }

        /// <summary>
        ///  Evaluates whether a given integer value is a power of 2
        /// </summary>
        /// <param name="i">
        ///  The integer
        /// </param>
        /// <returns>
        ///  <b>true</b> if a <paramref name="i"/> is a value of 2;
        ///  <b>false</b> otherwise
        /// </returns>
        public static bool IsPowerOfTwo(long i)
        {
            if(0 == i)
            {
                return false;
            }

            return 0 == (i & (i -1 ));
        }

        /// <summary>
        ///  Evaluates whether a given integer value is a power of 2
        /// </summary>
        /// <param name="i">
        ///  The integer
        /// </param>
        /// <returns>
        ///  <b>true</b> if a <paramref name="i"/> is a value of 2;
        ///  <b>false</b> otherwise
        /// </returns>
        [CLSCompliant(false)]
        public static bool IsPowerOfTwo(ulong i)
        {
            if(0 == i)
            {
                return false;
            }

            return 0 == (i & (i -1 ));
        }

        /// <summary>
        ///  Returns the power of two represented by
        ///  <paramref name="n"/>; -1 otherwise
        /// </summary>
        /// <param name="n">
        ///  Must be a whole power of 2, i.e. between 1 and
        ///  <see cref="System.Int32.MaxValue"/>
        /// </param>
        /// <returns>
        ///  The power of the number if it is a power of 2;
        ///  <b>-1</b> otherwise
        /// </returns>
        public static int PowerOfTwo(int n)
        {
            uint ui = (uint)n;

            for(int i = 0; i != 4; ++i)
            {
                byte byte0 = (byte)(ui & 0x000000ff);

                ui >>= 8;

                if(0 != byte0)
                {
                    if(0 != ui)
                    {
                        return -1;
                    }
                    else
                    {
                        int r = PowersOfTwo256[byte0];

                        if(-1 != r)
                        {
                            r += 8 * i;
                        }

                        return r;
                    }
                }
            }

            return -1;
        }
        #endregion
    }
}
