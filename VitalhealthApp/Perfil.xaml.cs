namespace VitalhealthApp;

public partial class Perfil : ContentPage
{
	public Perfil()
	{
		InitializeComponent();
	}

    private void BTNCambiarFoto_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("omaiga", "ia prendio tu", "oc");
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        DisplayAlert("omaiga", "ia prendio tu", "oc");
    }
}