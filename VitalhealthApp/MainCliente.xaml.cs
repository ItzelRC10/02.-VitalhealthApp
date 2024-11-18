namespace VitalhealthApp;

public partial class MainCliente : ContentPage
{
	public MainCliente()
	{
		InitializeComponent();
        BindingContext = new ViewModel();
    }

    private void BTNNotificaciones_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("OGOAO", "ia prendio tu", "Oc");
    }
}