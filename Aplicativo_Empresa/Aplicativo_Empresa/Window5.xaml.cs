using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aplicativo_Empresa
{
    /// <summary>
    /// Lógica de interacción para Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        
        public Window5()
        {
            InitializeComponent();
            label_date.Content = DateTime.Now.ToString("dd/MM/yyyy");
            label_time.Content = DateTime.Now.ToShortTimeString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window2 atras = new Window2();
            this.Hide();
            atras.ShowDialog();
            
        }


        // Validacion de campos vacios
        private void Button_guardar_Click(object sender, RoutedEventArgs e)
        {
            
            if (textbox_seller.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del vendedor no debe estar vacio ");
                return;
            }
            if (textbox_client.Text.Trim().Length == 0)
            {
                MessageBox.Show("El cliente no debe estar vacio ");
                return;
            }
            if (textbox_asistent.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del asistente no debe estar vacio ");
                return;
            }
            if (textbox_place.Text.Trim().Length == 0)
            {
                MessageBox.Show("El lugar no debe estar vacio ");
                return;
            }
            if (textbox_topic.Text.Trim().Length == 0)
            {
                MessageBox.Show("El tema no debe estar vacio ");
                return;
            }
            if (textbox_report.Text.Trim().Length == 0)
            {
                MessageBox.Show("El reporte no debe estar vacio ");
                return;
            }
            if (textbox_compromise.Text.Trim().Length == 0)
            {
                MessageBox.Show("Los Compromisos no debe de estar vacio ");
                return;
            }
            Regex r = new Regex("^[a-zA-Z\\s]*$");

            //Validadcion de solo caracteres alfabeticos

            if (!r.IsMatch(textbox_client.Text))
            {
                MessageBox.Show("El nombre del cliente sólo debe tener caracteres alfabéticos ");
                textbox_client.Focus();
                return;
            }

            if (!r.IsMatch(textbox_asistent.Text))
            {
                MessageBox.Show("El nombre del asistente sólo debe tener caracteres alfabéticos ");
                textbox_asistent.Focus();
                return;
            }

            if (!r.IsMatch(textbox_seller.Text))
            {
                MessageBox.Show("El nombre del vendedor sólo debe tener caracteres alfabéticos ");
                textbox_seller.Focus();
                return;
            }

            if (!r.IsMatch(textbox_place.Text))
            {
                MessageBox.Show("La marca sólo debe tener caracteres alfabéticos ");
                textbox_place.Focus();
                return;
            }
            if (!r.IsMatch(textbox_topic.Text))
            {
                MessageBox.Show("La marca sólo debe tener caracteres alfabéticos ");
                textbox_topic.Focus();
                return;
            }
            if (!r.IsMatch(textbox_report.Text))
            {
                MessageBox.Show("La marca sólo debe tener caracteres alfabéticos ");
                textbox_report.Focus();
                return;
            }
            if (!r.IsMatch(textbox_compromise.Text))
            {
                MessageBox.Show("La marca sólo debe tener caracteres alfabéticos ");
                textbox_compromise.Focus();
                return;
            }

            //crear objeto y asignarle los valores
            Cliente newClient = new Cliente(textbox_client.Text, textbox_asistent.Text, textbox_topic.Text);
            MessageBox.Show(newClient.ToString());

            //guardar el registro
            
            try
            {
                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\ReporteVisitasSalida.txt", append: true);
                sw.WriteLine(newClient.ToString());
                sw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error con el archivo y no se pudo registrar");
            }
            
        }



        private void Button_cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result= MessageBox.Show("Realmente desea salir?", "Alerta", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Window2 cerrar = new Window2();
                this.Hide();
                cerrar.ShowDialog();
                
            }
            else 
            {
                this.Close();
            }
            
            
        }
    }
}
