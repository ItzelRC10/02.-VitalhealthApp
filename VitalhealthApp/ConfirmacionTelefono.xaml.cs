namespace VitalhealthApp;

public partial class ConfirmacionTelefono : ContentPage
{

    public ConfirmacionTelefono()
	{
		InitializeComponent();
	}

    private async void BTNConfTel_Clicked(object sender, EventArgs e)
    {
        // Verificar si el campo de c�digo no est� vac�o
        //if (string.IsNullOrWhiteSpace(ETCodigo.Text))
        //{
        //    await DisplayAlert("Aviso", "Por favor, ingresa el c�digo de verificaci�n.", "OK");
        //    return;
        //}

        //string codigo = ETCodigo.Text;
        //string resultado = null;

        //try
        //{
        //    // Llamar al m�todo de verificaci�n en ApiService y asignar el resultado
        //    resultado = await objServicioAPI.VerificarCodigo(codigo);
        //}
        //catch (Exception ex)
        //{
        //    // Mostrar un mensaje de error en caso de excepci�n
        //    await DisplayAlert("Error", $"Hubo un problema con la verificaci�n: {ex.Message}", "OK");
        //    return;
        //}

        //// Verificar si el resultado no es null o vac�o, lo que indica una verificaci�n exitosa
        //if (!string.IsNullOrEmpty(resultado))
        //{
        //    await DisplayAlert("�xito", "Verificaci�n exitosa.", "OK");
        //    // Navegar a la pantalla de inicio de sesi�n si la verificaci�n fue exitosa
        //    await Navigation.PushAsync(new Login());
        //}
        //else
        //{
        //    await DisplayAlert("Error", "Verificaci�n fallida. El c�digo ingresado es incorrecto.", "OK");
        //}
    }
}