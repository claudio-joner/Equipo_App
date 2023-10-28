using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices.WindowsRuntime;
using EquipoApp.Datos;

namespace EquipoApp
{
    public partial class FrmAltaJugador : Form
    {
       Helper gestor;
       SqlCommand comando;
        SqlConnection conexion;
        
        public FrmAltaJugador()
        {
            InitializeComponent();
            gestor = new Helper();
            //Creamos un jugador
            Jugador jugador = new Jugador();
            comando = new SqlCommand();
            conexion = new SqlConnection(Properties.Resources.cadenaConexionPcCas);
            
        }

        private void btnCancelarNuevoJuegador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaJugador_Load(object sender, EventArgs e)
        {
           
            CargarComboPersonas();
            CargarComboPosiciones();

            Limpiar();
        }

        private void CargarComboPosiciones()
        {
            cboPosicion.DataSource = gestor.CargarCombos("SP_LISTAR_POSICIONES");
            cboPosicion.DisplayMember = "NOMBRE_POSICION";
            cboPosicion.ValueMember = "ID";

        }

        private void CargarComboPersonas()
        {
            //DataTable tablaPersonas = new DataTable();

            //comando.Connection = conexion;
            //comando.CommandText = "SP_LISTAR_PERSONAS";//Nombre sp
            //comando.CommandType = CommandType.StoredProcedure;

            //tablaPersonas.Load(comando.ExecuteReader());//Cargo los datos con la tabla
            
            cboPersonas.DataSource = gestor.CargarCombos("SP_LISTAR_PERSONAS"); ;
            cboPersonas.DisplayMember = "NOMBRE";
            cboPersonas.ValueMember = "ID";

        }

        private void Limpiar()
        {
            cboPersonas.SelectedIndex = -1;
            cboPosicion.SelectedIndex = -1;
            txtNroCamiseta.Text= string.Empty ;
            this.ActiveControl = cboPersonas;
        }

        private void btnAceptarNuevoJug_Click(object sender, EventArgs e)
        {
            SqlTransaction t = null ;
            try
            {
                if (Validar())
                {
                    conexion.Open();
                    t = conexion.BeginTransaction();
                    SqlCommand cmd = new SqlCommand("SP_INSERTAR_JUGADORES", conexion, t);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@persona",(int)cboPersonas.SelectedValue);//Obtengo el ValueMember
                    cmd.Parameters.AddWithValue("@camiseta",Convert.ToInt32(txtNroCamiseta.Text));
                    cmd.Parameters.AddWithValue("@posicion",cboPosicion.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se agrego con éxito");
                    t.Commit();
                }
            }
            catch (Exception)
            {
                if (t == null)
                    t.Rollback();
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    gestor.CerrarConexion();
            }

        }

        private bool Validar()
        {
            if (cboPersonas.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una persona.","Importante",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            if (cboPosicion.SelectedIndex < 0)
            {
                MessageBox.Show("Debe seleccionar una posición.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (String.IsNullOrEmpty(txtNroCamiseta.Text))
            {
                MessageBox.Show("Debe ingresar un numero de camiseta.", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        
            return true;
        }

    }
}
