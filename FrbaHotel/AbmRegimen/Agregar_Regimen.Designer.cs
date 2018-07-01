namespace FrbaHotel.AbmRegimen
{
    partial class Agregar_Regimen
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
            this.agregarEmpresa = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.precioBase = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // agregarEmpresa
            // 
            this.agregarEmpresa.Location = new System.Drawing.Point(285, 285);
            this.agregarEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.agregarEmpresa.Name = "agregarEmpresa";
            this.agregarEmpresa.Size = new System.Drawing.Size(133, 60);
            this.agregarEmpresa.TabIndex = 15;
            this.agregarEmpresa.Text = "AGREGAR REGIMEN";
            this.agregarEmpresa.UseVisualStyleBackColor = true;
            this.agregarEmpresa.Click += new System.EventHandler(this.agregarEmpresa_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(26, 285);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(135, 60);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // descripcion
            // 
            this.descripcion.Location = new System.Drawing.Point(139, 54);
            this.descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(211, 22);
            this.descripcion.TabIndex = 13;
            // 
            // precioBase
            // 
            this.precioBase.Location = new System.Drawing.Point(138, 91);
            this.precioBase.Name = "precioBase";
            this.precioBase.Size = new System.Drawing.Size(212, 22);
            this.precioBase.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Precio Base:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descripcion:";
            // 
            // Agregar_Regimen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.ClientSize = new System.Drawing.Size(444, 398);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.agregarEmpresa);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.precioBase);
            this.Name = "Agregar_Regimen";
            this.Text = "Alta de Regimen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button agregarEmpresa;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox precioBase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
