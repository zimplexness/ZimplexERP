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
    }
}
