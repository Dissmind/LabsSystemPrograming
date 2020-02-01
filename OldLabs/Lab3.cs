using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.OldLabs
{
    class Lab3
    {
        public static string Calculate(string strArray)
        {
            // Conversion string in int array
            int[] array = ConversionArray(strArray);

            // Algorithm calculation
            int result = algorithms(array);

            return result.ToString();
        }

        public static int[] ConversionArray(string str)
        {
            // Counting size array
            int arrayLength = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') arrayLength++;
            }

            int[] array = new int[arrayLength + 1];


            // Array filling
            string variableHelper = "";
            int count = 0;
            str += " ";
            foreach(char i in str)
            {
                if (i != ' ') variableHelper += i;
                else
                {
                    array[count] = int.Parse(variableHelper);
                    variableHelper = "";
                    count++;
                }
            }

            return array;
        }

        public static int algorithms(int[] array)
        {
            int result = 0;

            switch (Configuration.Variant)
            {
                case "1":
                    foreach (int i in array)
                    {
                        if (i % 3 == 0) result += i;
                    }
                    break;
            }

            return result;
        }

    }
}
