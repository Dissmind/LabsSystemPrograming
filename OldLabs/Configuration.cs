using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs.OldLabs
{
    class Configuration
    {
        public static string Variant { set; get; } = "1";

        public static string getLabelResultLab3()
        {
            string result = "";

            switch (Variant)
            {
                case "1":
                    result = "Сумма элементов делющиеся на 3:";
                    break;
            }

            return result;
        }
    }
}
