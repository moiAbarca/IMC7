namespace CapaGUI
{
    partial class frmCargo
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
            this.txtNombre_TipoCargo = new System.Windows.Forms.TextBox();
            this.txtCod_Tipo_RRHH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre_TipoCargo
            // 
            this.txtNombre_TipoCargo.Location = new System.Drawing.Point(113, 48);
            this.txtNombre_TipoCargo.MaxLength = 50;
            this.txtNombre_TipoCargo.Name = "txtNombre_TipoCargo";
            this.txtNombre_TipoCargo.Size = new System.Drawing.Size(242, 20);
            this.txtNombre_TipoCargo.TabIndex = 19;
            // 
            // txtCod_Tipo_RRHH
            // 
            this.txtCod_Tipo_RRHH.Location = new System.Drawing.Point(113, 6);
            this.txtCod_Tipo_RRHH.MaxLength = 50;
            this.txtCod_Tipo_RRHH.Name = "txtCod_Tipo_RRHH";
            this.txtCod_Tipo_RRHH.Size = new System.Drawing.Size(242, 20);
            this.txtCod_Tipo_RRHH.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombre Tipo Cargo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Código ";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(226, 88);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(104, 88);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 20;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // frmCargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 128);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombre_TipoCargo);
            this.Controls.Add(this.txtCod_Tipo_RRHH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCargo";
            this.Text = "frmCargo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre_TipoCargo;
        private System.Windows.Forms.TextBox txtCod_Tipo_RRHH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnGuardar;
    }
}