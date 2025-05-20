using System;
using Microsoft.Maui.Controls;

namespace Oxigeno.Pages
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void OnNosotrosClicked(object sender, EventArgs e)
        {
            // Nos lleva a DevPage (Nosotros)
            await Shell.Current.GoToAsync("//DevPage");
        }

        private async void OnServiciosClicked(object sender, EventArgs e)
        {
            // Nos lleva a ServiciosPage
            await Shell.Current.GoToAsync("//ServiciosPage");
        }

        private async void OnLogoutClicked(object sender, EventArgs e)
        {
            // Vuelve al LoginPage
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
