using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp
{
    public class Equipo
    {
        

        public string Nombre { get; set; }
        public string Dt { get; set; }

        public Equipo()
        {
            Nombre = string.Empty;
            Dt = string.Empty;
        }

        public Equipo(string nombre, string dt, List<Jugador> lJugadores)
        {
            Nombre = nombre;
            Dt = dt;
        }

    }
}
