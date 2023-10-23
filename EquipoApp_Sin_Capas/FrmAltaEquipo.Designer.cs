namespace EquipoApp
{
    partial class FrmAltaEquipo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDt = new System.Windows.Forms.Label();
            this.lblJugadores = new System.Windows.Forms.Label();
            this.cboDt = new System.Windows.Forms.ComboBox();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.ColNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNroCamiseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColAccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnCrearEquipo = new System.Windows.Forms.Button();
            this.btnCancelarEquipo = new System.Windows.Forms.Button();
            this.lblCantidadJugadores = new System.Windows.Forms.Label();
            this.lblFaltaDt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lstConvocados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(374, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nuevo Equipo";
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt.Location = new System.Drawing.Point(586, 50);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(128, 20);
            this.lblDt.TabIndex = 1;
            this.lblDt.Text = "Director Técnico:";
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadores.Location = new System.Drawing.Point(410, 117);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(88, 20);
            this.lblJugadores.TabIndex = 3;
            this.lblJugadores.Text = "Jugadores:";
            // 
            // cboDt
            // 
            this.cboDt.FormattingEnabled = true;
            this.cboDt.Location = new System.Drawing.Point(540, 78);
            this.cboDt.Name = "cboDt";
            this.cboDt.Size = new System.Drawing.Size(214, 21);
            this.cboDt.TabIndex = 1;
            // 
            // dgvJugadores
            // 
            this.dgvJugadores.AllowUserToAddRows = false;
            this.dgvJugadores.AllowUserToDeleteRows = false;
            this.dgvJugadores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvJugadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvJugadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJugadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNombre,
            this.ColNroCamiseta,
            this.ColPosicion,
            this.ColAccion});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvJugadores.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvJugadores.Location = new System.Drawing.Point(20, 151);
            this.dgvJugadores.Name = "dgvJugadores";
            this.dgvJugadores.ReadOnly = true;
            this.dgvJugadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvJugadores.Size = new System.Drawing.Size(780, 150);
            this.dgvJugadores.TabIndex = 5;
            this.dgvJugadores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvJugadores_CellContentClick);
            // 
            // ColNombre
            // 
            this.ColNombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNombre.HeaderText = "Jugador";
            this.ColNombre.Name = "ColNombre";
            this.ColNombre.ReadOnly = true;
            // 
            // ColNroCamiseta
            // 
            this.ColNroCamiseta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNroCamiseta.HeaderText = "Nro de Camiseta";
            this.ColNroCamiseta.Name = "ColNroCamiseta";
            this.ColNroCamiseta.ReadOnly = true;
            // 
            // ColPosicion
            // 
            this.ColPosicion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColPosicion.HeaderText = "Posicion";
            this.ColPosicion.Name = "ColPosicion";
            this.ColPosicion.ReadOnly = true;
            // 
            // ColAccion
            // 
            this.ColAccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColAccion.HeaderText = "Accion";
            this.ColAccion.Name = "ColAccion";
            this.ColAccion.ReadOnly = true;
            this.ColAccion.Text = "Agregar";
            this.ColAccion.ToolTipText = "Agregar";
            this.ColAccion.UseColumnTextForButtonValue = true;
            // 
            // btnCrearEquipo
            // 
            this.btnCrearEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCrearEquipo.Location = new System.Drawing.Point(72, 625);
            this.btnCrearEquipo.Name = "btnCrearEquipo";
            this.btnCrearEquipo.Size = new System.Drawing.Size(120, 34);
            this.btnCrearEquipo.TabIndex = 2;
            this.btnCrearEquipo.Text = "&Crear Equipo";
            this.btnCrearEquipo.UseVisualStyleBackColor = true;
            this.btnCrearEquipo.Click += new System.EventHandler(this.btnCrearEquipo_Click);
            // 
            // btnCancelarEquipo
            // 
            this.btnCancelarEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelarEquipo.Location = new System.Drawing.Point(621, 626);
            this.btnCancelarEquipo.Name = "btnCancelarEquipo";
            this.btnCancelarEquipo.Size = new System.Drawing.Size(133, 34);
            this.btnCancelarEquipo.TabIndex = 3;
            this.btnCancelarEquipo.Text = "Cancel&ar Creación";
            this.btnCancelarEquipo.UseVisualStyleBackColor = true;
            this.btnCancelarEquipo.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.AutoSize = true;
            this.lblCantidadJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCantidadJugadores.Location = new System.Drawing.Point(362, 574);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(159, 17);
            this.lblCantidadJugadores.TabIndex = 8;
            this.lblCantidadJugadores.Text = "Cantidad de Jugadores:";
            // 
            // lblFaltaDt
            // 
            this.lblFaltaDt.AutoSize = true;
            this.lblFaltaDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFaltaDt.Location = new System.Drawing.Point(17, 342);
            this.lblFaltaDt.Name = "lblFaltaDt";
            this.lblFaltaDt.Size = new System.Drawing.Size(79, 17);
            this.lblFaltaDt.TabIndex = 9;
            this.lblFaltaDt.Text = "Mensaje Dt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(17, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mensaje Jugadores";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(175, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(148, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre del Equipo:";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(142, 79);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(214, 20);
            this.txtNombreEquipo.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnLimpiar.Location = new System.Drawing.Point(365, 625);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 36);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "&Limpiar Lista";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lstConvocados
            // 
            this.lstConvocados.FormattingEnabled = true;
            this.lstConvocados.Location = new System.Drawing.Point(20, 408);
            this.lstConvocados.Name = "lstConvocados";
            this.lstConvocados.Size = new System.Drawing.Size(777, 147);
            this.lstConvocados.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(361, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Listado de convocados: ";
            // 
            // FrmAltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 671);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstConvocados);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFaltaDt);
            this.Controls.Add(this.lblCantidadJugadores);
            this.Controls.Add(this.btnCancelarEquipo);
            this.Controls.Add(this.btnCrearEquipo);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.cboDt);
            this.Controls.Add(this.lblJugadores);
            this.Controls.Add(this.lblDt);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAltaEquipo";
            this.Text = "Nuevo Equipo";
            this.Load += new System.EventHandler(this.FrmNuevoEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.Label lblJugadores;
        private System.Windows.Forms.ComboBox cboDt;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.Button btnCrearEquipo;
        private System.Windows.Forms.Button btnCancelarEquipo;
        private System.Windows.Forms.Label lblCantidadJugadores;
        private System.Windows.Forms.Label lblFaltaDt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox lstConvocados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNroCamiseta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPosicion;
        private System.Windows.Forms.DataGridViewButtonColumn ColAccion;
    }
}