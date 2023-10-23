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
using System.Collections;

namespace EquipoApp
{
    public partial class FrmAltaEquipo : Form
    {
        //Atributos SQL
        SqlConnection connection;
        SqlCommand cmd;

        //Atributos Table
        DataTable tablaJugador;

        //Atributos Objetos
        Posicion oPosicion;
        Persona oPersona;
        Jugador oJugador;

        //Atributos Listas
        List<string> lNombres;
        List<Jugador> lJugadores;
        public FrmAltaEquipo()
        {
            InitializeComponent();
            connection = new SqlConnection(Properties.Resources.cadenaConexionPcCasa);
            cmd = new SqlCommand();
            tablaJugador = new DataTable();
            lNombres = new List<string>();
            lJugadores = new List<Jugador>();
        }

        private void FrmNuevoEquipo_Load(object sender, EventArgs e)
        {
            AbrirConexion();
            CargarComboDt();
            CargarDgv();
            CerrarConexion();
            Limpiar();
        }

        private void CargarDgv()
        {
            tablaJugador.Clear();
            cmd.Connection = connection;
            cmd.CommandText = "SP_LISTAR_JUGADORES";
            cmd.CommandType = CommandType.StoredProcedure;
            
            tablaJugador.Load(cmd.ExecuteReader());

            

            foreach (DataRow item in tablaJugador.Rows)
            {
                object[] fila =  item.ItemArray;

                dgvJugadores.Rows.Add(fila);
            }
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
            lstConvocados.Items.Clear();
            AbrirConexion();
            dgvJugadores.Rows.Clear();
            CargarDgv();
            CerrarConexion();
        }

        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (dgvJugadores.CurrentCell.ColumnIndex == dgvJugadores.ColumnCount - 1)
            {

                string nombre = dgvJugadores.Rows[dgvJugadores.CurrentRow.Index].Cells[0].Value.ToString();
                string numero = dgvJugadores.Rows[dgvJugadores.CurrentRow.Index].Cells[1].Value.ToString();
                string posicion = dgvJugadores.Rows[dgvJugadores.CurrentRow.Index].Cells[2].Value.ToString();
                string jugador = "Nombre: " + nombre + " |Numero: " + numero+" |Posicion: " + posicion;


                if (ValidarJugador(lNombres,nombre))
                {
                    MessageBox.Show("El jugador esta agregado.");
                    return ;
                }
                else
                {

                    lNombres.Add(nombre);
                    lstConvocados.Items.Add(jugador);
                    dgvJugadores.Rows.RemoveAt(dgvJugadores.CurrentRow.Index);

                    int nro_jugador = Convert.ToInt32(numero);
                    //EJECUTAR SP_PARAM_JUGADOR PARA CREARLO
                    AbrirConexion();
                    cmd.Connection = connection;
                    cmd.CommandText = "SP_PARAM_JUGADOR";
                    cmd.CommandType = CommandType.StoredProcedure;
                    //Limpio los parametros de cmd 
                    cmd.Parameters.Clear();
                    //agrego parametros de entrada
                    cmd.Parameters.AddWithValue("@nomJugador",nombre);
                    cmd.Parameters.AddWithValue("@nomPosicion",posicion);
                    cmd.Parameters.AddWithValue("@nro", nro_jugador);
                    //agrego parametros de salida 
                    SqlParameter dni = new SqlParameter("@dni",SqlDbType.Int);
                    dni.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(dni);
                    SqlParameter fecha = new SqlParameter("fecha_nac", SqlDbType.DateTime);
                    fecha.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(fecha);

                    cmd.ExecuteReader();

                    //Obtendo los parametros de salida
                    DateTime fecha_nac = Convert.ToDateTime(fecha.Value);
                    int dniJugador = Convert.ToInt32(dni.Value);

                    CerrarConexion();

                    //CREO la posicion del jugador
                    oPosicion = new Posicion(posicion);

                    //CREO la persona del jugador
                    oPersona = new Persona(nombre, dniJugador, fecha_nac);

                    //CREO el Jugador 
                    oJugador = new Jugador(oPersona, nro_jugador, oPosicion);

                    lJugadores.Add(oJugador);
                }
            }
        }

        private bool ValidarJugador(List<string> lista, string nombre)
        {
            bool resultado = false;
            foreach (String item in lista)
            {
                if (item == nombre)
                {
                    resultado = true;
                    return resultado;
                }
            }

            return resultado;
        }

        private void btnCrearEquipo_Click(object sender, EventArgs e)
        {
            
            //CREAR EL EQUIO
            if (ValidarEquipo(txtNombreEquipo.Text))
            {

            }


        }

        private bool ValidarEquipo(string text)
        {
            throw new NotImplementedException();
        }
    }
}
