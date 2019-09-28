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

namespace Aplicativo_Empresa
{
    /// <summary>
    /// Lógica de interacción para Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        public Window9()
        {
            InitializeComponent();
            Llenar();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 atras = new Window3();
            this.Hide();
            atras.ShowDialog();
            this.Show();
        }

        private void Llenar()
        {
            List<Factura_Compra> facturas = new List<Factura_Compra>();
            facturas.Add();




        }
    }
}
