using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipoApp
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

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
