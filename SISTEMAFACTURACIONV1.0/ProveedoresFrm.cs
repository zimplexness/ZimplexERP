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

namespace ErpGestion
{
    public partial class ProveedoresFrm : MetroFramework.Forms.MetroForm
    {
        public ProveedoresFrm()
        {
            InitializeComponent();
        }

        private void ProveedoresForm_Load(object sender, EventArgs e)
        {
           
            
            this.BringToFront();
            Provincia_localidad PLmanager = new Provincia_localidad();
            metroComboBoxPROVINCIA.DataSource = PLmanager.ListarProvincias();
            metroComboBoxLOCALIDAD.DataSource = PLmanager.ListarLocalidades();

            metroComboBoxPROVINCIA.DisplayMember = "Provincias1";
            metroComboBoxPROVINCIA.ValueMember = "IDProvincias";

            metroComboBoxLOCALIDAD.DisplayMember = "Localidades1";
            metroComboBoxLOCALIDAD.ValueMember = "IdLocalidad";

           

            ProveedorManager p = new ProveedorManager();

            //llenar combo productor
            metroComboBoxNOMBREPRODUCTOR.DataSource = p.ListarProductorSeguro();
            metroComboBoxNOMBREPRODUCTOR.DisplayMember = "Nombre";
            metroComboBoxNOMBREPRODUCTOR.ValueMember = "IdProductorSeguro";

            //llenar combo de rubros
            metroComboBoxRUBROS.DataSource = p.ListarRubros();
            metroComboBoxRUBROS.DisplayMember = "Descripcion";
            metroComboBoxRUBROS.ValueMember = "IDRubroProveedor";
            bindingSourceProveedores.DataSource = new ProveedorManager().ListarProveedores();
            metroGrid2.DataSource = bindingSourceProveedores;
        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //declarando todos los objetos para manejar proveedores, localidad y provincia
                ProveedorManager pm = new ProveedorManager();
                CuentaCorrienteManager c = new CuentaCorrienteManager();
                //validar la entrada de los datos
                if (string.IsNullOrEmpty(metroTextBoxNOMBRE.Text) || string.IsNullOrEmpty(metroTextBoxCUIT.Text) || string.IsNullOrEmpty(metroTextBoxRAZON.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre, Razon y CUIT", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //validar el cuit del proveedor
                    if (pm.ValidateProveedor(metroTextBoxCUIT.Text) == 1)
                    {
                        MessageBox.Show("Ya existe un proveedor con el mismo CUIT", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    else
                    {

                        //Crear un proveedor con cuenta corriente
                        if (metroCheckCUENTACORRIENTE.Checked == true || metroCheckBoxPRODUCTOR.Checked == true)
                        {
                            int idproveedor = 0;
                            //Insertar en la tabla proveedores
                            Proveedores prov = new Proveedores();
                            prov.Nombre = metroTextBoxNOMBRE.Text;
                            prov.Razon = metroTextBoxRAZON.Text;
                            prov.Cuit = metroTextBoxCUIT.Text;
                            prov.FechaIngreso = metroDateTimeFECHA.Value;
                            prov.IngresosBrutos = metroTextBoxIIBB.Text;
                            prov.Telefono = metroTextBoxTELEFONO.Text;
                            prov.Direccion = metroTextBoxDIRECCION.Text;
                            prov.IDProvincia =(int)metroComboBoxPROVINCIA.SelectedValue;
                            prov.IDLocalidad = int.Parse(metroComboBoxLOCALIDAD.SelectedValue.ToString());
                            prov.IDRubro = int.Parse(metroComboBoxRUBROS.SelectedValue.ToString());
                            idproveedor = pm.insertar_proveedor(prov);

                            //Crear Una cuenta corriente para el proveedor
                            CuentaCorriente cuenta = new CuentaCorriente();
                            cuenta.Nombre = metroTextBoxCUIT.Text;
                            cuenta.Vencimiento = int.Parse(metroComboBoxVENCIMIENTO.Text);
                            cuenta.IDProveedor = pm.devolverIDProveedorCUIT(metroTextBoxCUIT.Text);
                            pm.CrearCuentaCorriente(cuenta);

                            //insertar productor de seguro

                            if (metroCheckBoxPRODUCTOR.Checked == true)
                            {
                                pm.InsertarProductorSeguro(idproveedor, int.Parse(metroComboBoxNOMBREPRODUCTOR.SelectedValue.ToString()));
                            }





                            MessageBox.Show("El Proveedor con Cuenta Corriente fue creado Satisfactoriamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            metroCheckCUENTACORRIENTE.Checked = false;
                            metroCheckBoxPRODUCTOR.Checked = false;


                        }
                        else
                        {

                            //Insertar en la tabla proveedores
                            Proveedores prov = new Proveedores();
                            prov.Nombre = metroTextBoxNOMBRE.Text;
                            prov.Razon = metroTextBoxRAZON.Text;
                            prov.Cuit = metroTextBoxCUIT.Text;
                            prov.FechaIngreso = metroDateTimeFECHA.Value;
                            prov.IngresosBrutos = metroTextBoxIIBB.Text;
                            prov.Telefono = metroTextBoxTELEFONO.Text;
                            prov.Direccion = metroTextBoxDIRECCION.Text;
                            prov.IDProvincia =(int) metroComboBoxPROVINCIA.SelectedValue;
                            prov.IDLocalidad = int.Parse(metroComboBoxLOCALIDAD.SelectedValue.ToString());
                            prov.IDRubro = int.Parse(metroComboBoxRUBROS.SelectedValue.ToString());
                            pm.insertar_proveedor(prov);
                            MessageBox.Show("El Proveedor fue creado Satisfactoriamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                    }

                    metroTextBoxNOMBRE.Clear();
                    metroTextBoxRAZON.Clear();
                    metroTextBoxCUIT.Clear();
                    metroTextBoxIIBB.Clear();
                    metroTextBoxTELEFONO.Clear();
                    metroTextBoxRAZON.Clear();
                    metroTextBoxDIRECCION.Clear();
                    metroGrid2.Refresh();
                    metroGrid2.DataSource = pm.ListarProveedores();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {

                ProveedorManager pm = new ProveedorManager();


                pm.ActualizarProveedor(metroTextBoxNOMBRE.Text, metroTextBoxRAZON.Text, metroTextBoxTELEFONO.Text, metroTextBoxDIRECCION.Text, metroTextBoxCUIT.Text);

                MessageBox.Show("EL proveedor se ha actualizado con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                metroGrid2.DataSource = pm.ListarProveedores();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            Proveedores p = new Proveedores();
            p = pm.EncontrarProveedor(metroGrid2.CurrentRow.Cells["Cuit"].Value.ToString());

            metroTextBoxNOMBRE.Text = p.Nombre;
            metroTextBoxRAZON.Text = p.Razon;
            metroTextBoxTELEFONO.Text = p.Telefono;
            metroTextBoxDIRECCION.Text = p.Direccion;
            metroTextBoxCUIT.Text = p.Cuit;
            metroTabPage1.Focus();
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
            try
            {
                //declarando todos los objetos para manejar proveedores, localidad y provincia
                ProveedorManager pm = new ProveedorManager();
                CuentaCorrienteManager c = new CuentaCorrienteManager();
                //validar la entrada de los datos
                if (string.IsNullOrEmpty(metroTextBoxNOMBRE.Text) || string.IsNullOrEmpty(metroTextBoxCUIT.Text) || string.IsNullOrEmpty(metroTextBoxRAZON.Text))
                {
                    MessageBox.Show("Debe ingresar el nombre, Razon y CUIT", "Sistema de Facturacion", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    //validar el cuit del proveedor
                    if (pm.ValidateProveedor(metroTextBoxCUIT.Text) == 1)
                    {
                       DialogResult dialogresult= MessageBox.Show("Ya existe un proveedor con el mismo CUIT, Desea Actualizarlo", "Sistema de Gestion de Compras", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dialogresult==DialogResult.Yes)
                        {
                      


                            pm.ActualizarProveedor(metroTextBoxNOMBRE.Text, metroTextBoxRAZON.Text, metroTextBoxTELEFONO.Text, metroTextBoxDIRECCION.Text, metroTextBoxCUIT.Text);

                            MessageBox.Show("EL proveedor se ha actualizado con exito", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            metroGrid2.DataSource = pm.ListarProveedores();

                        }

                    }
                    else
                    {

                        //Crear un proveedor con cuenta corriente
                        if (metroCheckCUENTACORRIENTE.Checked == true || metroCheckBoxPRODUCTOR.Checked == true)
                        {
                            int idproveedor = 0;
                            //Insertar en la tabla proveedores
                            Proveedores prov = new Proveedores();
                            prov.Nombre = metroTextBoxNOMBRE.Text;
                            prov.Razon = metroTextBoxRAZON.Text;
                            prov.Cuit = metroTextBoxCUIT.Text;
                            prov.FechaIngreso = metroDateTimeFECHA.Value;
                            prov.IngresosBrutos = metroTextBoxIIBB.Text;
                            prov.Telefono = metroTextBoxTELEFONO.Text;
                            prov.Direccion = metroTextBoxDIRECCION.Text;
                            prov.IDProvincia =(int) metroComboBoxPROVINCIA.SelectedValue;
                            prov.IDLocalidad = int.Parse(metroComboBoxLOCALIDAD.SelectedValue.ToString());
                            prov.IDRubro = int.Parse(metroComboBoxRUBROS.SelectedValue.ToString());
                            idproveedor = pm.insertar_proveedor(prov);

                            //Crear Una cuenta corriente para el proveedor
                            CuentaCorriente cuenta = new CuentaCorriente();
                            cuenta.Nombre = metroTextBoxCUIT.Text;
                            cuenta.Vencimiento = int.Parse(metroComboBoxVENCIMIENTO.Text);
                            cuenta.IDProveedor = pm.devolverIDProveedorCUIT(metroTextBoxCUIT.Text);
                            pm.CrearCuentaCorriente(cuenta);

                            //insertar productor de seguro

                            if (metroCheckBoxPRODUCTOR.Checked == true)
                            {
                                pm.InsertarProductorSeguro(idproveedor, int.Parse(metroComboBoxNOMBREPRODUCTOR.SelectedValue.ToString()));
                            }





                            MessageBox.Show("El Proveedor con Cuenta Corriente fue creado Satisfactoriamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            metroCheckCUENTACORRIENTE.Checked = false;
                            metroCheckBoxPRODUCTOR.Checked = false;


                        }
                        else
                        {

                            //Insertar en la tabla proveedores
                            Proveedores prov = new Proveedores();
                            prov.Nombre = metroTextBoxNOMBRE.Text;
                            prov.Razon = metroTextBoxRAZON.Text;
                            prov.Cuit = metroTextBoxCUIT.Text;
                            prov.FechaIngreso = metroDateTimeFECHA.Value;
                            prov.IngresosBrutos = metroTextBoxIIBB.Text;
                            prov.Telefono = metroTextBoxTELEFONO.Text;
                            prov.Direccion = metroTextBoxDIRECCION.Text;
                            prov.IDProvincia =(int) metroComboBoxPROVINCIA.SelectedValue;
                            prov.IDLocalidad = int.Parse(metroComboBoxLOCALIDAD.SelectedValue.ToString());
                            prov.IDRubro = int.Parse(metroComboBoxRUBROS.SelectedValue.ToString());
                            pm.insertar_proveedor(prov);
                            MessageBox.Show("El Proveedor fue creado Satisfactoriamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        }

                    }

                    metroTextBoxNOMBRE.Clear();
                    metroTextBoxRAZON.Clear();
                    metroTextBoxCUIT.Clear();
                    metroTextBoxIIBB.Clear();
                    metroTextBoxTELEFONO.Clear();
                    metroTextBoxRAZON.Clear();
                    metroTextBoxDIRECCION.Clear();
                    metroGrid2.Refresh();
                    metroGrid2.DataSource = pm.ListarProveedores();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroTextBox3_TextChanged(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            metroGrid2.DataSource = pm.filtrarproveedores(metroTextBoxFiltroName.Text);
        }

        private void metroTextBoxFilterRazon_TextChanged(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            metroGrid2.DataSource = pm.filtrarproveedoresRazon(metroTextBoxFilterRazon.Text);
        }

        private void metroTextBoxFilterRubro_TextChanged(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            metroGrid2.DataSource = pm.filtrarPorRubros(metroTextBoxFilterRubro.Text);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ProveedorManager pm = new ProveedorManager();
            Proveedores p = new Proveedores();
            p = pm.EncontrarProveedor(metroGrid2.CurrentRow.Cells["Cuit"].Value.ToString());

            metroTextBoxNOMBRE.Text = p.Nombre;
            metroTextBoxRAZON.Text = p.Razon;
            metroTextBoxTELEFONO.Text = p.Telefono;
            metroTextBoxDIRECCION.Text = p.Direccion;
            metroTextBoxCUIT.Text = p.Cuit;
            metroTabPage1.Focus();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                ProveedorManager pm = new ProveedorManager();


                if (pm.EliminarProveedor(metroGrid2.CurrentRow.Cells["Cuit"].Value.ToString()) == 1)
                {

                    MessageBox.Show("Se ha eliminado Correctamente", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroGrid2.DataSource = pm.ListarProveedores();
                }
                else
                {
                    MessageBox.Show("Error Al eliminar el Proveedor", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    metroGrid2.DataSource = pm.ListarProveedores();
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
