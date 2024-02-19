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
/// Lógica de interacción para GestionEntradasWindow.xaml
/// </summary>
public partial class GestionEntradasWindow : Window
{
    public GestionEntradasWindow()
    {
        InitializeComponent();
        ActualizarListaEntradas();
    }

    private void ActualizarListaEntradas()
    {
        ListaEntradas.ItemsSource = null;
        ListaEntradas.ItemsSource = RegistrarEntradaWindow.EntradasRegistradas;
    }

    private void ModificarEntrada_Click(object sender, RoutedEventArgs e)
    {
        // Obtén la entrada seleccionada
        var entradaSeleccionada = (Entrada)ListaEntradas.SelectedItem;

        if (entradaSeleccionada != null)
        {
            var editarVentana = new EditarEntradaWindow(entradaSeleccionada);
            editarVentana.Owner=this;
            editarVentana.WindowStartupLocation = WindowStartupLocation.CenterOwner;
            editarVentana.ShowDialog();

            // Actualiza la lista para reflejar los cambios
            ActualizarListaEntradas();
        }
    }

    private void EliminarEntrada_Click(object sender, RoutedEventArgs e)
    {
        var entradaSeleccionada = (Entrada)ListaEntradas.SelectedItem;

        if (entradaSeleccionada != null)
        {
            var result = MessageBox.Show("¿Eliminar entrada?", "Eliminar", MessageBoxButton.YesNo, MessageBoxImage.Warning);
            if ( result == MessageBoxResult.Yes )
            {
                RegistrarEntradaWindow.EntradasRegistradas.Remove(entradaSeleccionada);
                ActualizarListaEntradas();
            }
            
        }
    }
    private void Volver_Click(object sender, RoutedEventArgs e)
    {
        this.Close(); // Cierra la ventana actual
    }

}


