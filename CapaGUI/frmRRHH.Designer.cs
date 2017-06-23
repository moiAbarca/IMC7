namespace CapaGUI
{
    partial class frmRRHH
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
            this.dtFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtListar = new System.Windows.Forms.Button();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtRutRRHH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCodTipoRRHH = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // dtFechaNacimiento
            // 
            this.dtFechaNacimiento.Location = new System.Drawing.Point(112, 132);
            this.dtFechaNacimiento.Name = "dtFechaNacimiento";
            this.dtFechaNacimiento.Size = new System.Drawing.Size(240, 20);
            this.dtFechaNacimiento.TabIndex = 42;
            // 
            // txtListar
            // 
            this.txtListar.Location = new System.Drawing.Point(233, 222);
            this.txtListar.Name = "txtListar";
            this.txtListar.Size = new System.Drawing.Size(75, 23);
            this.txtListar.TabIndex = 41;
            this.txtListar.Text = "Listar";
            this.txtListar.UseVisualStyleBackColor = true;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(111, 222);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(75, 23);
            this.txtGuardar.TabIndex = 40;
            this.txtGuardar.Text = "Guardar";
            this.txtGuardar.UseVisualStyleBackColor = true;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(111, 92);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(242, 20);
            this.txtApellido.TabIndex = 39;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(111, 52);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(242, 20);
            this.txtNombre.TabIndex = 38;
            // 
            // txtRutRRHH
            // 
            this.txtRutRRHH.Location = new System.Drawing.Point(111, 12);
            this.txtRutRRHH.MaxLength = 50;
            this.txtRutRRHH.Name = "txtRutRRHH";
            this.txtRutRRHH.Size = new System.Drawing.Size(242, 20);
            this.txtRutRRHH.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "Fecha Nacimiento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Rut";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Cod Tipo RRHH";
            // 
            // cmbCodTipoRRHH
            // 
            this.cmbCodTipoRRHH.FormattingEnabled = true;
            this.cmbCodTipoRRHH.Location = new System.Drawing.Point(112, 177);
            this.cmbCodTipoRRHH.Name = "cmbCodTipoRRHH";
            this.cmbCodTipoRRHH.Size = new System.Drawing.Size(240, 21);
            this.cmbCodTipoRRHH.TabIndex = 44;
            // 
            // frmRRHH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 269);
            this.Controls.Add(this.cmbCodTipoRRHH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtFechaNacimiento);
            this.Controls.Add(this.txtListar);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtRutRRHH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRRHH";
            this.Text = "frmRRHH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaNacimiento;
        private System.Windows.Forms.Button txtListar;
        private System.Windows.Forms.Button txtGuardar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtRutRRHH;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCodTipoRRHH;
    }
}