using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EquipoApp
{
    public partial class FrmListarPersonas : Form
    {
        SqlConnection conexion;
        SqlCommand comando;
        List<Persona> lPersonas;
        public FrmListarPersonas()
        {
            InitializeComponent();
            conexion = new SqlConnection(Properties.Resources.cadenaConexionPcCasa);
            comando = new SqlCommand();
            lPersonas = new List<Persona>();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListarPersonas_Load(object sender, EventArgs e)
        {
            lstPersonas.Items.Clear();
            CargarLista();
        }

        private void CargarLista()
        {
            AbrirConexion();
            DataTable dt = new DataTable();
            dt.Clear();
            comando.Connection = conexion;
            comando.CommandText = "SP_LISTAR_PERSONAS";
            dt.Load(comando.ExecuteReader());
            CerraConexion();

           foreach (DataRow dr in dt.Rows)
            {
                string nombre = dr["nombre"].ToString();
                int dni = Convert.ToInt32(dr["DNI"]);
                DateTime fechaNac = Convert.ToDateTime(dr[3]);

                Persona p = new Persona(nombre, dni, fechaNac);

                lPersonas.Add(p);
            }

            lstPersonas.DataSource = lPersonas;
            

            
        }

        private void CerraConexion()
        {
            conexion.Close();
        }

        private void AbrirConexion()
        {
            conexion.Open();
        }
    }
}
