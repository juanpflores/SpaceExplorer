using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SpaceExplorers1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {

            InitializeComponent();
            

            // Establecer el contexto de datos del control ListBox control en los datos de ejemplo
            DataContext = App.ViewModel;

        }

        // Cargar datos para los elementos ViewModel
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (!App.ViewModel.IsDataLoaded)
            {
                App.ViewModel.LoadData();
                
            }
        }

     
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Preguntas.xaml", UriKind.Relative));
        }

        
			// TODO: Agregar implementación de controlador de eventos aquí.
        

        private void Acerca_Click_1(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AcercaDe.xaml", UriKind.Relative));
        }

        private void Tuto_Click(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tutorial.xaml", UriKind.Relative));
        }

        private void Image_DoubleTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Logros.xaml", UriKind.Relative));
        }

        private void Image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Tienda.xaml", UriKind.Relative));
        }
    }
}