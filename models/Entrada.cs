using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp;
public class Entrada
{
    public string Cliente
    {
        get; set;
    }
    public DateTime Fecha
    {
        get; set;
    }
    public string Hora
    {
        get; set;
    }
    public Movie Pelicula
    {
        get; set;
    }

    public Entrada(string cliente, DateTime fecha, string hora, Movie pelicula)
    {
        Cliente = cliente;
        Fecha = fecha;
        Hora = hora;
        Pelicula = pelicula;
    }

    // Este método se utiliza para mostrar la información en la lista
    public override string ToString()
    {
        return $"{Cliente} - {Pelicula.Title} - {Fecha.ToShortDateString()} - {Hora}";
    }
}

