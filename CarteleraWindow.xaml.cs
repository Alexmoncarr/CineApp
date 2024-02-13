using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CineApp;
/// <summary>
/// Lógica de interacción para CarteleraWindow.xaml
/// </summary>
public partial class CarteleraWindow : Window
{
    public static List<Movie> Movies = new List<Movie>
    {
        new Movie("CUALQUIERA MENOS TU", "pack://application:,,,/sources/Cualquiera_menos_tu_2023.jpg", "Bea (Sydney Sweeney) y Ben (Glen Powell) parecen la pareja perfecta, pero tras una increíble primera cita sucede algo que enfría su fuerte atracción, hasta que se encuentran inesperadamente en una boda en Australia. Así que hacen lo que cualquier adulto haría: fingir que son una pareja…", "https://www.youtube.com/watch?v=8IexmOK7HBQ&pp=ygUbY3VhbHF1aWVyYSBtZW5vcyB0dSB0cmFpbGVy"),
        new Movie("WONKA", "pack://application:,,,/sources/wonka_2023.jpg", "La película cuenta la historia de cómo el inventor, mago y chocolatero más importante del mundo se convirtió en el popular Willy Wonka que conocemos hoy.", "https://www.youtube.com/watch?v=EJoom2F-7nI&pp=ygUNd29ua2EgdHJhaWxlcg%3D%3D"),
        new Movie("OCHO APELLIDOS MARROQUIS", "pack://application:,,,/sources/ocho_apellidos_marroquis_2023.jpg", "La muerte del patriarca de los Díaz-Aguirre pone patas arriba el perfecto universo de la familia. En su testamento, pide a su mujer (Elena Irureta) que recupere el Sardinete, el primer pesquero de su flota...", "https://www.youtube.com/watch?v=5FLMMzpmunI&pp=ygUgdHJhaWxlciA4IGFwZWxsaWRvcyBtYXJyb3F1w61lcyA%3D"),
        new Movie("LA PISCINA", "pack://application:,,,/sources/La_piscina_2024.jpg", "Ray Waller, una estrella del béisbol obligada a retirarse prematuramente a causa de una enfermedad degenerativa, se muda a una nueva casa con su esposa...", "https://www.youtube.com/watch?v=-HJsUR1p85I&pp=ygUSdHJhaWxlciBsYSBwaXNjaW5h"),
        new Movie("FERRARI", "pack://application:,,,/sources/ferrari_2023.jpg", "Ambientada durante el verano de 1957. El ex piloto de carreras, Ferrari, está en crisis. La bancarrota acecha a la empresa que él y su esposa, Laura, construyeron de...", "https://www.youtube.com/watch?v=ERIBTIlVVJQ&pp=ygUPdHJhaWxlciBmZXJyYXJp")
    };

    public CarteleraWindow()
    {
        InitializeComponent();
        ItemsControlMovies.ItemsSource = Movies;
    }

    private void OnPlayTrailerClick(object sender, RoutedEventArgs e)
    {
        var button = sender as FrameworkElement;
        if (button != null && button.DataContext is Movie movie)
        {
            var trailerUrl = movie.TrailerUrl;
            if (!string.IsNullOrWhiteSpace(trailerUrl))
            {
                try
                {
                    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                    {
                        FileName = trailerUrl,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"No se pudo abrir el tráiler: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }




    private void Volver_Click(object sender, RoutedEventArgs e)
    {
        this.Close(); // Cierra la ventana actual
    }


}

