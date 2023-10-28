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
using EquipoApp.Datos;

namespace EquipoApp
{
    public partial class FrmPrincipal : Form
    {
        SqlConnection conexion;
        SqlCommand comando;
        Helper gestor;


        public FrmPrincipal()
        {
            InitializeComponent();
            conexion = new SqlConnection(Properties.Resources.cadenaConexionPcCasa);
            comando = new SqlCommand();
             gestor = new Helper();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            
            //AbrirConexion();
            //DataTable dt = new DataTable();
            //dt.Clear();
            //comando.Connection = conexion;
            //comando.CommandText = "SP_LISTAR_EQUIPOS";
            //dt.Load(comando.ExecuteReader());//cargo el datatable 
            //CerraConexion();

            //Creo las columnas de manera manual
            DataGridViewColumn colId = dgvEquipos.Columns["ColId"];
            colId.DisplayIndex = 0;
            DataGridViewColumn colEqui = dgvEquipos.Columns["ColEquipo"];
            colEqui.DisplayIndex = 1;
            DataGridViewColumn colDt = dgvEquipos.Columns["ColDt"];
            colDt.DisplayIndex = 2;
            DataGridViewColumn colAccion = dgvEquipos.Columns["ColAccion"];
            colAccion.DisplayIndex = 3;

            foreach (DataRowView row in gestor.CargarCombos("SP_LISTAR_EQUIPOS").DefaultView)
            {
                int id = Convert.ToInt32(row.Row.ItemArray[0].ToString());
                string nom = row.Row.ItemArray[1].ToString();
                string nomDt = row.Row.ItemArray[2].ToString();

                dgvEquipos.Rows.Add(id, nom, nomDt);
            }

            this.Hide();
        }

        private void CerraConexion()
        {
            conexion.Close();
        }

        private void AbrirConexion()
        {
            conexion.Open();
        }

        private void nuevaPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaPersona frmNuevaPersona = new FrmAltaPersona();
            frmNuevaPersona.ShowDialog();  
        }


        private void listaPersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarPersonas frmListarPersonas = new FrmListarPersonas();
            frmListarPersonas.ShowDialog();
        }

        private void nuevoJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaJugador frmNuevoJugador = new FrmAltaJugador();
            frmNuevoJugador.ShowDialog();
        }

        private void listarJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListarJugadores frmListarJugadores = new FrmListarJugadores();
            frmListarJugadores.ShowDialog();
        }

        private void nuevoEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAltaEquipo frmNuevoEquipo = new FrmAltaEquipo();
            frmNuevoEquipo.ShowDialog();
            
        }

        private void listarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
