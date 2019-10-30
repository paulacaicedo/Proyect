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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace Aplicativo_Empresa
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        
        private void Button_login_Click(object sender, RoutedEventArgs e)
        {
            string line;
            StreamReader sr = new StreamReader(AppDomain.CurrentDomain.BaseDirectory + "\\contraseñas.txt", Encoding.UTF8);
            List<Vendedor> contra = new List<Vendedor>();


            while ((line = sr.ReadLine()) != null)
            {
                Vendedor venTemp;
                venTemp = new Vendedor(line);
                contra.Add(venTemp);
            }
            sr.Close();
           
            if (textbox_username.Text.Trim().Length == 0)
            {
                MessageBox.Show("El nombre del usuario no debe estar vacio ");
                return;
            }
            if (password.Password.Trim().Length == 0)
            {
                MessageBox.Show("La Contraseña no debe estar vacio ");
                return;
            }

            foreach(Vendedor ven in contra)
            {
               
                if (textbox_username.Text.Equals(ven.Name) && password.Password.Equals(ven.Password))
                {
                    Window1 Window = new Window1();
                    this.Hide();
                    Window.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrectos");
                    return;

                }

            }
            
            
        }

        private void Textbox_username_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            textbox_username.Text = "";
        }

        private void Button_cancel_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Password_GotKeyboardFocus(object sender, KeyboardFocusChangedEventArgs e)
        {
            password.Password = "";
        }
    }
}
