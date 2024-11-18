namespace VitalhealthApp;

public partial class Login : ContentPage
{
    private readonly ApiService objApiService;

    public Login(ApiService apiService)
	{
		InitializeComponent();
        objApiService = apiService;

    }

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync("CambioContrasena");
    }
     
    private async void BTNIngresar_Clicked(object sender, EventArgs e)
    {
        //// Validación de credenciales del usuario aquí...
        //bool loginSuccessful = true; // Reemplaza esto con tu lógica de autenticación

        //if (loginSuccessful)
        //{
        //    // Navega a la pantalla principal después del login
        //    await Shell.Current.GoToAsync("//mainCliente");
        //}
        //else
        //{
        //    await DisplayAlert("Error", "Credenciales incorrectas", "OK");
        //}
    }

    private async void BTNCrearCuenta_Clicked(object sender, EventArgs e)
    {
        // Navegar a CrearCuenta y pasar ApiService al constructor
        await Navigation.PushModalAsync(new CrearCuenta(objApiService));
    }
}