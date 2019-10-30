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
using Newtonsoft.Json;

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

        static private List<Factura_Compra> fa_compra = new List<Factura_Compra>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window3 atras = new Window3();
            this.Hide();
            atras.ShowDialog();
            
        }

        private void Button_guardar_Click(object sender, RoutedEventArgs e)
        {
            //Validacion de campos vacios

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
            if (precio < 0)
            {
                MessageBox.Show("Valores negativos no validos");
                textbox_unitvalue.Focus();
                return;

            }
            bool isquantity = double.TryParse(textbox_quantity.Text, out cantidad);
            if (!isquantity)
            {
                MessageBox.Show("Digite un valor de cantidad válido");
                return;
            }
            if (cantidad < 0)
            {
                MessageBox.Show("Valores negativos no validos");
                textbox_unitvalue.Focus();
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
    
            if (!re.IsMatch(textbox_product.Text))
            {
                MessageBox.Show("El nombre serial del producto sólo debe tener caracteres especiales");
                textbox_product.Focus();
                return;
            }

            //Validacion de ComboBox
            if (combobox_linea == null)
            {
                MessageBox.Show("Linea se escuentra vacio");
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
            Factura_Compra newFac = new Factura_Compra(textbox_factura.Text,textbox_client.Text,textbox_asistent.Text,textbox_adress.Text,textbox_phone.Text,precioFinal);
            MessageBox.Show("Factura Guardada");
            fa_compra.Add(newFac);
            string registroJSON = JsonConvert.SerializeObject(fa_compra);


            //guardar el registro
            string path = @"Compra.json";
            using(var tw=new StreamWriter(path, false))
            {
                tw.WriteLine(registroJSON.ToString());
            }
            //File.WriteAllText(AppDomain.CurrentDomain.BaseDirectory + "\\Compra.json", registroJSON);

        }

        
        
         
        
    }
}
