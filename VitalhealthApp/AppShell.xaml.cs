namespace VitalhealthApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("CambioContrasena", typeof(CambioContrasena));
            Routing.RegisterRoute("mainCliente", typeof(MainCliente)); // Ruta para la pantalla principal después del login
        }
    }
}
