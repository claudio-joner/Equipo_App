namespace EquipoApp
{
    partial class FrmAltaPersona
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombrePers = new System.Windows.Forms.TextBox();
            this.txtApellidoPers = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.btnCancelarNuevaPers = new System.Windows.Forms.Button();
            this.btnAceptarNuevaPers = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(77, 78);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(60, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(201, 31);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Nueva Persona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "DNI:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha De Nacimiento: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtNombrePers
            // 
            this.txtNombrePers.Location = new System.Drawing.Point(134, 75);
            this.txtNombrePers.Name = "txtNombrePers";
            this.txtNombrePers.Size = new System.Drawing.Size(100, 20);
            this.txtNombrePers.TabIndex = 0;
            // 
            // txtApellidoPers
            // 
            this.txtApellidoPers.Location = new System.Drawing.Point(134, 114);
            this.txtApellidoPers.Name = "txtApellidoPers";
            this.txtApellidoPers.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoPers.TabIndex = 1;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(133, 148);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 2;
            // 
            // dtpFechaNac
            // 
            this.dtpFechaNac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNac.Location = new System.Drawing.Point(133, 186);
            this.dtpFechaNac.Name = "dtpFechaNac";
            this.dtpFechaNac.Size = new System.Drawing.Size(101, 20);
            this.dtpFechaNac.TabIndex = 3;
            // 
            // btnCancelarNuevaPers
            // 
            this.btnCancelarNuevaPers.Location = new System.Drawing.Point(175, 238);
            this.btnCancelarNuevaPers.Name = "btnCancelarNuevaPers";
            this.btnCancelarNuevaPers.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarNuevaPers.TabIndex = 5;
            this.btnCancelarNuevaPers.Text = "&Cancelar";
            this.btnCancelarNuevaPers.UseVisualStyleBackColor = true;
            this.btnCancelarNuevaPers.Click += new System.EventHandler(this.btnCancelarNuevaPers_Click);
            // 
            // btnAceptarNuevaPers
            // 
            this.btnAceptarNuevaPers.Location = new System.Drawing.Point(52, 238);
            this.btnAceptarNuevaPers.Name = "btnAceptarNuevaPers";
            this.btnAceptarNuevaPers.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarNuevaPers.TabIndex = 4;
            this.btnAceptarNuevaPers.Text = "&Aceptar";
            this.btnAceptarNuevaPers.UseVisualStyleBackColor = true;
            this.btnAceptarNuevaPers.Click += new System.EventHandler(this.btnAceptarNuevaPers_Click);
            // 
            // FrmAltaPersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 294);
            this.ControlBox = false;
            this.Controls.Add(this.btnAceptarNuevaPers);
            this.Controls.Add(this.btnCancelarNuevaPers);
            this.Controls.Add(this.dtpFechaNac);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.txtApellidoPers);
            this.Controls.Add(this.txtNombrePers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAltaPersona";
            this.Text = "Alta Persona";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmAltaPersona_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombrePers;
        private System.Windows.Forms.TextBox txtApellidoPers;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.DateTimePicker dtpFechaNac;
        private System.Windows.Forms.Button btnCancelarNuevaPers;
        private System.Windows.Forms.Button btnAceptarNuevaPers;
    }
}