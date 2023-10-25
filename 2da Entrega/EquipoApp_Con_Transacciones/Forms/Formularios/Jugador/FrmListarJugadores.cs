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
    public partial class FrmListarJugadores : Form
    {
        SqlConnection conexion;
        SqlCommand comando;

        public FrmListarJugadores()
        {
            InitializeComponent();
            conexion = new SqlConnection(Properties.Resources.cadenaConexionPcCasa);
            comando = new SqlCommand();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListarJugadores_Load(object sender, EventArgs e)
        {
            AbrirConexion();
            DataTable dt = new DataTable();
            dt.Clear();
            comando.Connection = conexion;
            comando.CommandText = "SP_LISTAR_JUGADORES";
            dt.Load(comando.ExecuteReader());
            CerraConexion();

            dgvJugadores.DataSource = dt;
            //Ubicar la columna al final
            DataGridViewColumn columna = dgvJugadores.Columns["ColEditar"];
            
            columna.DisplayIndex = 3 ;

            //Ocultar columnas
            //dgvJugadores.Columns["ID"].Visible = false;
            //dgvJugadores.Columns["FECHA_NACIMIENTO"].Visible = false;

            //Calcular la edad 
            //Otra forma sería Creando una lista de jugadores,hacer un foreach ,de almacenar en variables, crear un jugador
            // y acceder al metod  para calcular edad.
            //foreach (DataGridViewRow dr in dgvJugadores.Rows)
            //{
            //    int edad = DateTime.Now.Year - Convert.ToDateTime(dr.Cells["FECHA_NACIMIENTO"].Value).Year;
            //    dr.Cells["ColEdad"].Value = edad;
            //}


        }

        private void CerraConexion()
        {
            conexion.Close();
        }

        private void AbrirConexion()
        {
            conexion.Open();
        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
