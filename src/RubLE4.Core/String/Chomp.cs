
namespace RubLE4.String
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public static class Chomper
    {
        public static string Chomp(string s, params char[] trimChars)
        {
            return s.TrimEnd(trimChars);
        }

        public static string Chomp(string s)
        {
            return Chomp(s, Environment.NewLine.ToCharArray());
        }
    }

    namespace Extensions.Chomp
    {
        public static class X_4EEBE6D5_B57E_4c4c_BE65_F60D59261CF1
        {
            public static string Chomp(this string s)
            {
                return Chomper.Chomp(s);
            }
        }
    }
}

