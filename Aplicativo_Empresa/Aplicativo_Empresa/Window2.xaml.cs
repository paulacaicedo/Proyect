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
    /// Lógica de interacción para Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            Window1 atras = new Window1();
            this.Hide();
            atras.ShowDialog();
            this.Show();
        }

        private void Button_planillaSalida_Click(object sender, RoutedEventArgs e)
        {
            Window5 Window1 = new Window5();
            this.Hide();
            Window1.ShowDialog();
            this.Show();
        }

        private void Button_planillaLLegada_Click(object sender, RoutedEventArgs e)
        {
            Window6 Window2 = new Window6();
            this.Hide();
            Window2.ShowDialog();
            this.Show();
        }

        private void Button_InformeSalidas_Click(object sender, RoutedEventArgs e)
        {
            Window7 Window3 = new Window7();
            this.Hide();
            Window3.ShowDialog();
            this.Show();
        }
    }
}
