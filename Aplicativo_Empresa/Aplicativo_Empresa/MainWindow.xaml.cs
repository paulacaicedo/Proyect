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

        public string username = "luisa";
        public string verpassword = "398832";

        private void Button_login_Click(object sender, RoutedEventArgs e)
        {

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

            if (
                textbox_username.Text.Equals(username) &&
                password.Password.Equals(verpassword)
                )
            {
                MessageBox.Show("Inicio Sesion");
            }
            else
            {
                MessageBox.Show("Contraseña o Usuario Incorrectos");
                return;
            }

            Window1 Window = new Window1();
            this.Hide();
            Window.ShowDialog();
            

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
