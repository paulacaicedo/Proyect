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
using Newtonsoft.Json;

namespace Aplicativo_Empresa
{
    /// <summary>
    /// Lógica de interacción para Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        static private List<ReporteVisitas> reporteSalida = new List<ReporteVisitas>();
        static string date;
        static string hour;
        public Window5()
        {
            InitializeComponent();
            label_date.Content = DateTime.Now.ToString("dd/MM/yyyy");
            label_time.Content = DateTime.Now.ToShortTimeString();

            date = DateTime.Now.ToString("dd/MM/yyyy");
            hour = DateTime.Now.ToShortTimeString();
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

            if (!r.IsMatch(textbox_topic.Text))
            {
                MessageBox.Show("El tema sólo debe tener caracteres alfabéticos ");
                textbox_topic.Focus();
                return;
            }


            //crear objeto y asignarle los valores
            ReporteVisitas newVisit = new ReporteVisitas(date,hour,textbox_client.Text.ToString(),textbox_asistent.Text.ToString(),textbox_topic.Text.ToString(),textbox_place.Text.ToString());
            MessageBox.Show(newVisit.ToString());
            reporteSalida.Add(newVisit);

            //guardar el registro

            string registroJSON = JsonConvert.SerializeObject(reporteSalida);
            File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\ReporteSalida.json", registroJSON);

        }



        private void Button_cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result= MessageBox.Show("¿Realmente desea eliminar la planilla?", "Alerta", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                textbox_asistent.Clear();
                textbox_client.Clear();
                textbox_seller.Clear();
                textbox_compromise.Clear();
                textbox_place.Clear();
                textbox_report.Clear();
                textbox_topic.Clear();

            }
            else 
            {
                this.Close();
            }

          
            
        }
    }
}
