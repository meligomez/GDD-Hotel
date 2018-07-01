namespace FrbaHotel.AbmRegimen
{
    partial class Listar_Regimen
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvRegimenes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegimenes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegimenes
            // 
            this.dgvRegimenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegimenes.Location = new System.Drawing.Point(48, 90);
            this.dgvRegimenes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRegimenes.Name = "dgvRegimenes";
            this.dgvRegimenes.Size = new System.Drawing.Size(636, 226);
            this.dgvRegimenes.TabIndex = 10;
            this.dgvRegimenes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editar);
            // 
            // Modificar_Regimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(743, 396);
            this.Controls.Add(this.dgvRegimenes);
            this.Name = "Modificar_Regimen";
            this.Text = "Modicar/Eliminar regimen";
            this.Load += new System.EventHandler(this.Modificar_Regimen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegimenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegimenes;
    }
}
