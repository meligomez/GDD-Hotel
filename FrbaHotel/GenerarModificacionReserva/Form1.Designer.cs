namespace FrbaHotel.GenerarModificacionReserva
{
    partial class frmListHabitacionesDiponiblesPorHotel
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
			this.dgvHabitaciones = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvHabitaciones
			// 
			this.dgvHabitaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHabitaciones.Location = new System.Drawing.Point(143, 147);
			this.dgvHabitaciones.Margin = new System.Windows.Forms.Padding(4);
			this.dgvHabitaciones.Name = "dgvHabitaciones";
			this.dgvHabitaciones.Size = new System.Drawing.Size(636, 226);
			this.dgvHabitaciones.TabIndex = 11;
			// 
			// frmListHabitacionesDiponiblesPorHotel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(907, 428);
			this.Controls.Add(this.dgvHabitaciones);
			this.Name = "frmListHabitacionesDiponiblesPorHotel";
			this.Text = "Habitaciones disponibles";
			((System.ComponentModel.ISupportInitialize)(this.dgvHabitaciones)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.DataGridView dgvHabitaciones;
	}
}