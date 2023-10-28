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
using EquipoApp.Datos;

namespace EquipoApp
{
    public partial class FrmAltaPersona : Form
    {
        Persona nuevaPersona;
        SqlConnection conexion;
        SqlCommand comando;
        SqlDataReader lector;
        
        public FrmAltaPersona()
        {
            InitializeComponent();
            nuevaPersona = new Persona();
            //conexion = new SqlConnection(Properties.Resources.cadenaConexionPcCasa);
            conexion = new SqlConnection(Properties.Resources.cadenaConexionPcCas);
            comando = new SqlCommand();

        }

        private void FrmAltaPersona_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool Validar()
        {
            if (String.IsNullOrEmpty(txtNombrePers.Text)|| String.IsNullOrEmpty(txtApellidoPers.Text)
                || String.IsNullOrEmpty(txtDni.Text))
            {
                MessageBox.Show("Faltan Campos de completar.","Atención");
                return false;
            }
            if (!txtNombrePers.Text.All(char.IsLetter))
            {
                MessageBox.Show("Para el nombre es sólo válido letras.", "Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return false;
            }
            if (!txtApellidoPers.Text.All(char.IsLetter))
            {
                MessageBox.Show("Para el apellido es sólo válido letras.", "Atención",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(!txtDni.Text.All(char.IsNumber))
            {
                MessageBox.Show("Para el dni es sólo válido números.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpFechaNac.Value > DateTime.Now.AddYears(-15))
            {
                MessageBox.Show("El jugardor debe tener 15 años o mas para ser parte del equipo.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (ConsultarPersona())
            {
                MessageBox.Show("La persona o dni ya registrados.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private bool ConsultarPersona()
        {
            conexion.Open();
            //Comando
            comando.Connection = conexion;
            comando.CommandText = "SP_CONSULTAR_PERSONAS";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nombre", txtNombrePers.Text + " " + txtApellidoPers.Text);
            comando.Parameters.AddWithValue("@dni", Convert.ToInt32(txtDni.Text));
            //Saber la cantidad de lineas afectadas por el sp
            lector = comando.ExecuteReader();
            if (!lector.HasRows)
            {
                conexion.Close();
                return false;
            }
            else
            {
                conexion.Close();
                return true;
            }   
           
        }

        private void Limpiar()
        {
            txtNombrePers.Text = string.Empty;
            txtApellidoPers.Text = string.Empty;
            txtDni.Text = string.Empty;
            dtpFechaNac.Value = DateTime.Now;
        }

        private void btnCancelarNuevaPers_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptarNuevaPers_Click(object sender, EventArgs e)
        {
            SqlTransaction transaccion = null;
            try
            {
                if (Validar())
                {
                    conexion.Open();
                    transaccion = conexion.BeginTransaction();//Indico la transaccion a que conexion empieza
                    //Comando
                    comando.Connection = conexion;
                    comando.Transaction = transaccion; //Indico que comando tiene transaccion
                    comando.CommandText = "SP_INSERTAR_PERSONAS";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@nombre",txtNombrePers.Text + " " + txtApellidoPers.Text);
                    comando.Parameters.AddWithValue("@dni",Convert.ToInt32(txtDni.Text));
                    comando.Parameters.AddWithValue("@fecha_nac",dtpFechaNac.Value);
                    int nroLineasAfectada = (int)comando.ExecuteNonQuery();

                    //gestor.CerrarConexion();
                    MessageBox.Show("Se agrego con exito.");

                    transaccion.Commit(); //Hago el commit
                    this.Close();
                    
                }
                else
                {
                    MessageBox.Show("No Validado");
                    transaccion.Rollback();

                }
            }
            catch (Exception)
            {
                if(transaccion == null)
                    transaccion.Rollback();
            }
            finally
            {
                if (conexion != null && conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        
    }
}
