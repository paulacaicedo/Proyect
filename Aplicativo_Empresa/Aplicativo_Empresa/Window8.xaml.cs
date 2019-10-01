using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Aplicativo_Empresa
{
    /// <summary>
    /// Lógica de interacción para Window8.xaml
    /// </summary>
    public partial class Window8 : Window
    {
        static double precio = 0;
        static double precioTotal = 0;
        static string precioFinal;
        static double cantidad = 0;
        static string subTotal;
        public Window8()
        {
            InitializeComponent();
            label_date.Content = DateTime.Now.ToString("dd/MM/yyyy");
            label_iva.Content = "19%";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 atras = new Window3();
            this.Hide();
            atras.ShowDialog();
            
        }

        private void Button_guardar_Click(object sender, RoutedEventArgs e)
        {
            //Validacion de campos vacios

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
            if (textbox_mark.Text.Trim().Length == 0)
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
            if (textbox_unitvalue.Text.Trim().Length == 0)
            {
                MessageBox.Show("La descripcion no debe de estar vacia ");
                return;
            }

            //Validacion numerica

            bool isNum = double.TryParse(textbox_unitvalue.Text, out precio);
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

            Regex re = new Regex("^[0-9a-zA-Z\\s]*$");
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

            if (!r.IsMatch(textbox_mark.Text))
            {
                MessageBox.Show("La marca sólo debe tener caracteres alfabéticos ");
                textbox_mark.Focus();
                return;
            }

            //Validacion de caracteres especiales

            if (!re.IsMatch(textbox_phone.Text))
            {
                MessageBox.Show("El telefono sólo debe tener caracteres especiales ");
                textbox_phone.Focus();
                return;
            }
            if (!re.IsMatch(textbox_adress.Text))
            {
                MessageBox.Show("La direccion sólo debe tener caracteres especiales ");
                textbox_adress.Focus();
                return;
            }
            if (!re.IsMatch(textbox_product.Text))
            {
                MessageBox.Show("El nombre serial del producto sólo debe tener caracteres especiales");
                textbox_product.Focus();
                return;
            }

            //Validacion de ComboBox
            bool item = Convert.ToBoolean(combobox_linea);
            if (item == false)
            {
                MessageBox.Show("Linea esta vacio");
            }

            bool item1 = Convert.ToBoolean(comboBox_state);
            if (item1 == false)
            {
                MessageBox.Show("Estado de Compra esta vacio");
            }


            labeltext_total.Visibility = Visibility.Visible;
            labeltext_beforeIva.Visibility = Visibility.Visible;

            //Todas las operaciones correspondientes

            precio = cantidad * precio;
            subTotal = Convert.ToString(precio);
            labeltext_beforeIva.Content = subTotal;
            precioTotal = (precio * 19) / 100;
            precioFinal = Convert.ToString(precioTotal);
            labeltext_total.Content = precioFinal;

            //Instanciar Objeto
            Factura_Compra newFac = new Factura_Compra(textbox_factura.Text, textbox_client.Text, textbox_asistent.Text,precioTotal);
            MessageBox.Show(newFac.ToString());


            //guardar el registro
            try
            {
                StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\Factura_Compra.txt", append: true);
                sw.WriteLine(newFac.ToString());
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
                
            }
            else
            {
                this.Close();
            }
        }

        private void Button_newFac_Click(object sender, RoutedEventArgs e)
        {
            textbox_seller.Clear();
            textbox_client.Clear();
            textbox_asistent.Clear();
            textbox_adress.Clear();
            textbox_phone.Clear();
            textbox_mark.Clear();
            textbox_product.Clear();
            textbox_descrip.Clear();
            textbox_quantity.Clear();
            textbox_unitvalue.Clear();
            

        }
    }
}
