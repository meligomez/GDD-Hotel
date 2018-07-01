namespace FrbaHotel.GenerarModificacionReserva
{
	partial class SeleccionHabitacionParaReserva
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
			this.lblFechaInicio = new System.Windows.Forms.Label();
			this.fechaInicio = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.cantHuespedes = new System.Windows.Forms.NumericUpDown();
			this.lblCantDias = new System.Windows.Forms.Label();
			this.cantDias = new System.Windows.Forms.NumericUpDown();
			this.buscarHabitacion = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.cantHuespedes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cantDias)).BeginInit();
			this.SuspendLayout();
			// 
			// lblFechaInicio
			// 
			this.lblFechaInicio.AutoSize = true;
			this.lblFechaInicio.Location = new System.Drawing.Point(50, 78);
			this.lblFechaInicio.Name = "lblFechaInicio";
			this.lblFechaInicio.Size = new System.Drawing.Size(103, 17);
			this.lblFechaInicio.TabIndex = 3;
			this.lblFechaInicio.Text = "Fecha de inicio";
			// 
			// fechaInicio
			// 
			this.fechaInicio.Location = new System.Drawing.Point(159, 75);
			this.fechaInicio.Name = "fechaInicio";
			this.fechaInicio.Size = new System.Drawing.Size(256, 22);
			this.fechaInicio.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(50, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(158, 17);
			this.label2.TabIndex = 21;
			this.label2.Text = "Cantidad de huespedes";
			// 
			// cantHuespedes
			// 
			this.cantHuespedes.Location = new System.Drawing.Point(214, 122);
			this.cantHuespedes.Name = "cantHuespedes";
			this.cantHuespedes.Size = new System.Drawing.Size(120, 22);
			this.cantHuespedes.TabIndex = 20;
			this.cantHuespedes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// lblCantDias
			// 
			this.lblCantDias.AutoSize = true;
			this.lblCantDias.Location = new System.Drawing.Point(444, 80);
			this.lblCantDias.Name = "lblCantDias";
			this.lblCantDias.Size = new System.Drawing.Size(114, 17);
			this.lblCantDias.TabIndex = 23;
			this.lblCantDias.Text = "Cantidad de dias";
			// 
			// cantDias
			// 
			this.cantDias.Location = new System.Drawing.Point(574, 77);
			this.cantDias.Name = "cantDias";
			this.cantDias.Size = new System.Drawing.Size(120, 22);
			this.cantDias.TabIndex = 22;
			this.cantDias.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// buscarHabitacion
			// 
			this.buscarHabitacion.Location = new System.Drawing.Point(251, 228);
			this.buscarHabitacion.Margin = new System.Windows.Forms.Padding(4);
			this.buscarHabitacion.Name = "buscarHabitacion";
			this.buscarHabitacion.Size = new System.Drawing.Size(217, 60);
			this.buscarHabitacion.TabIndex = 24;
			this.buscarHabitacion.Text = "BUSCAR HABITACION";
			this.buscarHabitacion.UseVisualStyleBackColor = true;
			this.buscarHabitacion.Click += new System.EventHandler(this.buscarHabitacion_Click);
			// 
			// SeleccionHabitacionParaReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buscarHabitacion);
			this.Controls.Add(this.lblCantDias);
			this.Controls.Add(this.cantDias);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.cantHuespedes);
			this.Controls.Add(this.lblFechaInicio);
			this.Controls.Add(this.fechaInicio);
			this.Name = "SeleccionHabitacionParaReserva";
			this.Text = "Seleccion de habitaciones para generar reservas";
			((System.ComponentModel.ISupportInitialize)(this.cantHuespedes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cantDias)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblFechaInicio;
		private System.Windows.Forms.DateTimePicker fechaInicio;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown cantHuespedes;
		private System.Windows.Forms.Label lblCantDias;
		private System.Windows.Forms.NumericUpDown cantDias;
		private System.Windows.Forms.Button buscarHabitacion;
	}
}