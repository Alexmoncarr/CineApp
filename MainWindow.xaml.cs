using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CineApp;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var movieImages = new List<string>
        {
            "pack://application:,,,/sources/aquaman_y_el_reino_perdido_2023.jpg", // Asegúrate de que las rutas sean correctas
            "pack://application:,,,/sources/Argylle_2024.jpg",
            "pack://application:,,,/sources/Beekeeper_El_protector_2024.jpg",
            "pack://application:,,,/sources/Chicas_malas_2024.jpg",
            "pack://application:,,,/sources/Cualquiera_menos_tu_2023.jpg",
            "pack://application:,,,/sources/Cuando_acecha_la_maldad_2023.jpg"
            // Añade todas tus imágenes aquí
        };

        // Establece la fuente de datos
        MovieGallery.ItemsSource = movieImages;
    }

    private void BtnCartelera_Click(object sender, RoutedEventArgs e)
    {
        CarteleraWindow carteleraWindow = new CarteleraWindow();
        carteleraWindow.Owner = this;
        carteleraWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        carteleraWindow.ShowDialog();
    }

    private void BtnRegistrarEntrada_Click(object sender, RoutedEventArgs e)
    {
        RegistrarEntradaWindow registrarEntradaWindow = new RegistrarEntradaWindow();
        registrarEntradaWindow.Owner = this;
        registrarEntradaWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        registrarEntradaWindow.ShowDialog();
    }

    private void BtnGestionEntradas_Click(object sender, RoutedEventArgs e)
    {
        GestionEntradasWindow gestionEntradasWindow = new GestionEntradasWindow();
        gestionEntradasWindow.Owner = this;
        gestionEntradasWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        gestionEntradasWindow.ShowDialog();
    }

    private void BtnOpcionExtra_Click(object sender, RoutedEventArgs e)
    {
        OpcionExtraWindow opcionExtraWindow = new OpcionExtraWindow();
        opcionExtraWindow.Owner = this;
        opcionExtraWindow.WindowStartupLocation = WindowStartupLocation.CenterOwner;
        opcionExtraWindow.ShowDialog();
    }
}
