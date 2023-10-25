using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp.Datos
{
    public class Parametro
    {
		private object valor;
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		public object Valor
		{
			get { return valor; }
			set { valor = value; }
		}


        public Parametro(string nom, object valor)
        {
			Nombre = nom;
			Valor = valor;
        }
    }
}
