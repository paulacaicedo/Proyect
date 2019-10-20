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
    /// Lógica de interacción para Window12.xaml
    /// </summary>
    public partial class Window12 : Window
    {
        
        
        public Window12()
        {
            InitializeComponent();
            Llenar();
        }

        private List<Factura_Servicios> LoadCollectionData()
        {
            List<Factura_Servicios> fa_servicios = new List<Factura_Servicios>();
            string archivo = @"Servicios.json";
            using (StreamReader r = new StreamReader(archivo))
            {
                var ArchivoJSON = r.ReadToEnd();
                MessageBox.Show("Así llega del archivo Json: \n" + ArchivoJSON.ToString());
                fa_servicios = JsonConvert.DeserializeObject<List<Factura_Servicios>>(ArchivoJSON);


            }
            return fa_servicios;
        }

        private void LlenarData()
        {

            datagrid_service.ItemsSource = LoadCollectionData();


        }

        private void Button_atras_Click(object sender, RoutedEventArgs e)
        {
            Window10 mw = new Window10();
            this.Hide();
            mw.ShowDialog();
        }

    }
}
