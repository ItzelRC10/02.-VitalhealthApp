namespace VitalhealthApp;

public partial class CambioContrasena : ContentPage
{
	public CambioContrasena()
	{
		InitializeComponent();

        // Oculta la barra de navegaci�n en esta p�gina
        Shell.SetNavBarIsVisible(this, false);
    }

    private void IMGBTNMostrarContrasena_Clicked(object sender, EventArgs e)
    {

    }

    private void BTNCambioCon1_Clicked(object sender, EventArgs e)
    {
        IMGBTNMostrarContrasena.Source = "ojo.png";
        DisplayAlert("Omaiga", "Ya prendi� tu", "OK");
    }
}