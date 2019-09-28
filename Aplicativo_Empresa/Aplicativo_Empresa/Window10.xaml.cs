﻿using System;
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
    /// Lógica de interacción para Window10.xaml
    /// </summary>
    public partial class Window10 : Window
    {
        static double precio = 0;
        static double cantidad = 0;
        static double costo = 0;
        static string total;
        static DateTime date;
        static DateTime hour;
        public Window10()
        {
            InitializeComponent();
            label_date.Content = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window4 atras = new Window4();
            this.Hide();
            atras.ShowDialog();
            this.Show();
        }

        private void Button_guardar_Click(object sender, RoutedEventArgs e)
        {
            //Validacion Campos Vacios
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
            if (textbox_phone.Text.Trim().Length == 0)
            {
                MessageBox.Show("El telefono no debe estar vacio ");
                return;
            }
            if (textbox_adress.Text.Trim().Length == 0)
            {
                MessageBox.Show("La direccion no debe estar vacio ");
                return;
            }
            if (textbox_timeservice.Text.Trim().Length == 0)
            {
                MessageBox.Show("La marca no debe estar vacio ");
                return;
            }
            if (textbox_product.Text.Trim().Length == 0)
            {
                MessageBox.Show("El serial del producto no debe de estar vacio ");
                return;
            }
            if (textbox_quantity.Text.Trim().Length == 0)
            {
                MessageBox.Show("La cantidad no debe estar vacia ");
                return;
            }
            if (textbox_descrip.Text.Trim().Length == 0)
            {
                MessageBox.Show("La descripcion no debe de estar vacia ");
                return;
            }
            if (textbox_dateservice.Text.Trim().Length == 0)
            {
                MessageBox.Show("La fecha del servicio no debe de estar vacia ");
                return;
            }
            if (textbox_duration.Text.Trim().Length == 0)
            {
                MessageBox.Show("La duracion no debe de estar vacia ");
                return;
            }
            if (textbox_materials.Text.Trim().Length == 0)
            {
                MessageBox.Show("La materiales no debe de estar vacia ");
                return;
            }
            if (textbox_descripcost.Text.Trim().Length == 0)
            {
                MessageBox.Show("La descripcion de los costos no debe de estar vacia ");
                return;
            }
            if (textbox_totalprice.Text.Trim().Length == 0)
            {
                MessageBox.Show("El precio no debe de estar vacio ");
                return;
            }
            if (textbox_cost.Text.Trim().Length == 0)
            {
                MessageBox.Show("Los costos no debe de estar vacios ");
                return;
            }

            //Validacion Numerica
            bool isNum = double.TryParse(textbox_totalprice.Text, out precio);
            if (!isNum)
            {
                MessageBox.Show("Digite un valor de unitario válido");
                return;
            }
            bool isquantity = double.TryParse(textbox_quantity.Text, out cantidad);
            if (!isquantity)
            {
                MessageBox.Show("Digite un valor de cantidad válido");
                return;
            }
            bool isCost = double.TryParse(textbox_cost.Text, out costo);
            if (!isCost)
            {
                MessageBox.Show("Digite un valor de costo válido");
                return;
            }

            //Validacion de fecha y hora

            bool time = DateTime.TryParse(textbox_dateservice.Text, out date);
            if (time)
            {
                MessageBox.Show("Valor de Fecha no Valido");
                return;
            }

            bool reloj = DateTime.TryParse(textbox_timeservice.Text, out hour);
            if (reloj)
            {
                MessageBox.Show("Valor de hora no valido");
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

            if (!r.IsMatch(textbox_product.Text))
            {
                MessageBox.Show("El nombre del vendedor sólo debe tener caracteres alfabéticos ");
                textbox_product.Focus();
                return;
            }

            if (!r.IsMatch(textbox_descrip.Text))
            {
                MessageBox.Show("El nombre del vendedor sólo debe tener caracteres alfabéticos ");
                textbox_descrip.Focus();
                return;
            }

            if (!r.IsMatch(textbox_descripcost.Text))
            {
                MessageBox.Show("El nombre del vendedor sólo debe tener caracteres alfabéticos ");
                textbox_descripcost.Focus();
                return;
            }

            if (!r.IsMatch(textbox_materials.Text))
            {
                MessageBox.Show("El nombre del vendedor sólo debe tener caracteres alfabéticos ");
                textbox_materials.Focus();
                return;
            }


            //Operaciones

            costo += precio;
            total = Convert.ToString(costo);
            textbox_totalprice.Text.Contains(total);

            //Instanciar objeto
            Factura_Servicios newFacSer = new Factura_Servicios(textbox_factura.Text, textbox_client.Text, textbox_asistent.Text,textbox_product.Text, costo);
            MessageBox.Show(newFacSer.ToString());

            //guardar el registro

            try
            {
                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Factura_Servicios.txt", append: true);
                sw.WriteLine(newFacSer.ToString());
                sw.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un error con el archivo y no se pudo registrar");
            }
        }

        
        
 

        private void Button_cancel_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Realmente desea salir?", "Alerta", MessageBoxButton.OKCancel);
            if (result == MessageBoxResult.OK)
            {
                Window2 cerrar = new Window2();
                this.Hide();
                cerrar.ShowDialog();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }
    }
}