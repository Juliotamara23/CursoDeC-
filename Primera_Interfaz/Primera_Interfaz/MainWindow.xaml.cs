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

namespace Primera_Interfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //InitializeComponent();

            //Grid grid = new Grid();

            //this.Content = grid;

            //Button miBoton = new Button();

            //miBoton.Width = 150;
            //miBoton.Height = 75;
            //miBoton.Background = Brushes.Blue;

            //WrapPanel wrapPanel = new WrapPanel();

            //TextBlock txt1 = new TextBlock();

            //txt1.Background = Brushes.Red;
            //txt1.Foreground = Brushes.Blue;

            //txt1.Text = "Click";

            //wrapPanel.Children.Add(txt1);

            //TextBlock txt2 = new TextBlock();

            //txt2.Text = "Enviar";

            //wrapPanel.Children.Add(txt2);

            //TextBlock txt3 = new TextBlock();

            //txt3.Text = "Dale";

            //wrapPanel.Children.Add(txt3);

            //miBoton.Content = wrapPanel;

            //grid.Children.Add(miBoton);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Presionaste el boton");
        }
    }
}
