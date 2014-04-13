using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace SpaceExplorers1
{
    public partial class Preguntas : PhoneApplicationPage
    {
        public Preguntas()
        {
            InitializeComponent();
        }

        private void Dudas_Click(object sender, EventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Fin.xaml", UriKind.Relative));
        }
    }
}