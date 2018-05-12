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
    public partial class TalleresForm : MetroFramework.Forms.MetroForm
    {
        public TalleresForm()
        {
            InitializeComponent();
        }

        private void TallerForm_Load(object sender, EventArgs e)
        {
            bindingSourceTaller.DataSource = new TallerManager().TalleresMecanicos();

            metroComboBoxlocalidad.DataSource = new Provincia_localidad().ListarLocalidades();
            metroComboBoxlocalidad.DisplayMember = "Localidades1";
            metroComboBoxlocalidad.ValueMember = "IdLocalidad";

            metroComboBoxtipotaller.DataSource = new TallerManager().TiposTaller();
            metroComboBoxtipotaller.DisplayMember = "DescripcionTaller";
            metroComboBoxtipotaller.ValueMember = "IdTipoTaller";

            metroTextBoxNombre.DataBindings.Add("Text",bindingSourceTaller,"NombreTaller",true);
            metroTextBoxencargado.DataBindings.Add("Text",bindingSourceTaller,"NombreEncargado",true);
            metroTextBoxdireccion.DataBindings.Add("Text",bindingSourceTaller,"Direccion",true);
            metroComboBoxlocalidad.DataBindings.Add("Text",bindingSourceTaller,"Localidades",true);
            metroTextBoxtelefono.DataBindings.Add("Text",bindingSourceTaller,"TelefonoCotacto",true);
            metroComboBoxtipotaller.DataBindings.Add("Text",bindingSourceTaller,"DescripcionTaller",true);





        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxNombre.Text)|| string.IsNullOrEmpty(metroTextBoxdireccion.Text)||string.IsNullOrEmpty(metroTextBoxencargado.Text))
            {

                MessageBox.Show("Error, debe insertar los datos","Sistema de Gestion Integral",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                if (new TallerManager().validateTaller(metroTextBoxNombre.Text, metroTextBoxdireccion.Text) == 1)
                {
                    DialogResult dialogresult = MessageBox.Show("Ya existe el Taller, Desea Actualizarlo?", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    if (dialogresult == DialogResult.OK)
                    {
                        new TallerManager().
                            UpdateTaller(metroTextBoxNombre.Text, metroTextBoxdireccion.Text,
                            (int)metroComboBoxlocalidad.SelectedValue,
                            metroTextBoxtelefono.Text,
                            metroTextBoxencargado.Text,
                            (int)metroComboBoxtipotaller.SelectedValue
                            );

                        MessageBox.Show("Se actualizo con exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);




                    }
                }
                else {

                    DialogResult dialogresult1 = MessageBox.Show("No Existe el taller, Desea Crearlo?","Sistema Gestion Integral",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

                    if (dialogresult1==DialogResult.OK)
                    {
                        new TallerManager().InsertarTaller(metroTextBoxNombre.Text, metroTextBoxdireccion.Text,
                            (int)metroComboBoxlocalidad.SelectedValue,
                            metroTextBoxtelefono.Text,
                            metroTextBoxencargado.Text,
                            (int)metroComboBoxtipotaller.SelectedValue);
                        MessageBox.Show("Se inserto con exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }





                }



            }
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }
    }
}
