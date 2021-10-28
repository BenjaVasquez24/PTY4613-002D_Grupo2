using System;
using System.Collections.Generic;
using System.Data;
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
using ProcessSA.Business;
using System.Data.OracleClient;
using System.Data.SqlClient;


namespace ProcessSA.Views
{
    /// <summary>
    /// Lógica de interacción para Usuarios.xaml
    /// </summary>
    public partial class Usuarios : Page
    {
        OracleConnection ora = new OracleConnection("DATA SOURCE = orcl; password= 123; user id = test;");
        public Main ControladorUsuarios;

        List<Usuarios> listausuarios = new List<Usuarios>();

        public Usuarios()
        {
            InitializeComponent();
            CargarGridUsuarios();
        }

        public void LimpiarControles()
        {
            txtRut.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtContraseña.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtTelefono.Text = string.Empty;

            CargarGridUsuarios();
        }

        public void CargarGridUsuarios()
        {
            gdUsuarios.ItemsSource = listausuarios;
            gdUsuarios.Items.Refresh();


            //Usuarios usuarios = new Usuarios();
            ////gdUsuarios.ItemsSource = usuarios.ReadAll();

            //OracleCommand comando = new OracleCommand("Select * from Users", ora);
            //OracleDataAdapter adaptador = new OracleDataAdapter();
            //adaptador.SelectCommand = comando;
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);
            //gdUsuarios.DataSource = tabla;
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Usuarios usuarios = new Usuarios();

            usuarios.txtRut.Text = txtRut.Text;
            usuarios.txtNombre.Text = txtNombre.Text;
            usuarios.txtApellido.Text = txtApellido.Text;
            usuarios.txtNombreUsuario.Text = txtNombreUsuario.Text;
            usuarios.txtContraseña.Text = txtContraseña.Text;
            //usuarios.cboRol.SelectedItem=
            listausuarios.Add(usuarios);

            CargarGridUsuarios();
            LimpiarControles();

            //Usuarios usu = new Usuarios()
            //{
            //    RutUsuarios = txtRut.Text,
            //    Nombres = txtNombre.Text,
            //    Apellidos = txtApellido.Text,
            //    NombreUsuario = txtNombreUsuario.Text,
            //    Contraseña = txtContraseña.Text,
            //    Rol = (cboRol.SelectedValue.ToString()),
            //    Email = txtEmail.Text,
            //    Teléfono = txtTelefono.Text,
            //}
        }

        private void btnBuscar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void txtTelefono_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));
            if (ascci >= 48 && ascci <= 57)
                e.Handled = false;
            else e.Handled = e.Text == "+" ? false : true;
        }

        private void txtRut_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int ascci = Convert.ToInt32(Convert.ToChar(e.Text));
            if (ascci >= 48 && ascci <= 57)
                e.Handled = false;
            else if (e.Text == "k" || e.Text == "K" || e.Text == "-" || e.Text==".")
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void LimpiarFiltro_Click(object sender, RoutedEventArgs e)
        {
            txtFiltroNombre.Text = string.Empty;
            cboFiltroRol.SelectedItem = string.Empty;
            txtFiltroRut.Text = string.Empty;
        }
    }
}
