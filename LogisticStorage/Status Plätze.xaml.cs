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
    /// Interaction logic for Status_Plätze.xaml
    /// </summary>
    public partial class Status_Plätze : UserControl
    {
        public Status_Plätze()
        {
            InitializeComponent();
            FillDataGrid();
            FillData();
        }

        private void FillDataGrid()
        {



            //string ConString = ConfigurationManager.ConnectionStrings["Ryg.Logistic.Storage.Properties.Settings.RygConnectionString"].ConnectionString;
            //string CmdString = string.Empty;
            //using (SqlConnection con = new SqlConnection(ConString))
            //{
            //    CmdString = "SELECT Regal,Stellplatz FROM Regal_Stellplatz";
            //    SqlCommand cmd = new SqlCommand(CmdString, con);
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable("Regal_Stellplatz");
            //    sda.Fill(dt);
            //    grdStorage.ItemsSource = dt.DefaultView;
            //}
        }

        private void FillData()
        {
            
           


            //string ConString = ConfigurationManager.ConnectionStrings["Ryg.Logistic.Storage.Properties.Settings"].ConnectionString;
            //string CmdString = string.Empty;
            //using (SqlConnection con = new SqlConnection(ConString))
            //{
            //    CmdString = "SELECT Serien_Nr,Regal,Stellplatz,Tiefe,Breite,Höhe FROM Regal_Stellplatz";
            //    SqlCommand cmd = new SqlCommand(CmdString, con);
            //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
            //    DataTable dt = new DataTable("Regal_Stellplatz");
            //    sda.Fill(dt);
            //    dgSearchFunction.ItemsSource = dt.DefaultView;
            //}
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            //DataBase dataBase = new DataBase(_contentLoaded.ToString());
            //dataBase.InitializeDatabaseData(Log.ToString());

        }

        private void dgSearchFunction_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //    DataBase db = new DataBase(Settings.Default.DataDbCon);
            //    dgSearchFunction.SelectedItem = db.OrderVolume;
        }
    }
}
