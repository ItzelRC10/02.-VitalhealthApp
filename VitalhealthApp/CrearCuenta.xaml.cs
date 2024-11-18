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

        // Validar que el tel�fono no est� vac�o
        if (string.IsNullOrWhiteSpace(telefono))
        {
            await DisplayAlert("Error", "Por favor, ingrese su n�mero de tel�fono.", "OK");
            return;
        }

        string mensajeVerificacion = "Tu c�digo de verificaci�n para crear la cuenta es:";
        bool resultado = await objServicioAPI.EnviarSMSVerificacion(telefono,mensajeVerificacion);

        if (resultado)
        {
            await DisplayAlert("�xito", "El SMS de verificaci�n se ha enviado correctamente.", "OK");
        }
        else
        {
            await DisplayAlert("Error", "Hubo un error al enviar el SMS. Intenta de nuevo.", "OK");
        }
    }
}