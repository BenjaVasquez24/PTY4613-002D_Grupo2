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
        public Main ControladorUsuarios;       

        public Usuarios()
        {
            InitializeComponent();
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
            Usuarios usuarios = new Usuarios();
            //gdUsuarios.ItemsSource = usuarios.ReadAll();
        }

        private void btnAgregar_Click(object sender, RoutedEventArgs e)
        {
            
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

        private void txtFiltroRut_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
