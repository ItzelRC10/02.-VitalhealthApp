using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;


namespace VitalhealthApp
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, LaunchMode = LaunchMode.SingleTop, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            //Ocultar la barra de navegación y la barra de estado
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)(
                SystemUiFlags.LayoutStable |
                //SystemUiFlags.LayoutHideNavigation |
                SystemUiFlags.LayoutFullscreen |
                //SystemUiFlags.HideNavigation |
                SystemUiFlags.Fullscreen |
                SystemUiFlags.ImmersiveSticky);
        }

        // Asegura que la configuración de pantalla completa persista al volver a la actividad
        protected override void OnResume()
        {
            base.OnResume();
            Window.DecorView.SystemUiVisibility = (StatusBarVisibility)(
                //SystemUiFlags.LayoutStable |
                //SystemUiFlags.LayoutHideNavigation |
                SystemUiFlags.LayoutFullscreen |
                SystemUiFlags.HideNavigation |
                SystemUiFlags.Fullscreen |
                SystemUiFlags.ImmersiveSticky
            );
        }
    }
}
