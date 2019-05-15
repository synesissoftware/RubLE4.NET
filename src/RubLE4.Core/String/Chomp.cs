
namespace RubLE4.String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    ///  Provides string chomping
    /// </summary>
    public static class Chomper
    {
        /// <summary>
        ///  Performs a chomp on <paramref name="s"/>, trimming
        ///  all trailing characters specified in
        ///  <paramref name="trimChars"/>
        /// </summary>
        /// <param name="s">
        ///  The string to be chomped
        /// </param>
        /// <param name="trimChars">
        ///  The characters to trim
        /// </param>
        /// <returns>
        ///  The chomped result
        /// </returns>
        public static string Chomp(string s, params char[] trimChars)
        {
            return s.TrimEnd(trimChars);
        }

        /// <summary>
        ///  Performs a chomp on <paramref name="s"/>
        /// </summary>
        /// <param name="s">
        ///  The string to be chomped
        /// </param>
        /// <returns>
        ///  The chomped result
        /// </returns>
        public static string Chomp(string s)
        {
            return Chomp(s, Environment.NewLine.ToCharArray());
        }
    }

    namespace Extensions.System.String.Chomp
    {
        /// <summary>
        ///  Extensions class that introduces as extensions methods
        ///  from <see cref="RubLE4.String.Chomper"/>
        /// </summary>
        public static class X_4EEBE6D5_B57E_4c4c_BE65_F60D59261CF1
        {
            /// <summary>
            ///  Performs a chomp on <paramref name="s"/>
            /// </summary>
            /// <param name="s">
            ///  The string to be chomped
            /// </param>
            /// <returns>
            ///  The chomped result
            /// </returns>
            public static string Chomp(this string s)
            {
                return Chomper.Chomp(s);
            }
        }
    }
}

