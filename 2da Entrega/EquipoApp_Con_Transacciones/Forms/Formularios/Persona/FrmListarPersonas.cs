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
    public partial class FrmListarPersonas : Form
    {
        
        List<Persona> lPersonas;
        Helper gestor;
        public FrmListarPersonas()
        {
            InitializeComponent();
            gestor = new Helper();
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
           DataTable dt = gestor.CargarCombos("SP_LISTAR_PERSONAS");
            

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

    }
}
