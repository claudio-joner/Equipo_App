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
    public partial class FrmAltaEquipo : Form
    {
        SqlConnection connection;
        SqlCommand cmd;
        public FrmAltaEquipo()
        {
            InitializeComponent();
            connection = new SqlConnection(Properties.Resources.cadenaConexionPc);
            cmd = new SqlCommand();
        }

        private void FrmNuevoEquipo_Load(object sender, EventArgs e)
        {
            AbrirConexion();
            CargarComboDt();
            CerrarConexion();
            Limpiar();
        }

        private void CargarComboDt()
        {
            DataTable tablaDt = new DataTable();
           
            cmd.Connection = connection;
            cmd.CommandText = "SP_LISTAR_PERSONAS";
            cmd.CommandType = CommandType.StoredProcedure;
            tablaDt.Load(cmd.ExecuteReader());
            
            cboDt.DataSource = tablaDt;
            cboDt.DisplayMember = "NOMBRE";
            cboDt.ValueMember = "ID";
        }

        private void CerrarConexion()
        {
            connection.Close();
        }

        private void AbrirConexion()
        {
            connection.Open();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           Limpiar();
        }

        private void Limpiar()
        {
            txtNombreEquipo.Text = string.Empty;
            txtNombreEquipo.Focus();
            cboDt.SelectedIndex = 0;
        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
