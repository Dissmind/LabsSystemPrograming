using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.OldLabs.ForthLab
{
    class StringAlgorithms
    {
        // ====-- Algorithms for work with string --====

        public static string Sort(string str, bool positive)
        {
            StringBuilder strBuilder = new StringBuilder(str);

            // Buble sort
            for (int i = 0; i < strBuilder.Length; i++)
            {
                for (int j = i + 1; j < strBuilder.Length; j++)
                {
                    if (Comparision(strBuilder[i], strBuilder[j], positive))
                    {
                        char temp = strBuilder[i];
                        strBuilder[i] = strBuilder[j];
                        strBuilder[j] = temp;
                    }
                }
            }

            // Conversion to string
            str = "";

            for (int i = 0; i < strBuilder.Length; i++)
            {
                str += strBuilder[i];
            }

            return str;
        }

        private static bool Comparision(char a, char b, bool positive)
        {
            if (positive) return (a > b);
            else return (a < b);
        }



        // ====-- Algorithms for comparision --====


        public static bool PartialEquals(string IncludeString, string InsideString)
        {
            foreach (char i in IncludeString)
                foreach (char j in InsideString)
                    if (i == j) return true;

            return false;
        }
    }
}
