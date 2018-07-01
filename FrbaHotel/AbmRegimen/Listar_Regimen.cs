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
    public partial class Listar_Regimen : FrbaHotel.Form1
    {
        private Regimen _regimen { get; }
        public string rol { get; set; }
        public Listar_Regimen()
        {
            this._regimen = new Regimen();
            rol = "administrador";
            InitializeComponent();
        }

        private void Modificar_Regimen_Load(object sender, EventArgs e)
        {
            try
            {
                DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
                
                dgvRegimenes.Columns.Add(btn);
                btn.Text = "Editar";
                btn.Name = "Edicion";
                btn.UseColumnTextForButtonValue = true;
                DataGridViewButtonColumn btn2 = new DataGridViewButtonColumn();
             
                dgvRegimenes.Columns.Add(btn2);
                btn2.Text = "Eliminar";
                btn2.Name = "Eliminacion";
                btn2.UseColumnTextForButtonValue = true;
                this.dgvRegimenes.DataSource = _regimen.getRegimenes(rol);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                throw;
            }
        }

        private void editar(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //Console.WriteLine("Button on row {0} clicked", e.RowIndex);
                DataGridViewRow row = dgvRegimenes.CurrentRow;

                int idRegimen = Convert.ToInt32(row.Cells["regimen_Id"].Value);
                if (e.ColumnIndex == dgvRegimenes.Columns["Edicion"].Index && e.RowIndex >= 0)
                {
                    Modificar_regimen vpr = new Modificar_regimen(idRegimen);
                    this.Hide();
                    vpr.ShowDialog();
                }
                else if (e.ColumnIndex == dgvRegimenes.Columns["Eliminacion"].Index && e.RowIndex >= 0) {

                }

            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                throw;
            }
        }
    }
}
