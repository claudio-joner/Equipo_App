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
            this.listarEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
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
            this.nuevaPersonaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevaPersonaToolStripMenuItem.Text = "Nueva Persona";
            this.nuevaPersonaToolStripMenuItem.Click += new System.EventHandler(this.nuevaPersonaToolStripMenuItem_Click);
            // 
            // listaPersonasToolStripMenuItem
            // 
            this.listaPersonasToolStripMenuItem.Name = "listaPersonasToolStripMenuItem";
            this.listaPersonasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.nuevoJugadorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoJugadorToolStripMenuItem.Text = "Nuevo Jugador";
            this.nuevoJugadorToolStripMenuItem.Click += new System.EventHandler(this.nuevoJugadorToolStripMenuItem_Click);
            // 
            // listarJugadoresToolStripMenuItem
            // 
            this.listarJugadoresToolStripMenuItem.Name = "listarJugadoresToolStripMenuItem";
            this.listarJugadoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarJugadoresToolStripMenuItem.Text = "Listar Jugadores";
            this.listarJugadoresToolStripMenuItem.Click += new System.EventHandler(this.listarJugadoresToolStripMenuItem_Click);
            // 
            // equipoToolStripMenuItem
            // 
            this.equipoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoEquipoToolStripMenuItem,
            this.listarEquiposToolStripMenuItem});
            this.equipoToolStripMenuItem.Name = "equipoToolStripMenuItem";
            this.equipoToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.equipoToolStripMenuItem.Text = "Equipo";
            // 
            // nuevoEquipoToolStripMenuItem
            // 
            this.nuevoEquipoToolStripMenuItem.Name = "nuevoEquipoToolStripMenuItem";
            this.nuevoEquipoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoEquipoToolStripMenuItem.Text = "Nuevo Equipo";
            this.nuevoEquipoToolStripMenuItem.Click += new System.EventHandler(this.nuevoEquipoToolStripMenuItem_Click);
            // 
            // listarEquiposToolStripMenuItem
            // 
            this.listarEquiposToolStripMenuItem.Name = "listarEquiposToolStripMenuItem";
            this.listarEquiposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listarEquiposToolStripMenuItem.Text = "Listar Equipos";
            this.listarEquiposToolStripMenuItem.Click += new System.EventHandler(this.listarEquiposToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(37, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 273);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(331, 40);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(112, 31);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Equipos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 391);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Equipos App ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem personaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaPersonaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem equipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoJugadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarJugadoresToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTitulo;
    }
}

