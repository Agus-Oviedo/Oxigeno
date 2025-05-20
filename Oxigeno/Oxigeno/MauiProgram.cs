using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using Oxigeno;
using Oxigeno.Pages;   // Importa el namespace donde tienes tus páginas

namespace Oxigeno
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();

            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    // Tu configuración de fuentes si la tenías
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // **REGISTRO EXPLÍCITO DE RUTAS**
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(MenuPage), typeof(MenuPage));
            Routing.RegisterRoute(nameof(ServiciosPage), typeof(ServiciosPage));
            Routing.RegisterRoute(nameof(DevPage), typeof(DevPage));

            return builder.Build();
        }
    }
}
