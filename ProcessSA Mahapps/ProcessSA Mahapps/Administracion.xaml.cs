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

namespace ProcessSA_Mahapps
{
    /// <summary>
    /// Lógica de interacción para Administracion.xaml
    /// </summary>
    public partial class Administracion : Page
    {
        public Administracion()
        {
            InitializeComponent();
        }

        MetroWindow window = Application.Current.MainWindow as MetroWindow;

        private void BtnUsuarios_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Usuarios());
        }

        private void BtnTareas_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Tareas());
        }
    }
}