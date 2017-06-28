namespace CapaGUI
{
    partial class frmReporteAlumno
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
            this.dtReporteAlu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btGenerar = new System.Windows.Forms.Button();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.btExcel = new System.Windows.Forms.Button();
            this.dtEntregaResultados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtReporteAlu)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntregaResultados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtReporteAlu
            // 
            this.dtReporteAlu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtReporteAlu.Location = new System.Drawing.Point(733, 231);
            this.dtReporteAlu.Name = "dtReporteAlu";
            this.dtReporteAlu.Size = new System.Drawing.Size(100, 32);
            this.dtReporteAlu.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btGenerar);
            this.groupBox1.Controls.Add(this.txtRut);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 97);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reporte Alumno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Rut Alumno";
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(85, 60);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(100, 23);
            this.btGenerar.TabIndex = 1;
            this.btGenerar.Text = "Generar reporte";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(85, 19);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(100, 20);
            this.txtRut.TabIndex = 0;
            // 
            // btExcel
            // 
            this.btExcel.Location = new System.Drawing.Point(730, 296);
            this.btExcel.Name = "btExcel";
            this.btExcel.Size = new System.Drawing.Size(103, 23);
            this.btExcel.TabIndex = 6;
            this.btExcel.Text = "Generar Excel";
            this.btExcel.UseVisualStyleBackColor = true;
            this.btExcel.Click += new System.EventHandler(this.btExcel_Click);
            // 
            // dtEntregaResultados
            // 
            this.dtEntregaResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtEntregaResultados.Location = new System.Drawing.Point(257, 31);
            this.dtEntregaResultados.Name = "dtEntregaResultados";
            this.dtEntregaResultados.Size = new System.Drawing.Size(576, 165);
            this.dtEntregaResultados.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "En el mes transcurrido el alumno presenta un cambio de IMC de: ";
            // 
            // frmReporteAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 384);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtEntregaResultados);
            this.Controls.Add(this.btExcel);
            this.Controls.Add(this.dtReporteAlu);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmReporteAlumno";
            this.Text = "frmReporteAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dtReporteAlu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtEntregaResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtReporteAlu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btGenerar;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.Button btExcel;
        private System.Windows.Forms.DataGridView dtEntregaResultados;
        private System.Windows.Forms.Label label2;
    }
}