using System;
using Microsoft.Maui.Controls;

namespace Oxigeno.Pages
{
    public partial class ServiciosPage : ContentPage
    {
        public ServiciosPage()
        {
            InitializeComponent();
        }

        private async void OnFerreteriaClicked(object sender, EventArgs e)
        {
            // TODO: Lógica cuando se pulsa FERRETERIA
            await DisplayAlert("Servicio", "Has seleccionado FERRETERIA", "OK");
        }

        private async void OnBuloneriaClicked(object sender, EventArgs e)
        {
            // TODO: Lógica cuando se pulsa BULONERÍA
            await DisplayAlert("Servicio", "Has seleccionado BULONERÍA", "OK");
        }

        private async void OnGasesClicked(object sender, EventArgs e)
        {
            // TODO: Lógica cuando se pulsa GASES
            await DisplayAlert("Servicio", "Has seleccionado GASES", "OK");
        }

        private async void OnSoldaduraClicked(object sender, EventArgs e)
        {
            // TODO: Lógica cuando se pulsa SOLDADURA
            await DisplayAlert("Servicio", "Has seleccionado SOLDADURA", "OK");
        }

        private async void OnVolverClicked(object sender, EventArgs e)
        {
            // Navega de vuelta al menú principal
            await Shell.Current.GoToAsync(nameof(MenuPage));
        }
    }
}
