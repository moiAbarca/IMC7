namespace CapaGUI
{
    partial class frmPeriodo
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
            this.txtSemestre = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtCod_Periodo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Año = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSemestre
            // 
            this.txtSemestre.Location = new System.Drawing.Point(104, 87);
            this.txtSemestre.MaxLength = 50;
            this.txtSemestre.Name = "txtSemestre";
            this.txtSemestre.Size = new System.Drawing.Size(163, 20);
            this.txtSemestre.TabIndex = 22;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(104, 48);
            this.txtAño.MaxLength = 50;
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(163, 20);
            this.txtAño.TabIndex = 21;
            // 
            // txtCod_Periodo
            // 
            this.txtCod_Periodo.Location = new System.Drawing.Point(104, 9);
            this.txtCod_Periodo.MaxLength = 50;
            this.txtCod_Periodo.Name = "txtCod_Periodo";
            this.txtCod_Periodo.Size = new System.Drawing.Size(163, 20);
            this.txtCod_Periodo.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Semestre";
            // 
            // Año
            // 
            this.Año.AutoSize = true;
            this.Año.Location = new System.Drawing.Point(12, 50);
            this.Año.Name = "Año";
            this.Año.Size = new System.Drawing.Size(26, 13);
            this.Año.TabIndex = 18;
            this.Año.Text = "Año";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Código ";
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(161, 123);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(121, 23);
            this.btnListar.TabIndex = 60;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // txtGuardar
            // 
            this.txtGuardar.Location = new System.Drawing.Point(15, 123);
            this.txtGuardar.Name = "txtGuardar";
            this.txtGuardar.Size = new System.Drawing.Size(121, 23);
            this.txtGuardar.TabIndex = 59;
            this.txtGuardar.Text = "Guardar";
            this.txtGuardar.UseVisualStyleBackColor = true;
            // 
            // frmPeriodo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 167);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtSemestre);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtCod_Periodo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Año);
            this.Controls.Add(this.label1);
            this.Name = "frmPeriodo";
            this.Text = "Periodo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSemestre;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtCod_Periodo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Año;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button txtGuardar;
    }
}