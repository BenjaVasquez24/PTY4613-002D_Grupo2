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
using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using System.Data.OracleClient;

namespace ProcessSA_Mahapps
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        MetroWindow window = Application.Current.MainWindow as MetroWindow;
        public Login()
        {
            InitializeComponent();
        }

        //Conectar con base de datos
        OracleConnection conexion = new OracleConnection("DATA SOURCE = orcl ; PASSWORD = 123 ; USER ID = tester");
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //Sincronizar base de datos con Visual para conectarse con algún usuario creado
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM USUARIO WHERE USUARIO = :usuario AND CONTRA = :contra", conexion);

            comando.Parameters.AddWithValue(":usuario", txtUsuario.Text);
            comando.Parameters.AddWithValue(":contra", pwContra.Password);

            OracleDataReader lector = comando.ExecuteReader();

            if (lector.Read())
            {
                Administracion formulario = new Administracion();
                NavigationService.Navigate(new Administracion());
            }

            else
            {
                window.ShowMessageAsync("Inicio de sesión", "Error al procesar usuario, verifique su información.");
                conexion.Close();
            }
        }
    }
}
