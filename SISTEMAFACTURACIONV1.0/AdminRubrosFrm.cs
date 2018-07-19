using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLayer;
using Entidades;
using Repositories;

namespace ErpGestion
{
    public partial class AdminRubrosFrm : MetroFramework.Forms.MetroForm
    {
        public AdminRubrosFrm()
        {
            InitializeComponent();
        }

        private void AdminRubrosFrm_Load(object sender, EventArgs e)
        {
            IEnumerable<RubroProveedor> RUBRO = new ProveedorManager().ListarRubros();


            metroGridRubro.AutoGenerateColumns = false;
            metroGridRubro.DataSource = RUBRO;
            metroGridRubro.AutoSize = false;

            foreach (var item in RUBRO)
            {
                IdRubro.DataPropertyName = "IDRubroProveedor";
                Rubros.DataPropertyName = "Descripcion";

            }

        }

        private void metroTextBoxRubro_TextChanged(object sender, EventArgs e)
        {
            metroGridRubro.DataSource = new ProveedorManager().FilterRubros(metroTextBoxRubro.Text);

           

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RubroForm rubroForm = new RubroForm();
            rubroForm.FormClosed += rubroForm_Form_Closed;
            rubroForm.ShowDialog();
        }

        private void rubroForm_Form_Closed(Object sender,FormClosedEventArgs e) {
            Form form = sender as Form;
            if (form.DialogResult==DialogResult.OK)
            {
                IEnumerable<RubroProveedor> RUBRO = new ProveedorManager().ListarRubros();


                metroGridRubro.AutoGenerateColumns = false;
                metroGridRubro.DataSource = RUBRO;
                metroGridRubro.AutoSize = false;

                foreach (var item in RUBRO)
                {
                    IdRubro.DataPropertyName = "IDRubroProveedor";
                    Rubros.DataPropertyName = "Descripcion";

                }

            }

        }


        private void metroGridRubro_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RubroForm frmrubro = new RubroForm();
            frmrubro.Rubro =int.Parse( metroGridRubro.CurrentRow.Cells["IdRubro"].Value.ToString());
            // frmcuenta.FormClosed += frmcuenta_FormClosed;
            frmrubro.FormClosed += rubroForm_Form_Closed;
            frmrubro.Show();
        }
    }
}
