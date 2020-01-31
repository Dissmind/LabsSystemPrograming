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
    /// Логика взаимодействия для Lab2Window.xaml
    /// </summary>
    public partial class Lab2Window : Window
    {
        public Lab2Window()
        {
            InitializeComponent();
        }

        private void Button_Click_Calculate(object sender, RoutedEventArgs e)
        {
            // TODO: Проверка данных

            string calculateResult = Lab1.Calculate(variableA.Text, variableB.Text, variableC.Text);

            labelResult.Content = "Результат";
            result.Content = calculateResult;
        }
    }
}
