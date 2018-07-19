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
    public partial class AdminProveedorFrm : MetroFramework.Forms.MetroForm
    {


        public AdminProveedorFrm()
        {
            InitializeComponent();
        }

        ProveedorRepository proveedorRepository = new ProveedorRepository();
        private void ProveedoresForm_Load(object sender, EventArgs e)
        {


            IEnumerable<View_Proveedores> proveedores = proveedorRepository.GetAll();


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
            string cuit = metroGridFiltrarProveedores.CurrentRow.Cells["Cuit"].Value.ToString();
            FrmEditProveedor frmEditProveedor = new FrmEditProveedor();
            frmEditProveedor.cuit = cuit;
            //frmEditProveedor.FormClosed += frmEditProveedor_FormClose;
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
            metroGridFiltrarProveedores.DataSource = proveedorRepository.GetByNombre(metroTextBoxNombre.Text);
        }

        private void metroTextBoxFilterRazon_TextChanged(object sender, EventArgs e)
        {
            metroGridFiltrarProveedores.DataSource = proveedorRepository.GetByRazon(metroTextBoxFilterRazon.Text);
        }

        private void metroTextBoxFilterRubro_TextChanged(object sender, EventArgs e)
        {

            metroGridFiltrarProveedores.DataSource = proveedorRepository.GetByRubro(metroTextBoxFilterRubro.Text);
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}