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

namespace RadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            eRojo.Visibility = Visibility.Visible;
            eAmarillo.Visibility = Visibility.Hidden;
            eVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            eAmarillo.Visibility = Visibility.Visible;
            eRojo.Visibility = Visibility.Hidden;
            eVerde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            eVerde.Visibility = Visibility.Visible;
            eRojo.Visibility = Visibility.Hidden;
            eAmarillo.Visibility = Visibility.Hidden;

        }
    }
}
