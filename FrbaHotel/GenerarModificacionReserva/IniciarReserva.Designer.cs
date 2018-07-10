namespace FrbaHotel.GenerarModificacionReserva
{
	partial class IniciarReserva
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
			this.lblClienteMail = new System.Windows.Forms.Label();
			this.txtMailCliente = new System.Windows.Forms.TextBox();
			this.lblClienteIdentificacion = new System.Windows.Forms.Label();
			this.txtClienteIdentificacion = new System.Windows.Forms.TextBox();
			this.btnIniciarReserva = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblClienteMail
			// 
			this.lblClienteMail.AutoSize = true;
			this.lblClienteMail.Location = new System.Drawing.Point(23, 88);
			this.lblClienteMail.Name = "lblClienteMail";
			this.lblClienteMail.Size = new System.Drawing.Size(110, 17);
			this.lblClienteMail.TabIndex = 16;
			this.lblClienteMail.Text = "Email del cliente";
			// 
			// txtMailCliente
			// 
			this.txtMailCliente.Location = new System.Drawing.Point(139, 83);
			this.txtMailCliente.Name = "txtMailCliente";
			this.txtMailCliente.Size = new System.Drawing.Size(340, 22);
			this.txtMailCliente.TabIndex = 15;
			// 
			// lblClienteIdentificacion
			// 
			this.lblClienteIdentificacion.AutoSize = true;
			this.lblClienteIdentificacion.Location = new System.Drawing.Point(23, 142);
			this.lblClienteIdentificacion.Name = "lblClienteIdentificacion";
			this.lblClienteIdentificacion.Size = new System.Drawing.Size(158, 17);
			this.lblClienteIdentificacion.TabIndex = 18;
			this.lblClienteIdentificacion.Text = "Identificacion del cliente";
			// 
			// txtClienteIdentificacion
			// 
			this.txtClienteIdentificacion.Location = new System.Drawing.Point(198, 137);
			this.txtClienteIdentificacion.Name = "txtClienteIdentificacion";
			this.txtClienteIdentificacion.Size = new System.Drawing.Size(206, 22);
			this.txtClienteIdentificacion.TabIndex = 17;
			// 
			// btnIniciarReserva
			// 
			this.btnIniciarReserva.Location = new System.Drawing.Point(312, 223);
			this.btnIniciarReserva.Margin = new System.Windows.Forms.Padding(4);
			this.btnIniciarReserva.Name = "btnIniciarReserva";
			this.btnIniciarReserva.Size = new System.Drawing.Size(232, 60);
			this.btnIniciarReserva.TabIndex = 19;
			this.btnIniciarReserva.Text = "INICIAR RESERVA";
			this.btnIniciarReserva.UseVisualStyleBackColor = true;
			this.btnIniciarReserva.Click += new System.EventHandler(this.btnIniciarReserva_Click);
			// 
			// IniciarReserva
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnIniciarReserva);
			this.Controls.Add(this.lblClienteIdentificacion);
			this.Controls.Add(this.txtClienteIdentificacion);
			this.Controls.Add(this.lblClienteMail);
			this.Controls.Add(this.txtMailCliente);
			this.Name = "IniciarReserva";
			this.Text = "Iniciar Reserva";
			this.Load += new System.EventHandler(this.IniciarReserva_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblClienteMail;
		private System.Windows.Forms.TextBox txtMailCliente;
		private System.Windows.Forms.Label lblClienteIdentificacion;
		private System.Windows.Forms.TextBox txtClienteIdentificacion;
		private System.Windows.Forms.Button btnIniciarReserva;
	}
}