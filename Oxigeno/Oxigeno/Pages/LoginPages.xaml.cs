namespace Oxigeno.Pages;

public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();

    }

    private async void btnLogin_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text?.Trim();
        string contrasena = txtContrasena.Text?.Trim();

        if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrasena))
        {
            lblMensaje.Text = "Ingrese usuario y contraseña.";
            lblMensaje.IsVisible = true;
        }
        else if (usuario == "agustin" && contrasena == "111111")
        {
            lblMensaje.IsVisible = false;
    
            // para ir al menú principal
            await Navigation.PushAsync(new MenuPage());
        }
        else
        {
            lblMensaje.Text = "Usuario o contraseña incorrectos.";
            lblMensaje.IsVisible = true;
        }
    }
}