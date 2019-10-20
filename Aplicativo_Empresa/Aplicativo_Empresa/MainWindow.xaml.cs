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

        static Vendedor[] usuarios = new Vendedor[4] { new Vendedor("luisa", "398832"), new Vendedor("yolima", "398832"), new Vendedor("viviana", "398832"), new Vendedor("erika", "398832") };

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

            bool flag = false;
            for (int i=0; i<usuarios.Length; i++)
            {
                if (
                    textbox_username.Text.Equals(usuarios[i].Name) &&
                    password.Password.Equals(usuarios[i].Password)
                    )
                {
                    flag = true;
                    MessageBox.Show("Inicio Sesion");
                    break;

                }
                if (!flag)
                {
                    MessageBox.Show("Error");
                    return;
                }
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
