using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Policy;
using System.Data;

namespace EquipoApp.Datos
{
    public class Helper
    {
        SqlConnection conexion;
        SqlCommand comando;



        public Helper()
        {
            //conexion = new SqlConnection(Properties.Resources.cadenaConexionPcCasa);
            conexion = new SqlConnection(Properties.Resources.cadenaConexionPcCas);
            comando = new SqlCommand();
        }

        public void AbrirConexion()
        {
            conexion.Open();
        }

        public void CerrarConexion()
        {
            conexion.Close();
        }

        public DataTable CargarCombos(string nomSp)
        {
            AbrirConexion();
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nomSp;
            DataTable dt = new DataTable();
            dt.Load(comando.ExecuteReader());
            CerrarConexion();
            return dt;
        }

    }
}
