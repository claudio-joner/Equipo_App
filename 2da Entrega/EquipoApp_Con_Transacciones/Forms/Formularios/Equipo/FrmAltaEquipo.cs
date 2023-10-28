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
using EquipoApp.Datos;
using System.Net.Configuration;

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
        Helper gestor;

        //Atributos Listas
        List<string> lNombres;
        List<Jugador> lJugadores;
        public FrmAltaEquipo()
        {
            InitializeComponent();
            connection = new SqlConnection(Properties.Resources.cadenaConexionPcCas);
            cmd = new SqlCommand();
            tablaJugador = new DataTable();
            lNombres = new List<string>();
            lJugadores = new List<Jugador>();
            gestor = new Helper();
        }

        private void FrmNuevoEquipo_Load(object sender, EventArgs e)
        {
            
            CargarComboDt();
            CargarDgv();
            Limpiar();
        }

        private void CargarDgv()
        {
            connection.Open();
            tablaJugador.Clear();
            cmd.Connection = connection;
            cmd.CommandText = "SP_LISTAR_JUGADORES";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            SqlDataReader reader = cmd.ExecuteReader();

            tablaJugador.Load(reader);

            foreach (DataRow item in tablaJugador.Rows)
            {
                object[] fila =  item.ItemArray;

                dgvJugadores.Rows.Add(fila);
            }
            connection.Close();
        }

        

        private void CargarComboDt()
        {
            //DataTable tablaDt = new DataTable();
           
            //cmd.Connection = connection;
            //cmd.CommandText = "SP_LISTAR_PERSONAS";
            //cmd.CommandType = CommandType.StoredProcedure;

            //tablaDt.Load(cmd.ExecuteReader());
            
            cboDt.DataSource = gestor.CargarCombos("SP_LISTAR_PERSONAS");
            
            cboDt.DisplayMember = "NOMBRE";
            cboDt.ValueMember = "ID";
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
            cboDt.SelectedIndex = -1;
            lNombres.Clear();
            lstConvocados.Items.Clear();
            dgvJugadores.Rows.Clear();
            cantJugadores = 0;
            lblCantidadJugadores.Text = "Cantidad de convocados: " + cantJugadores.ToString();

            gestor.AbrirConexion();
            CargarDgv();
            gestor.CerrarConexion();
        }

        int cantJugadores = 0;
        private void dgvJugadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dgvJugadores.CurrentCell.ColumnIndex == dgvJugadores.ColumnCount - 1)
            {

                string nombre = dgvJugadores.Rows[dgvJugadores.CurrentRow.Index].Cells[0].Value.ToString();
                string numero = dgvJugadores.Rows[dgvJugadores.CurrentRow.Index].Cells[1].Value.ToString();
                string posicion = dgvJugadores.Rows[dgvJugadores.CurrentRow.Index].Cells[2].Value.ToString();
                string jugador = "Nombre: " + nombre + " |Numero: " + numero+" |Posicion: " + posicion;

                

                //Eliminar el jugador del dgv cuando selecciono una persona del cboDt
                string nombreDt = cboDt.DisplayMember.ToString();



                if (ValidarJugador(lNombres,nombre))
                {
                    MessageBox.Show("El jugador esta agregado.");
                    return ;
                }
                else
                {
                    if (cantJugadores > 10)
                    {
                        MessageBox.Show("El equipo esta completo.");
                        return;
                    }
                    else
                    {
                        cantJugadores++;
                        lblCantidadJugadores.Text = "Cantidad de convocados: " + cantJugadores.ToString();

                        if (cantJugadores <= 10)
                        {
                            lblCantidadJugadores.ForeColor = Color.Red;

                        }
                        else
                        {
                            lblCantidadJugadores.ForeColor = Color.Green;
                        }

                        lNombres.Add(nombre);
                        lstConvocados.Items.Add(jugador);
                        dgvJugadores.Rows.RemoveAt(dgvJugadores.CurrentRow.Index);

                        int nro_jugador = Convert.ToInt32(numero);
                        //EJECUTAR SP_PARAM_JUGADOR PARA CREARLO
                        connection.Open();
                        cmd.Connection = connection;
                        cmd.CommandText = "SP_PARAM_JUGADOR";
                        cmd.CommandType = CommandType.StoredProcedure;
                        //Limpio los parametros de cmd 
                        cmd.Parameters.Clear();
                        //agrego parametros de entrada
                        cmd.Parameters.AddWithValue("@nomJugador", nombre);
                        cmd.Parameters.AddWithValue("@nomPosicion", posicion);
                        cmd.Parameters.AddWithValue("@nro", nro_jugador);
                        //agrego parametros de salida 
                        SqlParameter dni = new SqlParameter("@dni", SqlDbType.Int);
                        dni.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(dni);
                        SqlParameter fecha = new SqlParameter("@fecha_nac", SqlDbType.DateTime);
                        fecha.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(fecha);
                        SqlParameter id = new SqlParameter("@id", SqlDbType.Int);
                        id.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(id);

                        cmd.ExecuteReader();

                        //Obtendo los parametros de salida y se convierte al tipo correspondiente
                        DateTime fecha_nac = Convert.ToDateTime(fecha.Value);
                        int dniJugador = Convert.ToInt32(dni.Value);
                        int idJugador = Convert.ToInt32(id.Value);

                        connection.Close();

                        //CREO la posicion del jugador
                        oPosicion = new Posicion(posicion);

                        //CREO la persona del jugador
                        oPersona = new Persona(nombre, dniJugador, fecha_nac);

                        //CREO el Jugador 
                        oJugador = new Jugador(oPersona, nro_jugador, oPosicion, idJugador);

                        lJugadores.Add(oJugador);
                    }
                    
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
            SqlTransaction t = null;
            try
            {
                //Obtengo Datos para crear el equipo
                string nombreEquipo = txtNombreEquipo.Text;
                string nombreDt = cboDt.Text;//ver
                if (String.IsNullOrEmpty(txtNombreEquipo.Text))
                {
                    MessageBox.Show("Escriba el nombre del equipo");
                }

                if (cboDt.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un Dt");
                }

                if (lstConvocados.Items.Count == 0)
                {
                    MessageBox.Show("Agregue 11 jugadores");
                }

                

                //CREAR EL EQUIO
                if (ValidarEquipo(nombreEquipo, nombreDt) && !String.IsNullOrEmpty(txtNombreEquipo.Text) && lstConvocados.Items.Count != 0)
                {
                    Equipo equipo = new Equipo();
                    connection.Open();
                    t = connection.BeginTransaction();
                    cmd.Connection = connection;
                    cmd.Transaction = t;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "SP_INSERTAR_EQUIPO";
                    cmd.Parameters.Clear();
                    //Agrego parametros de entrada
                    cmd.Parameters.AddWithValue("@nomEquipo", nombreEquipo);
                    cmd.Parameters.AddWithValue("@nomDt", nombreDt);

                    //agrego parametros de salida 
                    SqlParameter idEquipo = new SqlParameter("@id", SqlDbType.Int);
                    idEquipo.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(idEquipo);

                    cmd.ExecuteNonQuery();

                    int idEquiDet = Convert.ToInt32(idEquipo.Value);
                    cmd.Parameters.Clear();

                    //Vamos a EJECUTAR EL SP PARA DETALLES  
                    cmd.CommandText = "SP_INSERTAR_DETALLES";

                    foreach (Jugador j in lJugadores)
                    {
                        cmd.Parameters.AddWithValue("@idEquipo", idEquiDet);
                        cmd.Parameters.AddWithValue("@idJugador", j.Id);
                        //equipo.AgregarJugado(j);
                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }


                    t.Commit();
                    MessageBox.Show("Equipo agregado con exito ");
                    CargarDgv();
                    this.Hide();
                }
                else
                {
                    //MessageBox.Show("El equipo existe");
                    t.Rollback();
                    return;
                }
            }
            catch (Exception)
            {
                t.Rollback();
                throw;
            }
            finally
            {
                if (connection != null && connection.State == ConnectionState.Open)
                    gestor.CerrarConexion();
            }



        }

        private bool ValidarEquipo(string text1, string text2)
        {
            if (!string.IsNullOrEmpty(text2))
            {
                connection.Open();
                cmd.Connection = connection;
                cmd.CommandText = "SP_CONSULTAR_EQUIPO";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@nomEquipo", text1);
                cmd.Parameters.AddWithValue("@nomDt", text2);

                //PArametro de retorno sin daclarar
                SqlParameter parametroRetorno = new SqlParameter("@ReturnValue", SqlDbType.Int);
                parametroRetorno.Direction = ParameterDirection.Output;
                parametroRetorno.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(parametroRetorno);
                cmd.ExecuteNonQuery();

                connection.Close();
                bool resultado;
                int valor = Convert.ToInt32(parametroRetorno.Value);
                if (valor == 0)
                {
                    resultado = true;
                    return resultado;
                }
                else
                {
                    resultado = false;
                    MessageBox.Show("Equipo existente o Dt seleccionado.");
                    MessageBox.Show("Cambie los datos.");
                    return resultado;
                }
                
            }
            else
            {
                return false;
            }

        }

        private void cboDt_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreDt = cboDt.Text;

            foreach (DataGridViewRow fila in dgvJugadores.Rows)
            {
                if (fila.Cells["ColNombre"].Value.ToString() == nombreDt)
                {
                    dgvJugadores.Rows.Remove(fila);
                    dgvJugadores.Refresh();
                }
                
            }

            
        }
    }
}
