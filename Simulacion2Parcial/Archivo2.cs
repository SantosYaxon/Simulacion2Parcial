using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion2Parcial
{
    internal class Archivo2
    {
        string nombre;
        string temperatura;
        DateTime fecha;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Temperatura { get => temperatura; set => temperatura = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
    }
}
