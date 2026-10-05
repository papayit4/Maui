using ProyectoFinalMAUI.Views;

namespace ProyectoFinalMAUI;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        // Registrar la ruta para la pantalla de detalle (Navegación GoToAsync)
        Routing.RegisterRoute(nameof(DetallePage), typeof(DetallePage));
    }
}