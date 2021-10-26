using System.Windows;
using System.Windows.Controls;
using ProcessSA.Business;
namespace ProcessSA.Views
{
    /// <summary>
    /// Lógica de interacción para Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        public Main ControladorHome;

        public Home()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            ControladorHome.ventUsuarios.ControladorUsuarios = ControladorHome;
            ControladorHome.Principal.NavigationService.Navigate(ControladorHome.ventUsuarios);
            ControladorHome.Titulo.Text = "Usuarios";
            ControladorHome.Volver.Visibility = Visibility.Visible;
        }

        private void btnTareas_Click(object sender, RoutedEventArgs e)
        {
            ControladorHome.ventTareas.ControladorTareas = ControladorHome;
            ControladorHome.Principal.NavigationService.Navigate(ControladorHome.ventTareas);
            ControladorHome.Titulo.Text = "Tareas";
            ControladorHome.Volver.Visibility = Visibility.Visible;
        }

        private void btnReportes_Click(object sender, RoutedEventArgs e)
        {
            ControladorHome.ventReportes.ControladorReportes = ControladorHome;
            ControladorHome.Principal.NavigationService.Navigate(ControladorHome.ventReportes);
            ControladorHome.Titulo.Text = "Reportes";
            ControladorHome.Volver.Visibility = Visibility.Visible;
        }

        private void btnFlujos_Click(object sender, RoutedEventArgs e)
        {
            ControladorHome.ventFlujos.ControladorFlujos = ControladorHome;
            ControladorHome.Principal.NavigationService.Navigate(ControladorHome.ventFlujos);
            ControladorHome.Titulo.Text = "Flujos";
            ControladorHome.Volver.Visibility = Visibility.Visible;
        }

        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            ControladorHome.ventTest.ControladorTest = ControladorHome;
            ControladorHome.Principal.NavigationService.Navigate(ControladorHome.ventTest);
            ControladorHome.Titulo.Text = "Test";
            ControladorHome.Volver.Visibility = Visibility.Visible;
        }
    }
}
