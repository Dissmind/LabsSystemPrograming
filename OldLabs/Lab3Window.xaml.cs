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
    /// Логика взаимодействия для Lab3Window.xaml
    /// </summary>
    public partial class Lab3Window : Window
    {
        public Lab3Window()
        {
            InitializeComponent();
        }

        private void Button_Click_Generate_Array(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_Calculate(object sender, RoutedEventArgs e)
        {
            labelResult.Content = Configuration.getLabelResultLab3();

            result.Content = Lab3.Calculate(inputArray.Text);
        }
    }
}
