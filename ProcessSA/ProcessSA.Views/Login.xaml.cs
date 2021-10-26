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
using System.Data.OracleClient;
using MahApps.Metro.Controls.Dialogs;
using MahApps.Metro.Controls;
using MaterialDesignThemes.Wpf;


namespace ProcessSA.Views
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        public Main ControladorLogin;
        public Login()
        {
            InitializeComponent();
        }

        //Conectar con base de datos
        OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; password= 123; user id= test;");

        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            //Se inicia la conexión con la base de datos.
            ora.Open();
            //Sincronizar base de datos con Visual para conectarse con algún usuario creado.
            OracleCommand command = new OracleCommand("SELECT * FROM USERS WHERE USUARIO = :usuario AND CONTRASEÑA = :contraseña", ora);
            command.Parameters.AddWithValue(":usuario", UsuarioLogin.Text);
            command.Parameters.AddWithValue(":contraseña", ContraseñaLogin.Password);

            OracleDataReader lector = command.ExecuteReader();

            Login log = new Login();

            if (lector.Read())
            {
                //Redirige a menú principal
                ControladorLogin.home.ControladorHome = ControladorLogin;
                ControladorLogin.Principal.NavigationService.Navigate(ControladorLogin.home);
                ControladorLogin.Titulo.Text = "";
                ControladorLogin.Volver.Visibility = Visibility.Hidden;
            }
            else
            {
                Dialogos.BasicDialog("Error", "Verifique sus credenciales e intente nuevamente.");
                //Se cierra la conexión a base de datos.
                ora.Close();
                
            }
        }
    }
}
