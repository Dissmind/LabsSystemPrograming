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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Labs
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

        private void Button_Click_Open_Labs3(object sender, RoutedEventArgs e)
        {
            WindowLabs3 window = new WindowLabs3();
            window.Show();
        }
        private void Button_Click_Open_Labs2(object sender, RoutedEventArgs e)
        {
            WindowLabs2 window = new WindowLabs2();
            window.Show();
        }
    }
}
