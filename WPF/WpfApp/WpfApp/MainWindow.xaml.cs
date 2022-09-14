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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var grid = (Grid)this.Content;
            //Button btn = new Button();
            //btn.Height = 50;
            //btn.Width = 100;
            //Margin = new Thickness(0, 0, 700, 380);
            //btn.Content = "button...";
            //grid.Children.Add(btn);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("按钮被点击了!");
        }
    }
}
