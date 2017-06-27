namespace CapaGUI
{
    partial class frmLstMedidaCorrectiva
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
            this.dgListadoCargos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListadoCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // btoMostrar
            // 
            this.btoMostrar.Location = new System.Drawing.Point(12, 185);
            this.btoMostrar.Name = "btoMostrar";
            this.btoMostrar.Size = new System.Drawing.Size(167, 38);
            this.btoMostrar.TabIndex = 10;
            this.btoMostrar.Text = "Mostrar";
            this.btoMostrar.UseVisualStyleBackColor = true;
            this.btoMostrar.Click += new System.EventHandler(this.btoMostrar_Click);
            // 
            // dgListadoCargos
            // 
            this.dgListadoCargos.AllowUserToAddRows = false;
            this.dgListadoCargos.AllowUserToDeleteRows = false;
            this.dgListadoCargos.AllowUserToResizeColumns = false;
            this.dgListadoCargos.AllowUserToResizeRows = false;
            this.dgListadoCargos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgListadoCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListadoCargos.Location = new System.Drawing.Point(12, 12);
            this.dgListadoCargos.Name = "dgListadoCargos";
            this.dgListadoCargos.ReadOnly = true;
            this.dgListadoCargos.RowHeadersVisible = false;
            this.dgListadoCargos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgListadoCargos.Size = new System.Drawing.Size(441, 165);
            this.dgListadoCargos.TabIndex = 9;
            // 
            // frmLstMedidaCorrectiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 236);
            this.Controls.Add(this.btoMostrar);
            this.Controls.Add(this.dgListadoCargos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLstMedidaCorrectiva";
            this.Text = "Lista de Medidas  Correctivas";
            ((System.ComponentModel.ISupportInitialize)(this.dgListadoCargos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btoMostrar;
        private System.Windows.Forms.DataGridView dgListadoCargos;
    }
}