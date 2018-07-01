namespace FrbaHotel.AbmRegimen
{
    partial class ABM_Regimen
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
            this.Volver = new System.Windows.Forms.Button();
            this.ModificarCliente = new System.Windows.Forms.Button();
            this.AgregarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(125, 224);
            this.Volver.Margin = new System.Windows.Forms.Padding(4);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(116, 37);
            this.Volver.TabIndex = 7;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            // 
            // ModificarCliente
            // 
            this.ModificarCliente.Location = new System.Drawing.Point(99, 125);
            this.ModificarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.ModificarCliente.Name = "ModificarCliente";
            this.ModificarCliente.Size = new System.Drawing.Size(175, 74);
            this.ModificarCliente.TabIndex = 5;
            this.ModificarCliente.Text = "MODIFICAR/ELIMINAR REGIMEN";
            this.ModificarCliente.UseVisualStyleBackColor = true;
            this.ModificarCliente.Click += new System.EventHandler(this.ModificarCliente_Click);
            // 
            // AgregarCliente
            // 
            this.AgregarCliente.Location = new System.Drawing.Point(99, 27);
            this.AgregarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.AgregarCliente.Name = "AgregarCliente";
            this.AgregarCliente.Size = new System.Drawing.Size(175, 74);
            this.AgregarCliente.TabIndex = 4;
            this.AgregarCliente.Text = "AGREGAR REGIMEN";
            this.AgregarCliente.UseVisualStyleBackColor = true;
            this.AgregarCliente.Click += new System.EventHandler(this.AgregarCliente_Click);
            // 
            // ABM_Regimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(403, 390);
            this.Controls.Add(this.Volver);
            this.Controls.Add(this.ModificarCliente);
            this.Controls.Add(this.AgregarCliente);
            this.Name = "ABM_Regimen";
            this.Text = "ABM de regimen";
            this.Load += new System.EventHandler(this.ABM_Regimen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Button ModificarCliente;
        private System.Windows.Forms.Button AgregarCliente;
    }
}
