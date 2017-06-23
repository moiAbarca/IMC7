namespace CapaGUI
{
    partial class frmListaCurso
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
            this.txtListar = new System.Windows.Forms.Button();
            this.txtGuardar = new System.Windows.Forms.Button();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtCod_Curso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCod_Curso = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(111, 53);
            this.txtCurso.MaxLength = 50;
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(242, 20);
            this.txtCurso.TabIndex = 38;
            // 
            // txtCod_Curso
            // 
            this.txtCod_Curso.Location = new System.Drawing.Point(111, 12);
            this.txtCod_Curso.MaxLength = 50;
            this.txtCod_Curso.Name = "txtCod_Curso";
            this.txtCod_Curso.Size = new System.Drawing.Size(242, 20);
            this.txtCod_Curso.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Rut Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "ID Lista Curso";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Cod_Curso";
            // 
            // cmbCod_Curso
            // 
            this.cmbCod_Curso.FormattingEnabled = true;
            this.cmbCod_Curso.Location = new System.Drawing.Point(111, 94);
            this.cmbCod_Curso.Name = "cmbCod_Curso";
            this.cmbCod_Curso.Size = new System.Drawing.Size(241, 21);
            this.cmbCod_Curso.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Año";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 136);
            this.textBox1.MaxLength = 50;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 20);
            this.textBox1.TabIndex = 50;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 177);
            this.textBox2.MaxLength = 50;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(242, 20);
            this.textBox2.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Semestre";
            // 
            // frmListaCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 264);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbCod_Curso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtListar);
            this.Controls.Add(this.txtGuardar);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.txtCod_Curso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmListaCurso";
            this.Text = "Lista Curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button txtListar;
        private System.Windows.Forms.Button txtGuardar;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtCod_Curso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCod_Curso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}