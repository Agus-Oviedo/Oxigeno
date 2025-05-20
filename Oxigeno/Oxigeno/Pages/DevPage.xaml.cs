using System;
using Microsoft.Maui.Controls;

namespace Oxigeno.Pages
{
    public partial class DevPage : ContentPage
    {
        public DevPage()
        {
            InitializeComponent();
        }

        private void OnDevClicked(object sender, EventArgs e)
        {
            // Aquí puedes implementar la lógica para el botón "DESARROLLADOR"
            DisplayAlert("Desarrollador", "Has pulsado DESARROLLADOR", "OK");
        }

        private void OnProfileClicked(object sender, EventArgs e)
        {
            // Aquí puedes implementar la lógica para el botón "Agustín.OVIEDO"
            DisplayAlert("Perfil", "Has pulsado Agustín.OVIEDO", "OK");
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            // Navega de vuelta al menú principal
            await Shell.Current.GoToAsync(nameof(MenuPage));
        }
    }
}
