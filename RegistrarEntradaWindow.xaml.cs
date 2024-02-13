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
using CineApp.models;

namespace CineApp;
/// <summary>
/// Lógica de interacción para RegistrarEntradaWindow.xaml
/// </summary>
public partial class RegistrarEntradaWindow : Window
{
    public static List<Entrada> EntradasRegistradas = new List<Entrada>();
    private RegistroEntrada registroEntrada = new RegistroEntrada();

    public RegistrarEntradaWindow()
    {
        InitializeComponent();
        this.DataContext = registroEntrada;
        ComboBoxPeliculas.ItemsSource = CarteleraWindow.Movies;
    }

    private void Registrar_Click(object sender, RoutedEventArgs e)
    {
        ProgressBarCompra.Visibility = Visibility.Visible;
        // Aquí recoges la información de los campos
        var cliente = TextBoxNombre.Text;
        var fecha = DatePickerFecha.SelectedDate.GetValueOrDefault();
        var hora = TextBoxHora.Text;
        var peliculaSeleccionada = (Movie)ComboBoxPeliculas.SelectedItem;

        // Creas una nueva entrada y la añades a la lista
        var nuevaEntrada = new Entrada(cliente, fecha, hora, peliculaSeleccionada);
        EntradasRegistradas.Add(nuevaEntrada);

        ProgressBarCompra.Visibility = Visibility.Collapsed;
        MessageBox.Show("Entrada comprada con éxito", "Confirmación", MessageBoxButton.OK, MessageBoxImage.Information);

        LimpiarCampos();

    }


    private void LimpiarCampos()
    {
        TextBoxNombre.Text = string.Empty;
        DatePickerFecha.SelectedDate = null; // O establece una fecha por defecto si lo prefieres
        TextBoxHora.Text = string.Empty;
        ComboBoxPeliculas.SelectedIndex = -1; // Esto deseleccionará cualquier película seleccionada
    }
    private void Volver_Click(object sender, RoutedEventArgs e)
    {
        this.Close(); // Cierra la ventana actual
    }

}

