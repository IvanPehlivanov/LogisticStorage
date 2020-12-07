using System.Windows;
using System.Windows.Controls;

namespace LogisticStorage
{
    /// <summary>
    /// Interaction logic for Einlagern_nach_freie_Wahl.xaml
    /// </summary>
    public partial class Einlagern_nach_freie_Wahl : UserControl
    {
        public Einlagern_nach_freie_Wahl()
        {
            InitializeComponent();
        }
        private void Btn_Close_OnClick(object sender, RoutedEventArgs e)
        {
            Window win = Window.GetWindow(UserControl_Einlagern);
            win.Close();

        }
    }
}
