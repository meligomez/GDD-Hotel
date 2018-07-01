namespace FrbaHotel.AbmRegimen
{
    partial class Modificar_regimen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.modificarRegimen = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.precioBase = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Precio Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Descripcion:";
            // 
            // modificarRegimen
            // 
            this.modificarRegimen.Location = new System.Drawing.Point(345, 310);
            this.modificarRegimen.Margin = new System.Windows.Forms.Padding(4);
            this.modificarRegimen.Name = "modificarRegimen";
            this.modificarRegimen.Size = new System.Drawing.Size(133, 60);
            this.modificarRegimen.TabIndex = 21;
            this.modificarRegimen.Text = "GUARDAR CAMBIOS";
            this.modificarRegimen.UseVisualStyleBackColor = true;
            this.modificarRegimen.Click += new System.EventHandler(this.modificarRegimen_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(86, 310);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 60);
            this.btnVolver.TabIndex = 20;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(199, 79);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(211, 22);
            this.descripcion.TabIndex = 19;
            // 
            // precioBase
            // 
            this.precioBase.Location = new System.Drawing.Point(198, 116);
            this.precioBase.Name = "precioBase";
            this.precioBase.Size = new System.Drawing.Size(212, 22);
            this.precioBase.TabIndex = 24;
            // 
            // Modificar_regimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(564, 449);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.modificarRegimen);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.precioBase);
            this.Name = "Modificar_regimen";
            this.Text = "Modificar regimen";
            this.Load += new System.EventHandler(this.Modificar_regimen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button modificarRegimen;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox precioBase;
    }
}
