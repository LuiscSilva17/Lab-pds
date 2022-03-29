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

namespace Utad.Lab._3.Ex2
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

        private void BTGo_Click(object sender, RoutedEventArgs e)
        {
            string c=Convert.ToString(TBUrl.Text);
            if(c == "side.utad.pt")
            { 
            Window browser = new Window();
            this.Visibility = Visibility.Hidden;            
            browser.Show();
            }
        }
    }
}
