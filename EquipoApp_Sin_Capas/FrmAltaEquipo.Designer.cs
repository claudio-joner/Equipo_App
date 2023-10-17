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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDt = new System.Windows.Forms.Label();
            this.lblJugadores = new System.Windows.Forms.Label();
            this.cboDt = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCrearEquipo = new System.Windows.Forms.Button();
            this.btnCancelarEquipo = new System.Windows.Forms.Button();
            this.lblCantidadJugadores = new System.Windows.Forms.Label();
            this.lblFaltaDt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(258, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Nuevo Equipo";
            // 
            // lblDt
            // 
            this.lblDt.AutoSize = true;
            this.lblDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt.Location = new System.Drawing.Point(517, 46);
            this.lblDt.Name = "lblDt";
            this.lblDt.Size = new System.Drawing.Size(128, 20);
            this.lblDt.TabIndex = 1;
            this.lblDt.Text = "Director Técnico:";
            // 
            // lblJugadores
            // 
            this.lblJugadores.AutoSize = true;
            this.lblJugadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJugadores.Location = new System.Drawing.Point(139, 118);
            this.lblJugadores.Name = "lblJugadores";
            this.lblJugadores.Size = new System.Drawing.Size(88, 20);
            this.lblJugadores.TabIndex = 3;
            this.lblJugadores.Text = "Jugadores:";
            // 
            // cboDt
            // 
            this.cboDt.FormattingEnabled = true;
            this.cboDt.Location = new System.Drawing.Point(471, 74);
            this.cboDt.Name = "cboDt";
            this.cboDt.Size = new System.Drawing.Size(214, 21);
            this.cboDt.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 154);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(320, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnCrearEquipo
            // 
            this.btnCrearEquipo.Location = new System.Drawing.Point(111, 413);
            this.btnCrearEquipo.Name = "btnCrearEquipo";
            this.btnCrearEquipo.Size = new System.Drawing.Size(119, 23);
            this.btnCrearEquipo.TabIndex = 2;
            this.btnCrearEquipo.Text = "&Crear Equipo";
            this.btnCrearEquipo.UseVisualStyleBackColor = true;
            // 
            // btnCancelarEquipo
            // 
            this.btnCancelarEquipo.Location = new System.Drawing.Point(512, 413);
            this.btnCancelarEquipo.Name = "btnCancelarEquipo";
            this.btnCancelarEquipo.Size = new System.Drawing.Size(106, 23);
            this.btnCancelarEquipo.TabIndex = 3;
            this.btnCancelarEquipo.Text = "Cancel&ar Creación";
            this.btnCancelarEquipo.UseVisualStyleBackColor = true;
            this.btnCancelarEquipo.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblCantidadJugadores
            // 
            this.lblCantidadJugadores.AutoSize = true;
            this.lblCantidadJugadores.Location = new System.Drawing.Point(108, 318);
            this.lblCantidadJugadores.Name = "lblCantidadJugadores";
            this.lblCantidadJugadores.Size = new System.Drawing.Size(119, 13);
            this.lblCantidadJugadores.TabIndex = 8;
            this.lblCantidadJugadores.Text = "Cantidad de Jugadores:";
            // 
            // lblFaltaDt
            // 
            this.lblFaltaDt.AutoSize = true;
            this.lblFaltaDt.Location = new System.Drawing.Point(108, 344);
            this.lblFaltaDt.Name = "lblFaltaDt";
            this.lblFaltaDt.Size = new System.Drawing.Size(61, 13);
            this.lblFaltaDt.TabIndex = 9;
            this.lblFaltaDt.Text = "Mensaje Dt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mensaje Jugadores";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(130, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(148, 20);
            this.lblNombre.TabIndex = 11;
            this.lblNombre.Text = "Nombre del Equipo:";
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(84, 74);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(214, 20);
            this.txtNombreEquipo.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(512, 344);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(120, 23);
            this.btnLimpiar.TabIndex = 12;
            this.btnLimpiar.Text = "&Limpiar Lista";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(429, 154);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(296, 147);
            this.listBox1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Listado de convocados: ";
            // 
            // FrmAltaEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 471);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.txtNombreEquipo);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFaltaDt);
            this.Controls.Add(this.lblCantidadJugadores);
            this.Controls.Add(this.btnCancelarEquipo);
            this.Controls.Add(this.btnCrearEquipo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cboDt);
            this.Controls.Add(this.lblJugadores);
            this.Controls.Add(this.lblDt);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmAltaEquipo";
            this.Text = "Nuevo Equipo";
            this.Load += new System.EventHandler(this.FrmNuevoEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDt;
        private System.Windows.Forms.Label lblJugadores;
        private System.Windows.Forms.ComboBox cboDt;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCrearEquipo;
        private System.Windows.Forms.Button btnCancelarEquipo;
        private System.Windows.Forms.Label lblCantidadJugadores;
        private System.Windows.Forms.Label lblFaltaDt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
    }
}