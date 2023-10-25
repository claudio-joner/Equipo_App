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

namespace EquipoApp
{
    public partial class FrmAltaJugador : Form
    {
        SqlConnection conexion;
        SqlCommand comando;
        
        public FrmAltaJugador()
        {
            InitializeComponent();
            conexion = new SqlConnection(Properties.Resources.cadenaConexionPcCasa);
            comando = new SqlCommand();
            //Creamos un jugador
            Jugador jugador = new Jugador();
            
        }

        private void btnCancelarNuevoJuegador_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAltaJugador_Load(object sender, EventArgs e)
        {
            AbrirConexion();
            CargarComboPersonas();
            CargarComboPosiciones();
            CerrarConexion();
            Limpiar();
        }

        private void CerrarConexion()
        {
            conexion.Close();
        }

        private void AbrirConexion()
        {
            conexion.Open();
        }

        private void CargarComboPosiciones()
        {
            DataTable tablaPosicion = new DataTable();
            comando.Connection = conexion;
            comando.CommandText = "SP_LISTAR_POSICIONES";
            comando.CommandType = CommandType.StoredProcedure;
            tablaPosicion.Load(comando.ExecuteReader());

            cboPosicion.DataSource = tablaPosicion;
            cboPosicion.DisplayMember = "NOMBRE_POSICION";
            cboPosicion.ValueMember = "ID";

        }

        private void CargarComboPersonas()
        {
            DataTable tablaPersonas = new DataTable();

            comando.Connection = conexion;
            comando.CommandText = "SP_LISTAR_PERSONAS";//Nombre sp
            comando.CommandType = CommandType.StoredProcedure;

            tablaPersonas.Load(comando.ExecuteReader());//Cargo los datos con la tabla
            
            cboPersonas.DataSource = tablaPersonas;
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
            try
            {
                if (Validar())
                {
                    AbrirConexion();
                    comando.Connection = conexion;
                    comando.CommandText = "SP_INSERTAR_JUGADORES";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@persona",(int)cboPersonas.SelectedValue);//Obtengo el ValueMember
                    comando.Parameters.AddWithValue("@camiseta",Convert.ToInt32(txtNroCamiseta.Text));
                    comando.Parameters.AddWithValue("@posicion",cboPosicion.SelectedValue);

                    comando.ExecuteNonQuery();
                    CerrarConexion();
                    MessageBox.Show("Se agrego con éxito");
                }
            }
            catch (Exception)
            {

                throw;
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
