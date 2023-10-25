using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp
{
    public class Posicion
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

        public Posicion()
        {
            Nombre = string.Empty;
        }

        public Posicion(string nombre)
        {
            Nombre = nombre;
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}
