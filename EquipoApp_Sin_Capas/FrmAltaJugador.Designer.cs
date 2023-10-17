namespace EquipoApp
{
    partial class FrmAltaJugador
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
            this.btnAceptarNuevoJug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblPersona = new System.Windows.Forms.Label();
            this.lblNroCamiseta = new System.Windows.Forms.Label();
            this.txtNroCamiseta = new System.Windows.Forms.TextBox();
            this.cboPersonas = new System.Windows.Forms.ComboBox();
            this.cboPosicion = new System.Windows.Forms.ComboBox();
            this.btnCancelarNuevoJug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAceptarNuevoJug
            // 
            this.btnAceptarNuevoJug.Location = new System.Drawing.Point(41, 219);
            this.btnAceptarNuevoJug.Name = "btnAceptarNuevoJug";
            this.btnAceptarNuevoJug.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevoJug.TabIndex = 3;
            this.btnAceptarNuevoJug.Text = "&Aceptar";
            this.btnAceptarNuevoJug.UseVisualStyleBackColor = true;
            this.btnAceptarNuevoJug.Click += new System.EventHandler(this.btnAceptarNuevoJug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Posición:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(57, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(198, 31);
            this.lblTitulo.TabIndex = 25;
            this.lblTitulo.Text = "Nuevo Jugador";
            // 
            // lblPersona
            // 
            this.lblPersona.AutoSize = true;
            this.lblPersona.Location = new System.Drawing.Point(70, 78);
            this.lblPersona.Name = "lblPersona";
            this.lblPersona.Size = new System.Drawing.Size(52, 13);
            this.lblPersona.TabIndex = 24;
            this.lblPersona.Text = "Persona: ";
            this.lblPersona.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblNroCamiseta
            // 
            this.lblNroCamiseta.AutoSize = true;
            this.lblNroCamiseta.Location = new System.Drawing.Point(43, 114);
            this.lblNroCamiseta.Name = "lblNroCamiseta";
            this.lblNroCamiseta.Size = new System.Drawing.Size(73, 13);
            this.lblNroCamiseta.TabIndex = 27;
            this.lblNroCamiseta.Text = "Nro Camiseta:";
            this.lblNroCamiseta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNroCamiseta
            // 
            this.txtNroCamiseta.Location = new System.Drawing.Point(127, 114);
            this.txtNroCamiseta.Name = "txtNroCamiseta";
            this.txtNroCamiseta.Size = new System.Drawing.Size(128, 20);
            this.txtNroCamiseta.TabIndex = 1;
            // 
            // cboPersonas
            // 
            this.cboPersonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonas.FormattingEnabled = true;
            this.cboPersonas.Location = new System.Drawing.Point(127, 75);
            this.cboPersonas.Name = "cboPersonas";
            this.cboPersonas.Size = new System.Drawing.Size(128, 21);
            this.cboPersonas.TabIndex = 0;
            // 
            // cboPosicion
            // 
            this.cboPosicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosicion.FormattingEnabled = true;
            this.cboPosicion.Location = new System.Drawing.Point(127, 151);
            this.cboPosicion.Name = "cboPosicion";
            this.cboPosicion.Size = new System.Drawing.Size(128, 21);
            this.cboPosicion.TabIndex = 2;
            // 
            // btnCancelarNuevoJug
            // 
            this.btnCancelarNuevoJug.Location = new System.Drawing.Point(210, 219);
            this.btnCancelarNuevoJug.Name = "btnCancelarNuevoJug";
            this.btnCancelarNuevoJug.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNuevoJug.TabIndex = 4;
            this.btnCancelarNuevoJug.Text = "Can&celar";
            this.btnCancelarNuevoJug.UseVisualStyleBackColor = true;
            this.btnCancelarNuevoJug.Click += new System.EventHandler(this.btnCancelarNuevoJuegador_Click);
            // 
            // FrmAltaJugador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 274);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelarNuevoJug);
            this.Controls.Add(this.cboPosicion);
            this.Controls.Add(this.cboPersonas);
            this.Controls.Add(this.btnAceptarNuevoJug);
            this.Controls.Add(this.txtNroCamiseta);
            this.Controls.Add(this.lblNroCamiseta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPersona);
            this.Name = "FrmAltaJugador";
            this.Text = "Nuevo Jugador";
            this.Load += new System.EventHandler(this.FrmAltaJugador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAceptarNuevoJug;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPersona;
        private System.Windows.Forms.Label lblNroCamiseta;
        private System.Windows.Forms.TextBox txtNroCamiseta;
        private System.Windows.Forms.ComboBox cboPersonas;
        private System.Windows.Forms.ComboBox cboPosicion;
        private System.Windows.Forms.Button btnCancelarNuevoJug;
    }
}