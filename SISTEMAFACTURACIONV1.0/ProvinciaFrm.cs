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

namespace ErpGestion
{
    public partial class ProvinciaFrm : MetroFramework.Forms.MetroForm
    {
        public ProvinciaFrm()
        {
            InitializeComponent();
        }

        private void ProvinciaFrm_Load(object sender, EventArgs e)
        {
            bindingSourceProvincias.DataSource = new Provincia_localidad().ListarProvincias();
            metroTextBoxProvincia.DataBindings.Add("Text",bindingSourceProvincias,"Provincias1",true);

            
        }

        private void toolStripTextBoxFiltroLocalidad_TextChanged(object sender, EventArgs e)
        {
            bindingSourceProvincias.DataSource = new Provincia_localidad().FiltrarProvincias(toolStripTextBoxFiltroLocalidad.Text);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxProvincia.Text))
            {
                MessageBox.Show("Error, debe insertar la Provincia","Sistema de Gestion Integral",MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
            else
            {
                new Provincia_localidad().InsertarProvincia(metroTextBoxProvincia.Text);
                MessageBox.Show("Se ha Insertado con Exito","Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
