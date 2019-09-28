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
    /// Lógica de interacción para Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }

        private void Button_back_Click(object sender, RoutedEventArgs e)
        {
            Window1 atras = new Window1();
            this.Hide();
            atras.ShowDialog();
            this.Show();
        }

        private void Button_GenerarFactura_Click(object sender, RoutedEventArgs e)
        {
            Window8 Window1 = new Window8();
            this.Hide();
            Window1.ShowDialog();
            this.Show();
        }

        private void Button_InformeProductos_Click(object sender, RoutedEventArgs e)
        {
            Window9 Window2 = new Window9();
            this.Hide();
            Window2.ShowDialog();
            this.Show();
        }
    }
}
