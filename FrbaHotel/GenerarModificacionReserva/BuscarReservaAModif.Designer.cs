namespace FrbaHotel.GenerarModificacionReserva
{
	partial class BuscarReservaAModif
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
			this.txtReserva = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnBusqueda = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtReserva
			// 
			this.txtReserva.Location = new System.Drawing.Point(231, 75);
			this.txtReserva.Name = "txtReserva";
			this.txtReserva.Size = new System.Drawing.Size(293, 22);
			this.txtReserva.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(37, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(188, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Ingrese el codigo de reserva";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(113, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(377, 42);
			this.label2.TabIndex = 2;
			this.label2.Text = "Modificar una reserva";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// btnBusqueda
			// 
			this.btnBusqueda.Location = new System.Drawing.Point(200, 139);
			this.btnBusqueda.Name = "btnBusqueda";
			this.btnBusqueda.Size = new System.Drawing.Size(176, 38);
			this.btnBusqueda.TabIndex = 3;
			this.btnBusqueda.Text = "BUSCAR RESERVA";
			this.btnBusqueda.UseVisualStyleBackColor = true;
			// 
			// BuscarReservaAModif
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(615, 198);
			this.Controls.Add(this.btnBusqueda);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtReserva);
			this.Name = "BuscarReservaAModif";
			this.Text = "Form2";
			this.Load += new System.EventHandler(this.BuscarReservaAModif_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtReserva;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnBusqueda;
	}
}