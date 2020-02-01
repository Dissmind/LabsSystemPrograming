namespace Labs.OldLabs
{
    class Lab2
    {
        public static string Calculate(string aVariable, string bVariable, string cVariable)
        {
            // Conversion to double
            double a = double.Parse(aVariable);
            double b = double.Parse(bVariable);
            double c = double.Parse(cVariable);

            // Calculation
            double result = Algorithms(a, b, c);

            return ConversionString(result);
        }

        private static double Algorithms(double a, double b, double c)
        {
            switch (Configuration.Variant)
            {
                case "1": return ((b * b) - 4 * (a / c));
            }

            return 0;
        }

        // Conversion to string
        private static string ConversionString(double value)
        {
            // TODO: Сделать нормальное отображения результата и сокращение дроби
            return value.ToString();
        }
    }
}
