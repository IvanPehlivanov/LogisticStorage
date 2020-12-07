using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;


namespace LogisticStorage
{
    /// <summary>
    /// Interaction logic for Einlagern.xaml
    /// </summary>
    public partial class Einlagern : UserControl, INotifyPropertyChanged
    {
        public string[] Operator { get; set; }
        public List<string[]> listFunktion { get; set; }
        private readonly EinlagernFunktion _einlagernFunktion;
        private Visibility _visibilityEinlagernNachFreieWahl = Visibility.Collapsed;
        private Visibility _visibilityAußenLager = Visibility.Collapsed;
        private Visibility _visibilityLöschen = Visibility.Collapsed;
        private Visibility _visibilityReservieren = Visibility.Collapsed;
        private string _selectedOperator;


        public Einlagern()
        {

            InitializeComponent();
           
            Operator = new string[] { "Einlagern nach freie Wahl", "Außen Lager", "Reservieren", "Löschen" };



            this.DataContext = this;

        }

        public Visibility VisibilityAußenLager
        {
            get => _visibilityAußenLager;
            set
            {
                _visibilityAußenLager = value;
                OnPropertyChanged();
            }
        }

        public Visibility VisibilityEinlagernNachFreieWahl
        {
            get => _visibilityEinlagernNachFreieWahl;
            set
            {
                _visibilityEinlagernNachFreieWahl = value;
                OnPropertyChanged();
            }
        }

        public Visibility VisibilityReservieren
        {
            get => _visibilityReservieren;
            set
            {
                _visibilityReservieren = value;
                OnPropertyChanged();
            }
        }

        public Visibility VisibilityLöschen
        {
            get => _visibilityLöschen;
            set
            {
                _visibilityLöschen = value;
                OnPropertyChanged();
            }
        }


        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


            VisibilityEinlagernNachFreieWahl = e.AddedItems[0].ToString() == Operator[0]
                    ? Visibility.Visible
                    : Visibility.Collapsed;

            VisibilityAußenLager = e.AddedItems[0].ToString() == Operator[1]
                ? Visibility.Visible
                : Visibility.Collapsed;

            VisibilityReservieren = e.AddedItems[0].ToString() == Operator[2]
                ? Visibility.Visible
                : Visibility.Collapsed;

            VisibilityLöschen = e.AddedItems[0].ToString() == Operator[3]
                ? Visibility.Visible
                : Visibility.Collapsed;

        }

      
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void TxtSerialNo_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
           


        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {


        }

        private void DataGridEinlagern_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
