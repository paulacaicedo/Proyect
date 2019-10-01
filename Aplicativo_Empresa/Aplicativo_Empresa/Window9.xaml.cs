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

namespace Aplicativo_Empresa
{
    /// <summary>
    /// Lógica de interacción para Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        private List<Factura_Compra> fa_compra;
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
            
        }

        private void Llenar()
        {
            string line;

            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\Factura_Compra.txt", Encoding.UTF8);
            fa_compra = new List<Factura_Compra>();

            while ((line = sr.ReadLine()) != null)
            {
                string[] datos = line.Split(';');
                MessageBox.Show(line);
                listBox_client.Items.Add(line);
            }
            sr.Close();

        }

        

        
    }
}
