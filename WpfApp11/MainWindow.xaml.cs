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

namespace WpfApp11
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Clicked");
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mystackpanel.Children.Clear();
        }

        private void Button_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            //if (e.LeftButton == MouseButtonState.Pressed)
            //{
            //    foreach (var control in mystackpanel.Children)
            //    {
            //        if (control is Button bt)
            //        {
            //            bt.Content += " checked";
            //        }
            //    }
            //}
            //else if(e.RightButton== MouseButtonState.Pressed)
            //{
            //    var btn = new Button();
            //    btn.Content = "New Button";
            //    mystackpanel.Children.Add(btn);
            //}
        }
    }
}
