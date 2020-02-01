using Labs.OldLabs.ForthLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labs.OldLabs
{
    class Lab4
    {
        private static string StringA;
        private static string StringB;

        public static void Calculate(ref string aStr, ref string bStr)
        {
            // String init in class
            StringA = aStr;
            StringB = bStr;


            if (ComparisonStringAlgorithms()) IfTrueAlgorithms();
            else IfFalseAlgorithms();

            // String init in form
            aStr = StringA;
            bStr = StringB;
        }

        private static bool ComparisonStringAlgorithms()
        { 
            switch (Configuration.Variant)
            {
                case "1": return StringAlgorithms.PartialEquals(StringA, StringB);
                default: return false;
            }
        }

        private static void IfTrueAlgorithms()
        {
            switch (Configuration.Variant)
            {
                case "1":
                    StringA = StringAlgorithms.Sort(StringA, true);
                    break;
            }
        }

        private static void IfFalseAlgorithms()
        {
            switch (Configuration.Variant)
            {
                case "1":
                    StringA = StringAlgorithms.Sort(StringA, false);
                    break;
            }
        }
    }
}
