namespace CapaGUI
{
    partial class frmTipoMedidaCorrectiva
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
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtTipoMedida = new System.Windows.Forms.TextBox();
            this.txtCod_TMC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(86, 84);
            this.txtDescripcion.MaxLength = 50;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(147, 20);
            this.txtDescripcion.TabIndex = 46;
            // 
            // txtTipoMedida
            // 
            this.txtTipoMedida.Location = new System.Drawing.Point(86, 46);
            this.txtTipoMedida.MaxLength = 50;
            this.txtTipoMedida.Name = "txtTipoMedida";
            this.txtTipoMedida.Size = new System.Drawing.Size(147, 20);
            this.txtTipoMedida.TabIndex = 45;
            // 
            // txtCod_TMC
            // 
            this.txtCod_TMC.Location = new System.Drawing.Point(86, 8);
            this.txtCod_TMC.MaxLength = 50;
            this.txtCod_TMC.Name = "txtCod_TMC";
            this.txtCod_TMC.Size = new System.Drawing.Size(147, 20);
            this.txtCod_TMC.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "Tipo Medida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Cod TMC";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(161, 115);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(121, 23);
            this.btnListar.TabIndex = 60;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(15, 115);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(121, 23);
            this.txtGuardar.TabIndex = 59;
            this.txtGuardar.Text = "Guardar";
            this.txtGuardar.UseVisualStyleBackColor = true;
            // 
            // frmTipoMedidaCorrectiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 161);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtTipoMedida);
            this.Controls.Add(this.txtCod_TMC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "frmTipoMedidaCorrectiva";
            this.Text = "Tipo Medida Correctiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtTipoMedida;
        private System.Windows.Forms.TextBox txtCod_TMC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button txtGuardar;
    }
}