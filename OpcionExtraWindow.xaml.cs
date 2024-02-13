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
/// Lógica de interacción para OpcionExtraWindow.xaml
/// </summary>
public partial class OpcionExtraWindow : Window
{
    public OpcionExtraWindow()
    {
        InitializeComponent();
    }
    private void Volver_Click(object sender, RoutedEventArgs e)
    {
        this.Close(); // Cierra la ventana actual
    }
    private void AbrirGuia_Click(object sender, RoutedEventArgs e)
    {
        string urlGuia = "https://cineapp.github.io/"; 

        try
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
            {
                FileName = urlGuia,
                UseShellExecute = true // Es necesario para .NET Core y versiones superiores.
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"No se pudo abrir la guía: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

}
