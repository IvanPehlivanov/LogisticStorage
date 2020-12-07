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

namespace LogisticStorage
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
        private void btnEinlagern_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(Einlagern);
        }

        public void SetActiveUserControl(UserControl control)
        {
            Einlagern.Visibility = Visibility.Collapsed;
            StatusPlätze.Visibility = Visibility.Collapsed;

            control.Visibility = Visibility.Visible;
        }

        private void btnStatusPlätze_Click(object sender, RoutedEventArgs e)
        {
            SetActiveUserControl(StatusPlätze);
        }
    }
}
