using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp
{
    public class Persona
    {
		private string nombrePersona;
		private int dni;
		private DateTime fechaNacimiento;

		public DateTime FechaNacimiento
		{
			get { return fechaNacimiento; }
			set { fechaNacimiento = value; }
		}
		public int Dni
		{
			get { return dni; }
			set { dni = value; }
		}
		public string NombrePersona
		{
			get { return nombrePersona; }
			set { nombrePersona = value; }
		}

        public Persona()
        {
			NombrePersona = string.Empty;
			Dni = 0;
			FechaNacimiento = DateTime.Now;

        }

        public Persona(string nombPers,int dni,DateTime fecha)
        {
			NombrePersona = nombPers;
			Dni = dni;
			FechaNacimiento =fecha;
        }

		public int CalcularEdad(DateTime fecha)
		{
			int edad;
			edad = DateTime.Now.Year - fecha.Year ;
			return edad;
		}
        public override string ToString()
        {
            return "Nombre: " + NombrePersona + " |Edad: " + CalcularEdad(fechaNacimiento).ToString()+ " años.";
        }
    }
}
