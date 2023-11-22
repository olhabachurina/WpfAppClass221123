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

namespace WpfAppClass221123
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SecondWin secondWin;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenWindow_Click(object sender, RoutedEventArgs e)
        {
            if (secondWin == null)
            {
                secondWin = new SecondWin();
                secondWin.Owner = this;
                secondWin.Show();
            }
        }

        private void CloseWindow_Click(object sender, RoutedEventArgs e)
        {
            if (secondWin!= null)
            {
                secondWin.Close();
                secondWin = null;
            }
        }
    }
}
    


