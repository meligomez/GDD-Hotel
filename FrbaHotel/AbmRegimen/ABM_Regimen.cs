using FrbaHotel.FrbaHotelModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.AbmRegimen
{
    public partial class ABM_Regimen : FrbaHotel.Form1
    {
        private Regimen _regimen { get; }
        public ABM_Regimen()
        {
            this._regimen = new Regimen();
            InitializeComponent();
        }

        private void AgregarCliente_Click(object sender, EventArgs e)
        {
            Agregar_Regimen vpr = new Agregar_Regimen();
            this.Hide();
            vpr.ShowDialog();
        }

        private void ABM_Regimen_Load(object sender, EventArgs e)
        {
           
            
        }

        private void ModificarCliente_Click(object sender, EventArgs e)
        {
            Listar_Regimen vpr = new Listar_Regimen();
            this.Hide();
            vpr.ShowDialog();
        }
    }
}
