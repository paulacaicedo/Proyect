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
    /// Lógica de interacción para Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
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

        private void Button_AntesServicio_Click(object sender, RoutedEventArgs e)
        {
            Window10 Window1 = new Window10();
            this.Hide();
            Window1.ShowDialog();
            this.Show();
        }

        private void Button_InformeServicio_Click(object sender, RoutedEventArgs e)
        {
            Window12 Window2 = new Window12();
            this.Hide();
            Window2.ShowDialog();
            this.Show();
        }
    }
}
