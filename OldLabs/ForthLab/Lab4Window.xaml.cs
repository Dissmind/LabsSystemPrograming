using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Labs.OldLabs
{
    /// <summary>
    /// Логика взаимодействия для Lab4Window.xaml
    /// </summary>
    public partial class Lab4Window : Window
    {
        public Lab4Window()
        {
            InitializeComponent();
        }

        private void Button_Click_Calculate(object sender, RoutedEventArgs e)
        {
            // Calculation
            string aStr = inputAString.Text;
            string bStr = inputBString.Text;

            Lab4.Calculate(ref aStr, ref bStr);

            inputAString.Text = aStr;
            inputBString.Text = bStr;

            // Output description 
            //TODO: Вывод описания в resultLabel
        }
    }
}
