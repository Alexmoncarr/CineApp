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
/// Lógica de interacción para EditarEntradaWindow.xaml
/// </summary>
public partial class EditarEntradaWindow : Window
{
    private Entrada entradaActual;

    public EditarEntradaWindow(Entrada entrada)
    {
        InitializeComponent();
        entradaActual = entrada;
        ComboBoxPeliculas.ItemsSource = CarteleraWindow.Movies;
        CargarDatosEntrada();
    }

    private void CargarDatosEntrada()
    {
        TextBoxNombre.Text = entradaActual.Cliente;
        DatePickerFecha.SelectedDate = entradaActual.Fecha;
        TextBoxHora.Text = entradaActual.Hora;
        ComboBoxPeliculas.SelectedItem = entradaActual.Pelicula;
    }

    private void GuardarCambios_Click(object sender, RoutedEventArgs e)
    {
        // Aquí actualizas la entrada con los nuevos datos
        entradaActual.Cliente = TextBoxNombre.Text;
        entradaActual.Fecha = DatePickerFecha.SelectedDate.GetValueOrDefault();
        entradaActual.Hora = TextBoxHora.Text;
        entradaActual.Pelicula = (Movie)ComboBoxPeliculas.SelectedItem;

        this.Close();
    }

    private void Volver_Click(object sender, RoutedEventArgs e)
    {
        this.Close(); // Cierra la ventana actual
    }

}

