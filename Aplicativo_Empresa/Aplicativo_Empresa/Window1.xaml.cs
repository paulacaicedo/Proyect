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
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_visitas_Click(object sender, RoutedEventArgs e)
        {
            Window2 Window1 = new Window2();
            this.Hide();
            Window1.ShowDialog();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 Window2 = new Window3();
            this.Hide();
            Window2.ShowDialog();
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window4 Window3 = new Window4();
            this.Hide();
            Window3.ShowDialog();
            
        }

       
    }
}
