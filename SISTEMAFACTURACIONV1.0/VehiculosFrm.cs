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
    public partial class VehiculosFrm : MetroFramework.Forms.MetroForm
    {
        public VehiculosFrm()
        {
            InitializeComponent();
        }

          VehiculosManager ObjVehiculo = new VehiculosManager();


        private void VehiculosForm_Load(object sender, EventArgs e)
        {

            //LLenar todos los combobox
            VehiculosManager objvehiculo = new VehiculosManager();

            metroComboBoxMarca.DataSource = objvehiculo.MarcasVehiculos();
            metroComboBoxMarca.DisplayMember = "Marcas";
            metroComboBoxMarca.ValueMember = "IDMarca";

            metroComboBoxModelo.DataSource = objvehiculo.ModelosVehiculosTodos();
            metroComboBoxModelo.DisplayMember = "Modelo";
            metroComboBoxModelo.ValueMember = "IDModeloVehiculo";

           metroComboBoxChoferes.DataSource = objvehiculo.Choferes();
            metroComboBoxChoferes.DisplayMember = "Chofer";
            metroComboBoxChoferes.ValueMember = "IDEmpleado";

            metroComboBoxCombustible.DataSource = objvehiculo.Combustibles();
            metroComboBoxCombustible.DisplayMember = "Descripcion";
            metroComboBoxCombustible.ValueMember = "IDCombustible";

            metroComboBoxPoliza.DataSource = objvehiculo.PolizaSeguros();
            metroComboBoxPoliza.DisplayMember = "Descripcion";
            metroComboBoxPoliza.ValueMember = "IDPolizaSeguro";

            bindingSourceVehiculos.DataSource = objvehiculo.listaVehiculosActivos();

            metroGridvehiculos.DataSource = objvehiculo.listaVehiculosActivos();


           

            //binding object 
            PropertyDescriptor Activochk = bindingSourceVehiculos.GetItemProperties(null)["Activo"];

            metroCheckBoxActivo.Checked = (bool)Activochk.GetValue(bindingSourceVehiculos.Current);
            metroTextBoxPatente.DataBindings.Add("Text", bindingSourceVehiculos, "Patente", true);
            metroComboBoxMarca.DataBindings.Add("Text", bindingSourceVehiculos, "Marcas", true);
            metroComboBoxModelo.DataBindings.Add("Text", bindingSourceVehiculos, "Modelo", true);
            metroTextBoxNochasis.DataBindings.Add("Text", bindingSourceVehiculos, "Nochasis", true);
            metroTextBoxNomotor.DataBindings.Add("Text", bindingSourceVehiculos, "NoMotor", true);
            metroComboBoxCombustible.DataBindings.Add("Text", bindingSourceVehiculos, "TipoCombustible", true);
            metroTextBoxyear.DataBindings.Add("Text", bindingSourceVehiculos, "Year", true);
            metroDateTimeFechaCompra.DataBindings.Add("Text", bindingSourceVehiculos, "FechaCompra", true);
            metroDateTimeFechaTransferencia.DataBindings.Add("Text", bindingSourceVehiculos, "FechaTransferencia", true);
            metroDateTimeVTV.DataBindings.Add("Text", bindingSourceVehiculos, "VigenciaVTV", true);
            metroComboBoxChoferes.DataBindings.Add("Text", bindingSourceVehiculos,"Chofer",true);
            
            metroTextBoxTitular.DataBindings.Add("Text", bindingSourceVehiculos, "Titular", true);
            metroTextBoxKm.DataBindings.Add("Text", bindingSourceVehiculos, "KM", true);





        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(metroTextBoxPatente.Text))
            {
                MessageBox.Show("Error,Tiene que insertar una patente ","Sistema de Gestion Integral",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                if (ObjVehiculo.ValidateVehiculo(metroTextBoxPatente.Text)==1)
                {
                    DialogResult dialogresult = MessageBox.Show("El Vehiculo ya existe, Deseas Actualizarlo","Sistema de Gestion Integral",MessageBoxButtons.OKCancel,MessageBoxIcon.Exclamation);
                    if (dialogresult==DialogResult.OK)
                    {
                        ObjVehiculo.UpdateVehiculo(metroCheckBoxActivo.Checked, metroTextBoxPatente.Text, (int)metroComboBoxMarca.SelectedValue,
                            (int)metroComboBoxModelo.SelectedValue, metroTextBoxNochasis.Text, metroTextBoxNomotor.Text, (int)metroComboBoxPoliza.SelectedValue,
                            metroCheckBoxNeumaticos.Checked, (int)metroComboBoxCombustible.SelectedValue, int.Parse(metroTextBoxyear.Text),metroDateTimeFechaCompra.Value,
                            metroDateTimeFechaTransferencia.Value,metroDateTimeVTV.Value,(int)metroComboBoxChoferes.SelectedValue,metroTextBoxTitular.Text,int.Parse(metroTextBoxKm.Text)
                            );
                        MessageBox.Show("Se ha Actualizado con exito el vehiculo","Sistema de Gestion Integral",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    }


                }
                else
                {
                    DialogResult dialogresult2= MessageBox.Show("El Vehiculo no existe, Deseas Crearlo?", "Sistema de Gestion Integral", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                    if (dialogresult2==DialogResult.OK)
                    {
                        ObjVehiculo.InsertarVehiculo(
                            metroCheckBoxActivo.Checked, 
                            metroTextBoxPatente.Text, 
                            (int)metroComboBoxMarca.SelectedValue,
                           (int)metroComboBoxModelo.SelectedValue,
                           metroTextBoxNochasis.Text,
                           metroTextBoxNomotor.Text,
                           (int)metroComboBoxPoliza.SelectedValue,
                           metroCheckBoxNeumaticos.Checked, 
                           (int)metroComboBoxCombustible.SelectedValue,
                           int.Parse(metroTextBoxyear.Text),
                           metroDateTimeFechaCompra.Value,
                           metroDateTimeFechaTransferencia.Value,
                           metroDateTimeVTV.Value,
                           (int)metroComboBoxChoferes.SelectedValue,
                           metroTextBoxTitular.Text,
                           int.Parse(metroTextBoxKm.Text)
                           );
                        MessageBox.Show("Se ha Insertado el Vehiculo Con Exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                   
                }
            }
        }

        private void metroTextBoxFiltrarApellido_TextChanged(object sender, EventArgs e)
        {

            metroGridvehiculos.DataSource = new VehiculosManager().FiltrarVehiculosxPatentes(metroTextBoxFiltrarPantente.Text);
        }

        private void metroComboBoxMarca_Leave(object sender, EventArgs e)
        {

            metroComboBoxModelo.DataSource = new  VehiculosManager().ModelosVehiculos((int)metroComboBoxMarca.SelectedValue);
            metroComboBoxModelo.DisplayMember = "Modelo";
            metroComboBoxModelo.ValueMember = "IDModeloVehiculo";
        }

        private void metroComboBoxChoferes_Click(object sender, EventArgs e)
        {
           metroComboBoxChoferes.DataSource = new VehiculosManager().Choferes();
           metroComboBoxChoferes.DisplayMember = "Chofer";
           metroComboBoxChoferes.ValueMember = "IDEmpleado";
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            bindingSourceVehiculos.DataSource = new VehiculosManager().FiltrarVehiculosxPatentes(toolStripTextBoxFilter.Text);
        }

        private void metroTextBoxMarca_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void metroTextBoxAnno_TextChanged(object sender, EventArgs e)
        {

            if (metroTextBoxAnno.Text == "")
            {
                metroGridvehiculos.DataSource = new VehiculosManager().listaVehiculosActivos();
            }
            else { 
            metroGridvehiculos.DataSource = new VehiculosManager().FiltrarVehiculosxYear(int.Parse(metroTextBoxAnno.Text.ToString()));
             }
        }

        private void metroTextBoxMarca_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void metroTextBoxBrand_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBoxBrand.Text=="")
            {
                metroGridvehiculos.DataSource = new VehiculosManager().listaVehiculosActivos();

            }
            metroGridvehiculos.DataSource = new VehiculosManager().FiltrarVehiculosxMarca(metroTextBoxBrand.Text);
        }
    }
}
