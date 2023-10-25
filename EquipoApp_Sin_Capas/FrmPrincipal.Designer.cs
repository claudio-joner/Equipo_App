namespace EquipoApp
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.personaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPersonaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoJugadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarJugadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.equipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personaToolStripMenuItem,
            this.jugadorToolStripMenuItem,
            this.equipoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // personaToolStripMenuItem
            // 
            this.personaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPersonaToolStripMenuItem,
            this.listaPersonasToolStripMenuItem});
            this.personaToolStripMenuItem.Name = "personaToolStripMenuItem";
            this.personaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.personaToolStripMenuItem.Text = "Persona";
            // 
            // nuevaPersonaToolStripMenuItem
            // 
            this.nuevaPersonaToolStripMenuItem.Name = "nuevaPersonaToolStripMenuItem";
            this.nuevaPersonaToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.nuevaPersonaToolStripMenuItem.Text = "Nueva Persona";
            this.nuevaPersonaToolStripMenuItem.Click += new System.EventHandler(this.nuevaPersonaToolStripMenuItem_Click);
            // 
            // listaPersonasToolStripMenuItem
            // 
            this.listaPersonasToolStripMenuItem.Name = "listaPersonasToolStripMenuItem";
            this.listaPersonasToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.listaPersonasToolStripMenuItem.Text = "Lista Personas";
            this.listaPersonasToolStripMenuItem.Click += new System.EventHandler(this.listaPersonasToolStripMenuItem_Click);
            // 
            // jugadorToolStripMenuItem
            // 
            this.jugadorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoJugadorToolStripMenuItem,
            this.listarJugadoresToolStripMenuItem});
            this.jugadorToolStripMenuItem.Name = "jugadorToolStripMenuItem";
            this.jugadorToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.jugadorToolStripMenuItem.Text = "Jugador";
            // 
            // nuevoJugadorToolStripMenuItem
            // 
            this.nuevoJugadorToolStripMenuItem.Name = "nuevoJugadorToolStripMenuItem";
            this.nuevoJugadorToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nuevoJugadorToolStripMenuItem.Text = "Nuevo Jugador";
            this.nuevoJugadorToolStripMenuItem.Click += new System.EventHandler(this.nuevoJugadorToolStripMenuItem_Click);
            // 
            // listarJugadoresToolStripMenuItem
            // 
            this.listarJugadoresToolStripMenuItem.Name = "listarJugadoresToolStripMenuItem";
            this.listarJugadoresToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.listarJugadoresToolStripMenuItem.Text = "Listar Jugadores";
            this.listarJugadoresToolStripMenuItem.Click += new System.EventHandler(this.listarJugadoresToolStripMenuItem_Click);
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEquipoToolStripMenuItem});
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // nuevoEquipoToolStripMenuItem
            // 
            this.nuevoEquipoToolStripMenuItem.Name = "nuevoEquipoToolStripMenuItem";
            this.nuevoEquipoToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.nuevoEquipoToolStripMenuItem.Text = "Nuevo Equipo";
            this.nuevoEquipoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEquipoToolStripMenuItem_Click);
            // 
            // dgvEquipos
            // 
            this.dgvEquipos.AllowUserToAddRows = false;
            this.dgvEquipos.AllowUserToDeleteRows = false;
            this.dgvEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColEquipo,
            this.ColDt,
            this.ColAccion});
            this.dgvEquipos.Location = new System.Drawing.Point(35, 83);
            this.dgvEquipos.Name = "dgvEquipos";
            this.dgvEquipos.ReadOnly = true;
            this.dgvEquipos.Size = new System.Drawing.Size(607, 246);
            this.dgvEquipos.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(272, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(112, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Equipos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "Id";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Visible = false;
            // 
            // ColEquipo
            // 
            this.ColEquipo.FillWeight = 93.62888F;
            this.ColEquipo.HeaderText = "Equipo";
            this.ColEquipo.Name = "ColEquipo";
            this.ColEquipo.ReadOnly = true;
            // 
            // ColDt
            // 
            this.ColDt.FillWeight = 160.6859F;
            this.ColDt.HeaderText = "Director Tecnico";
            this.ColDt.Name = "ColDt";
            this.ColDt.ReadOnly = true;
            // 
            // ColAccion
            // 
            this.ColAccion.FillWeight = 45.68528F;
            this.ColAccion.HeaderText = "Editar";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            this.ColAccion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColAccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColAccion.Text = "Editar";
            this.ColAccion.UseColumnTextForButtonValue = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 391);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvEquipos);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Equipos App ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarJugadoresToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEquipoToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDt;
        private System.Windows.Forms.DataGridViewButtonColumn ColAccion;
    }
}

