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
            double[] array = ConversionArray(strArray);

            // Algorithm calculation
            double result = Algorithms(array);

            return result.ToString();
        }

        private static double[] ConversionArray(string str)
        {
            // Counting size array
            int arrayLength = 0;

            for(int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ') arrayLength++;
            }

            double[] array = new double[arrayLength + 1];

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

        public static double Algorithms(double[] array)
        {
            double result = 0;

            // Array variant for multiple
            int[] MultiVariant = { 2, 3, 5, 7, 11, 13, 15, 17, 19, 20, 22, 26, 28, 30 };

            bool isMult = false;

            foreach (int i in MultiVariant) 
                if (i == int.Parse(Configuration.Variant)) isMult = true;

            foreach (double i in array)
            {
                if (ConditionAlgorithms(i))
                {
                    if (isMult)
                    {
                        if (result == 0) result++;
                        result *= i;
                    }
                    else result += i;
                }
            }

            return result;
        }

        private static bool ConditionAlgorithms(double i)
        {
            // Array condition algorithms for variant
            bool[] conditionAlgorithms =
            {
                // 1
                i % 3 == 0,
                // 2
                i % 5 == 0,
                // 3
                i % 10 == 2,
                // 4
                i % 10 != 1,
                // 5
                i % 2 != 0 && i < 0,
                // 6
                i % 2 == 0 && i > 0,
                // 7
                i < 10 && i > -10,
                // 8
                i % 7 != 0, 
                // 9
                i % 10 == 0,
                // 10
                i < 70 && i > -70,
                // 11
                i < 50 && i > -50,
                // 12
                // TODO: Сумма максимального и минимального числа
                // 13
                // TODO: Числа с нулевой дробной частью  
                // 14
                i > 0 && i % 3 == 0,
                // 15
                i < 0 && i % 8 == 0,
                // 16
                i % 2 != 0 && i % 11 != 0,
                // 17
                // TODO: Нечетная целая часть
                // 18
                // TODO: Четная целая часть
                // 19
                // TODO: Абсолютная величина которых не превосходит 10
                // 20
                i % 3 == 0 && i % 5 != 0,
                // 21
                // TODO: Целая часть, которая не делится 3
                // 22
                (i % 10) % 2 == 0,
                // 23
                // TODO: C ненулевой дробной частью
                // 24
                // TODO: Абсолютная величина которых больше 30
                // 25
                i % 5 == 0 && i % 3 == 0,
                // 26
                i % 6 == 0,
                // 27
                i % 10 == 4,
                // 28
                i % 10 != 1 && i % 10 != 2,
                // 29
                i < 0,
                // 30

                // TODO: не превосходящих 20 по абсолютной величине
            };

            return conditionAlgorithms[int.Parse(Configuration.Variant) - 1];
        }

    }
}
