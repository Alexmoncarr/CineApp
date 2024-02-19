using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineApp.models
{
    using System.ComponentModel;

    public class RegistroEntrada : IDataErrorInfo
    {
        public string Nombre
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
        public Movie PeliculaSeleccionada
        {
            get; set;
        }

        public string Error => null;

        public bool HasErrors
        {
            get;
            internal set;
        }

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                switch (columnName)
                {
                    case nameof(Nombre):
                        if (string.IsNullOrEmpty(Nombre))
                        {
                            result = "El nombre no puede estar vacío.";
                        }

                        break;
                    case nameof(Fecha):
                        //la fecha no puede ser en el pasado
                        if (Fecha <= DateTime.Now)
                        {
                            result = "La fecha no puede ser en el pasado.";
                        }

                        break;
                    case nameof(Hora):
                        if (string.IsNullOrEmpty(Hora))
                        {
                            result = "La hora no puede estar vacía.";
                        }
                        break;
                    case nameof(PeliculaSeleccionada):
                        if (PeliculaSeleccionada == null)
                        {
                            result = "Debe seleccionar una película.";
                        }

                        break;
                }
                return result;
            }
        }
    }

}
