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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Open_Lab1(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("test");
            Lab1Window window = new Lab1Window();
            window.Show();
        }

        private void Button_Click_Open_Lab2(object sender, RoutedEventArgs e)
        {
            Lab2Window window = new Lab2Window();
            window.Show();
        }

        private void Button_Click_Open_Lab3(object sender, RoutedEventArgs e)
        {
            Lab3Window window = new Lab3Window();
            window.Show();
        }

        private void Button_Click_Open_Lab4(object sender, RoutedEventArgs e)
        {
            Lab4Window window = new Lab4Window();
            window.Show();
        }
    }
}
