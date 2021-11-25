using MahApps.Metro.Controls;
using MahApps.Metro.Controls.Dialogs;
using MaterialDesignThemes.Wpf;
using System;
using System.Windows;

namespace ProcessSA.Views
{
    /// <summary>
    /// Lógica de interacción para Main.xaml
    /// </summary>
    public partial class Main : MetroWindow
    {
        private bool _shutdown;

        public Home home = new Home();
        public Flujos ventFlujos = new Flujos();
        public Reportes ventReportes = new Reportes();
        public Tareas ventTareas = new Tareas();
        public Test ventTest = new Test();
        public Usuarios ventUsuarios = new Usuarios();
        public Login login = new Login();
        private bool LightDark = false;

        public Main()
        {
            InitializeComponent();

            new PaletteHelper().ReplacePrimaryColor("Blue");
            DpPrincipal.SelectedDate = DateTime.Now;
            home.ControladorHome = this;
            ventFlujos.ControladorFlujos = this;
            ventTest.ControladorTest = this;
            ventReportes.ControladorReportes = this;
            ventUsuarios.ControladorUsuarios = this;
            ventTareas.ControladorTareas = this;
            login.ControladorLogin = this;
            Principal.NavigationService.Navigate(ventUsuarios);
            Titulo.Text = "";
            _shutdown = false;
            Volver.Visibility = Visibility.Hidden;
        }

        private void AltoContraste_Click(object sender, RoutedEventArgs e)
        {
            if (LightDark)
            {
                LightDark = false;
                new PaletteHelper().ReplacePrimaryColor("LightBlue");
                new PaletteHelper().SetLightDark(false);
            }

            else
            {
                LightDark = true;
                new PaletteHelper().SetLightDark(LightDark);
                new PaletteHelper().ReplaceAccentColor("lightgreen");
                new PaletteHelper().ReplacePrimaryColor("lightgreen");
            }
        }

        private async void MetroWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            e.Cancel = !_shutdown;
            if (_shutdown) return;

            var mySettings = new MetroDialogSettings()
            {
                AffirmativeButtonText = "Salir",
                NegativeButtonText = "Cancelar",
                AnimateShow = true,
                AnimateHide = false
            };

            var result = await this.ShowMessageAsync("¿Salir de la aplicación?",
                "¿Seguro que quieres salir de la aplicación?",
                MessageDialogStyle.AffirmativeAndNegative, mySettings);

            _shutdown = result == MessageDialogResult.Affirmative;

            if (_shutdown)
                Application.Current.Shutdown();
        }

        private void Volver_Click(object sender, RoutedEventArgs e)
        {
            Principal.NavigationService.Navigate(home);
            Volver.Visibility = Visibility.Hidden;
            Titulo.Text = "";
        }
    }
}
