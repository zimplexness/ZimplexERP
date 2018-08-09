using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLayer.Controller;
using BLayer;
using Entidades;




namespace ErpGestion
{
    public partial class AdminProveedorFrm : MetroFramework.Forms.MetroForm
    {
        private ProveedorController ProveedorController;

       
        public AdminProveedorFrm()
        {
            InitializeComponent();
            ProveedorController = new ProveedorController();
        }

         
        //ProveedorRepository proveedorRepository = new ProveedorRepository();
        private void ProveedoresForm_Load(object sender, EventArgs e)
        {


            var proveedores =ProveedorController.GetProveedores();

            bindingSourceProveedores.DataSource = proveedores;
            metroGridFiltrarProveedores.AutoGenerateColumns = false;
            metroGridFiltrarProveedores.DataSource = proveedores;
            metroGridFiltrarProveedores.AutoSize = false;

            foreach (var item in proveedores)
            {
                Nombre.DataPropertyName = "Nombre";
                Razon.DataPropertyName = "Razon";
                Cuit.DataPropertyName = "Cuit";
                IIBB.DataPropertyName = "IngresosBrutos";
                Direccion.DataPropertyName = "Direccion";
                Provincia.DataPropertyName = "Provincias";
                Localidad.DataPropertyName = "Localidades";
                Rubro.DataPropertyName = "RubroProveedor";

            }
















        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxFILTRONOMBRE_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBoxfiltrorazon_TextChanged(object sender, EventArgs e)
        {

        }

        private void metroTextBoxfiltrorubro_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void metroGridFiltrarProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
            //abrir formulario de comprobantes
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == typeof(FrmEditProveedor))
                {
                    f.Activate();
                    return;
                }
            }
            string cuit = metroGridFiltrarProveedores.CurrentRow.Cells["Cuit"].Value.ToString();
            FrmEditProveedor frmEditProveedor = new FrmEditProveedor();
           
            frmEditProveedor.cuit = cuit;
            
            
            frmEditProveedor.Show();


          
            


        }

        private void metroGridFiltrarProveedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {





        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            FrmEditProveedor frmEditProveedor = new FrmEditProveedor();

            //frmEditProveedor.FormClosed += frmEditProveedor_FormClose;
            frmEditProveedor.Show();

        }

        private void metroTextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            metroGridFiltrarProveedores.DataSource = ProveedorController.FilterByNombre(metroTextBoxNombre.Text);
        }

        private void metroTextBoxFilterRazon_TextChanged(object sender, EventArgs e)
        {
            metroGridFiltrarProveedores.DataSource = ProveedorController.FilterByRazon(metroTextBoxFilterRazon.Text);
        }

        private void metroTextBoxFilterRubro_TextChanged(object sender, EventArgs e)
        {

            metroGridFiltrarProveedores.DataSource = ProveedorController.FilterByRubro(metroTextBoxFilterRubro.Text);
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Desea Eliminar el Proveedor", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Add comprobante a Selected Comprobante
                foreach (DataGridViewRow row1 in metroGridFiltrarProveedores.Rows)
                {
                    DataGridViewCheckBoxCell ck = row1.Cells["Select"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(ck.Value) == true)
                    {
                        if (dialogResult == DialogResult.Yes)
                        {
                            new ProveedorManager().EliminarProveedor(metroGridFiltrarProveedores.CurrentRow.Cells["Cuit"].Value.ToString());
                            MessageBox.Show("Proveedor Eliminado Satisfactoriamente", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        private void metroTextBoxCuit_TextChanged(object sender, EventArgs e)
        {
            metroGridFiltrarProveedores.DataSource = ProveedorController.FilterByCuit(metroTextBoxCuit.Text);
        }
    }
}