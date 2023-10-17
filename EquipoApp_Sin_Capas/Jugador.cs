using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquipoApp
{
    public class Jugador
    {
		private Persona oPersona;
		private int nroCamiseta;
		private Posicion posicion;

		public Posicion Posicion
		{
			get { return posicion; }
			set { posicion = value; }
		}

		public int NroCamiseta
		{
			get { return nroCamiseta; }
			set { nroCamiseta = value; }
		}

		public Persona Persona
		{
			get { return oPersona; }
			set { oPersona = value; }
		}

        public Jugador()
        {
            Persona = new Persona();
			NroCamiseta = 0;
			Posicion = new Posicion();
        }

        public Jugador(Persona oPers,int nro, Posicion oPos)
        {
			Persona = oPers;
			NroCamiseta = nro;
			Posicion = oPos;
        }

        public override string ToString()
        {
            return "Jugador: "+Persona.ToString()+"|Camiseta:"+NroCamiseta.ToString()+"|Posicion:"+ Posicion.ToString();
        }
    }
}
