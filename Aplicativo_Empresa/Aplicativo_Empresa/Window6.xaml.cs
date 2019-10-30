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
    /// Lógica de interacción para Window6.xaml
    /// </summary>
    public partial class Window6 : Window
    {
        static private List<ReporteVisitas> reporteLlegada = new List<ReporteVisitas>();
        static string date;
        static string hour;

        public Window6()
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
            if (textbox_adress.Text.Trim().Length == 0)
            {
                MessageBox.Show("El lugar no debe estar vacio ");
                return;
            }
            if (textbox_topic.Text.Trim().Length == 0)
            {
                MessageBox.Show("El tema no debe estar vacio ");
                return;
            }
            if (textbox_finalreport.Text.Trim().Length == 0)
            {
                MessageBox.Show("El reporte no debe estar vacio ");
                return;
            }
            if (textbox_finalecompromise.Text.Trim().Length == 0)
            {
                MessageBox.Show("Los Compromisos no debe de estar vacio ");
                return;
            }
            if (Textbox_phone.Text.Trim().Length == 0)
            {
                MessageBox.Show("El telefono no debe estar vacio ");
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

            if (!r.IsMatch(textbox_topic.Text))
            {
                MessageBox.Show("El tema sólo debe tener caracteres alfabéticos ");
                textbox_topic.Focus();
                return;
            }

            if (comboBox_seller.SelectedIndex == 0)
            {
                ReporteVisitas newVisit = new ReporteVisitas(date, hour, "Yolima Serrano", textbox_client.Text.ToString(), textbox_asistent.Text.ToString(), textbox_topic.Text.ToString(), Textbox_phone.Text.ToString(), textbox_adress.Text.ToString());
                MessageBox.Show("Reporte Guardado");
                reporteLlegada.Add(newVisit);
                string registroJSON = JsonConvert.SerializeObject(reporteLlegada);


                string path = @"ReporteLlegada.json";
                using (var tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(registroJSON.ToString());
                }
                

            }

            if (comboBox_seller.SelectedIndex == 1)
            {
                ReporteVisitas newVisit = new ReporteVisitas(date, hour, "Sergio Monsalve", textbox_client.Text.ToString(), textbox_asistent.Text.ToString(), textbox_topic.Text.ToString(), Textbox_phone.Text.ToString(), textbox_adress.Text.ToString());
                MessageBox.Show("Reporte Guardado");
                reporteLlegada.Add(newVisit);
                string registroJSON = JsonConvert.SerializeObject(reporteLlegada);


                string path = @"ReporteLlegada.json";
                using (var tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(registroJSON.ToString());
                }

            }
            if (comboBox_seller.SelectedIndex == 2)
            {
                ReporteVisitas newVisit = new ReporteVisitas(date, hour, "Erika Calderon", textbox_client.Text.ToString(), textbox_asistent.Text.ToString(), textbox_topic.Text.ToString(), Textbox_phone.Text.ToString(), textbox_adress.Text.ToString());
                MessageBox.Show("Reporte Guardado");
                reporteLlegada.Add(newVisit);
                string registroJSON = JsonConvert.SerializeObject(reporteLlegada);


                string path = @"ReporteLlegada.json";
                using (var tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(registroJSON.ToString());
                }

            }
            if (comboBox_seller.SelectedIndex == 3)
            {
                ReporteVisitas newVisit = new ReporteVisitas(date, hour, "Viviana Sierra", textbox_client.Text.ToString(), textbox_asistent.Text.ToString(),textbox_topic.Text.ToString(), Textbox_phone.Text.ToString(), textbox_adress.Text.ToString());
                MessageBox.Show(newVisit.ToString());
                MessageBox.Show("Reporte Guardado");
                reporteLlegada.Add(newVisit);
                string registroJSON = JsonConvert.SerializeObject(reporteLlegada);


                string path = @"ReporteLlegada.json";
                using (var tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(registroJSON.ToString());
                }

            }
            if (comboBox_seller.SelectedIndex == 4)
            {
                ReporteVisitas newVisit = new ReporteVisitas(date, hour, "Luisa Monsalve", textbox_client.Text.ToString(), textbox_asistent.Text.ToString(), textbox_topic.Text.ToString(), Textbox_phone.Text.ToString(), textbox_adress.Text.ToString());
                MessageBox.Show(newVisit.ToString());
                MessageBox.Show("Reporte Guardado");
                reporteLlegada.Add(newVisit);
                string registroJSON = JsonConvert.SerializeObject(reporteLlegada);


                string path = @"ReporteLlegada.json";
                using (var tw = new StreamWriter(path, false))
                {
                    tw.WriteLine(registroJSON.ToString());
                }

            }

        }

  
    }
}