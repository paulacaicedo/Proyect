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
using System.Windows.Shapes;
using System.IO;
using Newtonsoft.Json;

namespace Aplicativo_Empresa
{
    /// <summary>
    /// Lógica de interacción para Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
       
        public Window7()
        {
            InitializeComponent();
            LlenarData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 atras = new Window2();
            this.Hide();
            atras.ShowDialog();
            this.Show();
        }

        private List<ReporteVisitas> LoadCollectionData()
        {
            List<ReporteVisitas> reporteSalida = new List<ReporteVisitas>();
            string archivo = @"ReporteSalida.json";
            using (StreamReader r = new StreamReader(archivo))
            {
                var ArchivoJSON = r.ReadToEnd();
                reporteSalida = JsonConvert.DeserializeObject<List<ReporteVisitas>>(ArchivoJSON);


            }
            return reporteSalida;
        }

        private void LlenarData()
        {

            datagrid_report.ItemsSource = LoadCollectionData();


        }







    }
}
