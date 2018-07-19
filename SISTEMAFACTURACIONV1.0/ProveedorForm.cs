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
    public partial class FrmEditProveedor : MetroFramework.Forms.MetroForm
    {

        View_Proveedores _proveedores = null;
        ProveedorManager Pmanager = new ProveedorManager();

        
        ProveedorRepository proveedorRepository=new ProveedorRepository();
        public string cuit { get; set; }


        public FrmEditProveedor()
        {
            InitializeComponent();
        }

        
        public FrmEditProveedor(View_Proveedores proveedores) : this()
        {
            _proveedores=proveedores;
        }
        
        //public FrmEditProveedor(string cuit) : this() {

        //    View_Proveedores prov = proveedorRepository.GetProveedoresByCuit(cuit);
        //    _proveedores = prov;
        //}




        private void FrmEditProveedor_Load(object sender, EventArgs e)
        {
            //Carga todos los Elementos del Proveedor
            View_Proveedores prov = proveedorRepository.GetProveedoresByCuit(cuit);
            _proveedores = prov;

            metroComboBoxProvincia.DataSource = new Provincia_localidad().ListarProvincias();
            metroComboBoxProvincia.DisplayMember = "Provincias1";
            metroComboBoxProvincia.ValueMember = "IdProvincias";


            metroComboBoxLocalidades.DataSource = new Provincia_localidad().ListarLocalidades();
            metroComboBoxLocalidades.DisplayMember = "Localidades1";
            metroComboBoxLocalidades.ValueMember = "IdLocalidad";

            metroComboBoxRubros.DataSource = proveedorRepository.GetRubroProveedors();
            metroComboBoxRubros.DisplayMember = "Descripcion";
            metroComboBoxRubros.ValueMember = "IDRubroProveedor";

            if (_proveedores!=null)
            {
                bindingSourceProveedor.DataSource = _proveedores;


                metroTextBoxNOMBRE.DataBindings.Add("Text", bindingSourceProveedor, "Nombre");
                metroTextBoxRAZON.DataBindings.Add("Text", bindingSourceProveedor, "Razon");
                metroTextBoxCUIT.DataBindings.Add("Text", bindingSourceProveedor, "Cuit");
                metroDateTimeFECHA.DataBindings.Add("Text", bindingSourceProveedor, "FechaIngreso");
                metroTextBoxIIBB.DataBindings.Add("Text", bindingSourceProveedor, "IngresosBrutos");
                metroTextBoxDIRECCION.DataBindings.Add("Text", bindingSourceProveedor, "Direccion");
                metroComboBoxProvincia.DataBindings.Add("Text", bindingSourceProveedor, "Provincias", true);
                metroComboBoxLocalidades.DataBindings.Add("Text", bindingSourceProveedor, "Localidades", true);
                metroTextBoxTELEFONO.DataBindings.Add("Text", bindingSourceProveedor, "Telefono");
                metroComboBoxRubros.DataBindings.Add("Text", bindingSourceProveedor, "RubroProveedor", true);


            }






        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroTextBoxNOMBRE.Text) || string.IsNullOrEmpty(metroTextBoxRAZON.Text) ||
                    string.IsNullOrEmpty(metroTextBoxCUIT.Text) || string.IsNullOrEmpty(metroTextBoxIIBB.Text))

                    MessageBox.Show("Error,Debes Insertar los Datos del Proveedor","Sistema de Gestion",MessageBoxButtons.RetryCancel,MessageBoxIcon.Error);
                {

                    if (new ProveedorManager().ValidateProveedor(metroTextBoxCUIT.Text)==1) {
                        new ProveedorManager().ActualizarProveedor(metroTextBoxNOMBRE.Text,metroTextBoxRAZON.Text,
                            metroTextBoxCUIT.Text,metroTextBoxIIBB.Text,metroTextBoxDIRECCION.Text,(int)metroComboBoxProvincia.SelectedValue
                            ,(int)metroComboBoxLocalidades.SelectedValue,(int)metroComboBoxRubros.SelectedValue,metroDateTimeFECHA.Value,metroTextBoxTELEFONO.Text);

                        MessageBox.Show("Proveedor Actualizado con Exito", "Sistema de Gestion Integral");
                        this.Close();

                    }
                    else
                    {
                        new ProveedorManager().InsertarProveedor(metroTextBoxNOMBRE.Text, metroTextBoxRAZON.Text,
                           metroTextBoxCUIT.Text, metroTextBoxIIBB.Text, metroTextBoxDIRECCION.Text, (int)metroComboBoxProvincia.SelectedValue
                           , (int)metroComboBoxLocalidades.SelectedValue, (int)metroComboBoxRubros.SelectedValue, metroDateTimeFECHA.Value,metroTextBoxTELEFONO.Text);

                        MessageBox.Show("Proveedor Ingresado con Exito","Sistema de Gestion Integral");
                        this.Close();
                    }













                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        #region IFindProvincia Members

        public void Selected(Provincias provincias)
        {
            //_proveedores.Provincias.IDProvincias = provincias.IDProvincias;
            //metroTextBoxProvincia.Text = provincias.Provincias1;
        }





        #endregion

        private void metroButtonProvincia_Click(object sender, EventArgs e)
        {
            //FindProvinciasFrm findProvinciasFrm = new FindProvinciasFrm(this,);
            //findProvinciasFrm.ShowDialog();
        }
    }
}
