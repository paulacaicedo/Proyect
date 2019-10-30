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
using System.Data;

namespace Aplicativo_Empresa
{
    /// <summary>
    /// Lógica de interacción para Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        private List<Factura_Compra> LoadCollectionData()
        {
            List<Factura_Compra> fa_compra = new List<Factura_Compra>();
            string archivo = @"Compra.json";
            using (StreamReader r = new StreamReader(archivo))
            {
                var ArchivoJSON = r.ReadToEnd();
                fa_compra = JsonConvert.DeserializeObject<List<Factura_Compra>>(ArchivoJSON);


            }
            return fa_compra;
        }
        
        public Window9()
        {
            InitializeComponent();
            LlenarData();   
        }

        private void LlenarData()
        {

            datagrid_client.ItemsSource = LoadCollectionData();
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 atras = new Window3();
            this.Hide();
            atras.ShowDialog();
            
        }



    }
}
