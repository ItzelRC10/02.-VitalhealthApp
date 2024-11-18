namespace VitalhealthApp;

public partial class CrearCuenta : ContentPage
{
    private readonly ApiService objServicioAPI;

    public CrearCuenta(ApiService apiService)
	{
		InitializeComponent();
        objServicioAPI = apiService;

    }

    private void IMGBTNMostrarContrasenaCC_Clicked(object sender, EventArgs e)
    {

    }

    private async void BTNVerTelCC_Clicked(object sender, EventArgs e)
    {
        string telefono = ETTelefono.Text;

        // Validar que el teléfono no esté vacío
        if (string.IsNullOrWhiteSpace(telefono))
        {
            await DisplayAlert("Error", "Por favor, ingrese su número de teléfono.", "OK");
            return;
        }

        string mensajeVerificacion = "Tu código de verificación para crear la cuenta es:";
        bool resultado = await objServicioAPI.EnviarSMSVerificacion(telefono,mensajeVerificacion);

        if (resultado)
        {
            await DisplayAlert("Éxito", "El SMS de verificación se ha enviado correctamente.", "OK");
        }
        else
        {
            await DisplayAlert("Error", "Hubo un error al enviar el SMS. Intenta de nuevo.", "OK");
        }
    }
}