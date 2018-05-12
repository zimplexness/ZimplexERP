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
    public partial class LocalidadesFrm : MetroFramework.Forms.MetroForm
    {
        public LocalidadesFrm()
        {
            InitializeComponent();
        }
       
        private void LocalidadForm_Load(object sender, EventArgs e)
        {
            Provincia_localidad LocalidadObject = new Provincia_localidad();
            bindingSourceLocalidades.DataSource = LocalidadObject.ListarLocalidades();
            //metroGridLocalidades.DataSource = bindingSourceLocalidades;           

            metroTextBoxLocalidad.DataBindings.Add("Text",bindingSourceLocalidades,"Localidades1",true);
            metroTextBoxcp.DataBindings.Add("Text",bindingSourceLocalidades,"CodigoPostal",true);



        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Provincia_localidad provinciamanager = new Provincia_localidad();
            if (string.IsNullOrEmpty(metroTextBoxLocalidad.Text)||string.IsNullOrEmpty(metroTextBoxcp.Text))
            {
                MessageBox.Show("Error, debe insertar los datos","Sistema Gestion Integral",MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            if (provinciamanager.ValidateLocalidad(metroTextBoxLocalidad.Text)==1)
            {
                DialogResult dialogResult = MessageBox.Show("Ya existe la localidad,Deseas Actualizarla?", "Sistema de Gestion Integral", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    provinciamanager.ActualizarLocalidad(metroTextBoxLocalidad.Text, metroTextBoxcp.Text);
                    MessageBox.Show("Se ha actualizado con exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("No existe la localidad,Deseas Crearlo?", "Sistema de Gestion Integral", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    provinciamanager.InsertarLocalidad(metroTextBoxLocalidad.Text, metroTextBoxcp.Text);
                    MessageBox.Show("Se ha Insertado con exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

               

        
         }

        private void toolStripTextBoxFiltroLocalidad_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBoxFiltroLocalidad_TextChanged(object sender, EventArgs e)
        {
            bindingSourceLocalidades.DataSource = new Provincia_localidad().FiltrarLocalidades(toolStripTextBoxFiltroLocalidad.Text);
        }
    }
}
