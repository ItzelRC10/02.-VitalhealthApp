namespace VitalhealthApp;

public partial class ConfirmacionTelefono : ContentPage
{

    public ConfirmacionTelefono()
	{
		InitializeComponent();
	}

    private async void BTNConfTel_Clicked(object sender, EventArgs e)
    {
        // Verificar si el campo de código no está vacío
        //if (string.IsNullOrWhiteSpace(ETCodigo.Text))
        //{
        //    await DisplayAlert("Aviso", "Por favor, ingresa el código de verificación.", "OK");
        //    return;
        //}

        //string codigo = ETCodigo.Text;
        //string resultado = null;

        //try
        //{
        //    // Llamar al método de verificación en ApiService y asignar el resultado
        //    resultado = await objServicioAPI.VerificarCodigo(codigo);
        //}
        //catch (Exception ex)
        //{
        //    // Mostrar un mensaje de error en caso de excepción
        //    await DisplayAlert("Error", $"Hubo un problema con la verificación: {ex.Message}", "OK");
        //    return;
        //}

        //// Verificar si el resultado no es null o vacío, lo que indica una verificación exitosa
        //if (!string.IsNullOrEmpty(resultado))
        //{
        //    await DisplayAlert("Éxito", "Verificación exitosa.", "OK");
        //    // Navegar a la pantalla de inicio de sesión si la verificación fue exitosa
        //    await Navigation.PushAsync(new Login());
        //}
        //else
        //{
        //    await DisplayAlert("Error", "Verificación fallida. El código ingresado es incorrecto.", "OK");
        //}
    }
}