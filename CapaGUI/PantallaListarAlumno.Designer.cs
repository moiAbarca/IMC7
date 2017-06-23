namespace CapaGUI
{
    partial class PantallaListarAlumno
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
            this.btoMostrar = new System.Windows.Forms.Button();
            this.dataGridListadoCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListadoCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btoMostrar
            // 
            this.btoMostrar.Location = new System.Drawing.Point(12, 185);
            this.btoMostrar.Name = "btoMostrar";
            this.btoMostrar.Size = new System.Drawing.Size(167, 38);
            this.btoMostrar.TabIndex = 4;
            this.btoMostrar.Text = "Mostrar";
            this.btoMostrar.UseVisualStyleBackColor = true;
            this.btoMostrar.Click += new System.EventHandler(this.btoMostrar_Click);
            // 
            // dataGridListadoCliente
            // 
            this.dataGridListadoCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridListadoCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridListadoCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridListadoCliente.Location = new System.Drawing.Point(12, 12);
            this.dataGridListadoCliente.Name = "dataGridListadoCliente";
            this.dataGridListadoCliente.Size = new System.Drawing.Size(520, 165);
            this.dataGridListadoCliente.TabIndex = 3;
            // 
            // PantallaListarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 235);
            this.Controls.Add(this.btoMostrar);
            this.Controls.Add(this.dataGridListadoCliente);
            this.Name = "PantallaListarAlumno";
            this.Text = "PantallaListarAlumno";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridListadoCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btoMostrar;
        private System.Windows.Forms.DataGridView dataGridListadoCliente;
    }
}