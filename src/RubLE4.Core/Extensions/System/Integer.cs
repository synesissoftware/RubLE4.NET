
namespace RubLE4.Extensions.System.Integer
{
    using global::System;

    /// <summary>
    ///  Extensions class that introduces as extensions methods
    ///  from <see cref="RubLE4.Integer.Util"/>
    /// </summary>
    public static class X_96541134_3693_48f3_9490_59BD5C4B3A46
    {
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
        public static bool IsPowerOfTwo(this int i)
        {
            return global::RubLE4.Integer.Util.IsPowerOfTwo(i);
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
        public static bool IsPowerOfTwo(this uint i)
        {
            return global::RubLE4.Integer.Util.IsPowerOfTwo(i);
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
        public static bool IsPowerOfTwo(this long i)
        {
            return global::RubLE4.Integer.Util.IsPowerOfTwo(i);
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
        public static bool IsPowerOfTwo(this ulong i)
        {
            return global::RubLE4.Integer.Util.IsPowerOfTwo(i);
        }

    }
}
