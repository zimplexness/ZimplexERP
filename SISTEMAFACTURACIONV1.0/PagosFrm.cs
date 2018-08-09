﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLayer;
using BLayer.Controller;
using Entidades;

namespace ErpGestion
{
    public partial class PagosFrm : MetroFramework.Forms.MetroForm
    {
        public PagosFrm()
        {
            InitializeComponent();
        }

        private void PagosForm_Load(object sender, EventArgs e)
        {
            //declaracion de objeto comprobante
            ComprobantesManager comp = new ComprobantesManager();
            //llenar combobox
            metroComboBoxMedioPago.DataSource = new PagosManager().GetMediosDePago();
            metroComboBoxMedioPago.ValueMember = "MediosPago1";
            metroComboBoxMedioPago.DisplayMember = "MediosPago1";

            metroComboBoxBanco.DataSource = new PagosManager().GetDeBancos();
            metroComboBoxBanco.ValueMember = "Nombre";
            metroComboBoxBanco.DisplayMember = "Nombre";
            //autocomplete textbox con proveedores

            ProveedorManager p = new ProveedorManager();
            var name = p.listarNombreProveedores();
            AutoCompleteStringCollection sourcename = new AutoCompleteStringCollection();
            sourcename.AddRange(name.ToArray());
            metroTextBoxNOMBRE.AutoCompleteMode = AutoCompleteMode.Suggest;
            metroTextBoxNOMBRE.AutoCompleteSource = AutoCompleteSource.CustomSource;
            metroTextBoxNOMBRE.AutoCompleteCustomSource = sourcename;

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(metroComboBoxMedioPago.Text) == true || string.IsNullOrEmpty(metroTextBoxiMPORTE.Text) == true)
                {

                    MessageBox.Show("Error Debe Insertar El Medio de Pago y el Importe", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    
                        //Ingresar Medios de Pago 
                        string medio = metroComboBoxMedioPago.SelectedValue.ToString();
                        string banco = metroComboBoxBanco.SelectedValue.ToString();
                        string fechavencimiento = metroDateTimeVencimiento.Value.ToShortDateString();
                        var listmedios = new String[] { medio, fechavencimiento, metroTextBoxChque.Text, banco, metroTextBoxiMPORTE.Text };
                        metroGridMedioPAgo.Rows.Add(listmedios);
                        metroTextBoxChque.Clear();
                        metroTextBoxiMPORTE.Clear();

                    
                    metroGridMedioPAgo.AutoSize = false;

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (metroGridMedioPAgo.Rows.Count == 0)
                {
                    MessageBox.Show("Error, no tiene Medios de Pago para Eliminar", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    metroGridMedioPAgo.Rows.RemoveAt(metroGridMedioPAgo.CurrentRow.Index);
                }





            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                {
                    DataGridViewCheckBoxCell ck = row1.Cells["column7"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(ck.Value) == true)
                    {
                        total += Math.Round(Convert.ToDouble(row1.Cells["column5"].Value.ToString()), 2);
                    }
                }
                metroTextBoxTotalFact.Text = total.ToString();

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            try
            {
                //declaracion de comprobante y proveedor
                ComprobantesManager c = new ComprobantesManager();
                ProveedorManager p = new ProveedorManager();


                int idproveedor = p.DevolverIdPRoveedorporNombre(metroTextBoxNOMBRE.Text);


                var query1 = new PagosManager().ListFacturasPendientesPago(idproveedor);

                metroGridComprobantes.AutoGenerateColumns = false;
                metroGridComprobantes.DataSource = query1;
                metroGridComprobantes.AutoSize = false;

                foreach (var item in query1)
                {

                    column1.DataPropertyName = "Fecha";
                    column2.DataPropertyName = "IdComprobante";
                    column3.DataPropertyName = "Sucursal";
                    column4.DataPropertyName = "NoFactura";
                    column5.DataPropertyName = "Total";
                    column6.DataPropertyName = "IdEstado";
                    IdProveedor.DataPropertyName = "IDproveedor";
                    ImporteNeto.DataPropertyName = "ImporteNeto";
                }






            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            try
            {
                //declaracion de comprobante y proveedor

                ProveedorManager p = new ProveedorManager();


                int idprov = p.DevolverIdPRoveedorporNombre(metroTextBoxNOMBRE.Text);
                ReporteDeudaFrm ReportFrm = new ReporteDeudaFrm();
                ReportFrm.idproveedor = idprov;
                ReportFrm.ShowDialog();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroCheckBoxSelectAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void metroCheckBoxSelectAll_Click(object sender, EventArgs e)
        {

        }

        private void metroCheckBoxSelectAll_CheckStateChanged(object sender, EventArgs e)
        {
            try
            {
                if (metroCheckBoxSelectAll.Checked == true)
                {
                    foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                    {
                        DataGridViewCheckBoxCell ck = row1.Cells["column7"] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(ck.Value) == false)
                        {
                            ck.Value = true;
                        }
                    }

                }
                else
                {
                    if (metroCheckBoxSelectAll.Checked == false)
                    {
                        foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                        {
                            DataGridViewCheckBoxCell ck = row1.Cells["column7"] as DataGridViewCheckBoxCell;
                            if (Convert.ToBoolean(ck.Value) == true)
                            {
                                ck.Value = false;
                            }
                        }

                    }


                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButtonAgregarPago_Click(object sender, EventArgs e)
        {
            try
            {
                //Declaro las variable que voy a usar
                Double totalmediospago = 0;
                double totalcomprobante = 0;
                int idpago = 0;
                //Declaro los Controladores ComprobanteManager y Pagos Manager
                ComprobantesManager c = new ComprobantesManager();
                PagosManager p = new PagosManager();

                //Verifico si no estan vacios los DatagridGastospendientes y Medios de Pago
                if (metroGridComprobantes.Rows.Count == 0 || metroGridMedioPAgo.Rows.Count == 0)
                {
                    MessageBox.Show("Error, Inserte los Medios de Pago y los comprobantes a aplicarle el pago", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //Calculo el Total de Comprobantes
                    foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                    {
                        DataGridViewCheckBoxCell ck = row1.Cells["column7"] as DataGridViewCheckBoxCell;
                        if (Convert.ToBoolean(ck.Value) == true)
                        {
                            totalcomprobante += Math.Round(Convert.ToDouble(row1.Cells["column5"].Value.ToString()), 2);
                        }
                    }
                    //Calculo el Total de Medios de Pago
                    foreach (DataGridViewRow rown1 in metroGridMedioPAgo.Rows)
                    {
                        totalmediospago += Convert.ToDouble(rown1.Cells["ImportePago"].Value.ToString().Replace(".", ","));
                    }

                    if (totalcomprobante > totalmediospago)
                    {
                        //mensaje de Warning el o los el total de los comprobantes son mayores que los medios de pago

                        DialogResult dialogResult1 = MessageBox.Show("Precaucion,El total de Comprobantes es mayor que el total de medios de pago ¿Deseas Confirmarla como Pagada?", "Sistema de Gestios de Compras v1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                        if (dialogResult1 == DialogResult.Yes)
                        {
                            //aplico el pago a los comprobantes

                            //INSERTAR EN LA TABLE PAGOS
                            //INSERTO EN LA TABLA PAGOS Y OBTENGO EL ULTIMO IDPAGO INSERTADO
                            if (string.IsNullOrEmpty(metroTextBoxIDRet.Text)==true)
                            {
                                idpago = p.InsertarPagossinRetencion(metroDateTimeFechaPago.Value, totalmediospago, metroTextBoxConcepto.Text);


                            }
                            else
                            {
                                idpago = p.InsertarPagos(metroDateTimeFechaPago.Value, totalmediospago, metroTextBoxConcepto.Text, int.Parse(metroTextBoxIDRet.Text));

                            }

                            //APLICO LOS PAGOS A CADA COMPROBANTE
                            //INSERTO EN LA TABLA DETALLE DE PAGOS Y ACTUALIZO EL ESTADO DE LOS COMPROBANTES A 1
                            DialogResult dialogResult = MessageBox.Show("Pago Realizado, Deseas Confirmarla como Pagada", "Sistema de Gestios de Compras v1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dialogResult == DialogResult.Yes)
                            {
                                //si se aplica la cancelacion del comprobante se actualiza el estado del comprobante
                                foreach (DataGridViewRow row2 in metroGridComprobantes.Rows)
                                {
                                    DataGridViewCheckBoxCell ck3 = row2.Cells["Column7"] as DataGridViewCheckBoxCell;
                                    if (Convert.ToBoolean(ck3.Value) == true)
                                    {
                                        int idProveedor = new ProveedorManager().DevolverIdPRoveedorporNombre(metroTextBoxNOMBRE.Text);



                                        p.InsertarDetallePago(idpago, c.DevolverIDporNoFactura2(row2.Cells["column3"].Value.ToString(), row2.Cells["column4"].Value.ToString(),idProveedor));

                                        //Actualizar EStado de Comprobante
                                        c.ActualizarEstado(c.DevolverIDporNoFactura2(row2.Cells["column3"].Value.ToString(), row2.Cells["column4"].Value.ToString(),idProveedor), 1);

                                    }
                                }



                            }


                            //INSERTO EN LA TABLA MEDIOS DE PAGO
                            foreach (DataGridViewRow row3 in metroGridMedioPAgo.Rows)
                            {
                                p.InsertarMediosPago(p.DevolverMedioPago(row3.Cells["MedioPago"].Value.ToString()), Convert.ToDateTime(row3.Cells["FechaVencimiento"].Value), row3.Cells["ChequeTransferencia"].Value.ToString(), p.DevolverBanco(row3.Cells["Banco"].Value.ToString()), Convert.ToDouble(row3.Cells["ImportePago"].Value.ToString().Replace(".", ",")), idpago);

                            }

                            //Declaro la instancia del ReporteViwer y lo llamo
                            ReportesForm reporte = new ReportesForm();
                            reporte.idpagoprop = idpago;
                            reporte.idpagoprop = idpago;
                            reporte.ShowDialog();

                            //BORRO TODOS LOS DATOS DEL DATA GRID Y DE LOS TEXTBOXES
                            metroGridMedioPAgo.Rows.Clear();
                            metroGridComprobantes.DataSource = "";
                            metroTextBoxConcepto.Clear();
                            metroTextBoxChque.Clear();
                            metroTextBoxiMPORTE.Clear();




                        }
                        //Si no se cancela el comprobante no se actualiza el estado del comprobante
                        else if (dialogResult1 == DialogResult.No)
                        {
                            MessageBox.Show("Vuelva a Intentarlo", "Sistema de Gestion de Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }
                    else
                    {
                        if (totalmediospago >= totalcomprobante)
                        {
                            //INSERTAR EN LA TABLE PAGOS
                            //INSERTO EN LA TABLA PAGOS Y OBTENGO EL ULTIMO IDPAGO INSERTADO
                            if (string.IsNullOrEmpty(metroTextBoxIDRet.Text))
                            {
                                idpago = p.InsertarPagossinRetencion(metroDateTimeFechaPago.Value, totalmediospago, metroTextBoxConcepto.Text);


                            }
                            else
                            {
                                idpago = p.InsertarPagos(metroDateTimeFechaPago.Value, totalmediospago, metroTextBoxConcepto.Text, int.Parse(metroTextBoxIDRet.Text));

                            }

                            //APLICO LOS PAGOS A CADA COMPROBANTE
                            //INSERTO EN LA TABLA DETALLE DE PAGOS Y ACTUALIZO EL ESTADO DE LOS COMPROBANTES A 1
                            DialogResult dialogResult = MessageBox.Show("Pago Realizado, Deseas Confirmarla como Pagada", "Sistema de Gestios de Compras v1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dialogResult == DialogResult.Yes)
                            {
                                //si se aplica la cancelacion del comprobante se actualiza el estado del comprobante
                                foreach (DataGridViewRow row2 in metroGridComprobantes.Rows)
                                {
                                    DataGridViewCheckBoxCell ck3 = row2.Cells["column7"] as DataGridViewCheckBoxCell;
                                    if (Convert.ToBoolean(ck3.Value) == true)
                                    {
                                        p.InsertarDetallePago(idpago, c.DevolverIDporNoFactura(row2.Cells["column3"].Value.ToString(), row2.Cells["column4"].Value.ToString(), int.Parse(row2.Cells["IdProveedor"].Value.ToString())));

                                        //Actualizar EStado de Comprobante
                                        c.ActualizarEstado(c.DevolverIDporNoFactura(row2.Cells["column3"].Value.ToString(), row2.Cells["column4"].Value.ToString(), int.Parse(row2.Cells["IdProveedor"].Value.ToString())), 1);

                                    }
                                }



                            }
                            //Si no se cancela el comprobante no se actualiza el estado del comprobante
                            else if (dialogResult == DialogResult.No)
                            {
                                foreach (DataGridViewRow row2 in metroGridComprobantes.Rows)
                                {
                                    DataGridViewCheckBoxCell ck3 = row2.Cells["Column7"] as DataGridViewCheckBoxCell;
                                    if (Convert.ToBoolean(ck3.Value) == true)
                                    {
                                        p.InsertarDetallePago(idpago, c.DevolverIDporNoFactura(row2.Cells["column3"].Value.ToString(), row2.Cells["column4"].Value.ToString(), int.Parse(row2.Cells["IdProveedor"].Value.ToString())));
                                        //Actualizar EStado de Comprobante

                                        //c.ActualizarEstado(c.DevolverIDporNoFactura(row2.Cells["Column2"].Value.ToString(), row2.Cells["Column3"].Value.ToString()), 1);

                                    }
                                }
                            }

                            //INSERTO EN LA TABLA MEDIOS DE PAGO
                            foreach (DataGridViewRow row3 in metroGridMedioPAgo.Rows)
                            {
                                p.InsertarMediosPago(p.DevolverMedioPago(row3.Cells["MedioPago"].Value.ToString()), Convert.ToDateTime(row3.Cells["FechaVencimiento"].Value), row3.Cells["ChequeTransferencia"].Value.ToString(), p.DevolverBanco(row3.Cells["Banco"].Value.ToString()), Convert.ToDouble(row3.Cells["ImportePago"].Value.ToString().Replace(".", ",")), idpago);

                            }

                            //Declaro la instancia del ReporteViwer y lo llamo
                            ReportesForm reporte = new ReportesForm();
                            reporte.idpagoprop = idpago;
                            reporte.idpagoprop = idpago;
                            reporte.ShowDialog();

                            //BORRO TODOS LOS DATOS DEL DATA GRID Y DE LOS TEXTBOXES
                            metroGridMedioPAgo.Rows.Clear();
                            metroGridComprobantes.DataSource = "";
                            metroTextBoxConcepto.Clear();
                            metroTextBoxChque.Clear();
                            metroTextBoxiMPORTE.Clear();




                        }
                    }




                }




            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButtonCancelarPago_Click(object sender, EventArgs e)
        {

        }

        private void metroGridComprobantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void metroButton6_Click(object sender, EventArgs e)
        {
            metroGridPagosProveedores.DataSource = new PagosManager().ReportePagos(metroDateTimeInicio.Value,metroDateTimeFin.Value);
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBoxTotalFact_Click(object sender, EventArgs e)
        {

        }

        private void metroGridComprobantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void metroGridComprobantes_SelectionChanged(object sender, EventArgs e)
        {
          
        }

        private void metroGridComprobantes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
          
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton7_Click(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                Retenciones retencion = new Retenciones();
                foreach (DataGridViewRow row1 in metroGridComprobantes.Rows)
                {
                    DataGridViewCheckBoxCell ck = row1.Cells["column7"] as DataGridViewCheckBoxCell;
                    if (Convert.ToBoolean(ck.Value) == true)
                    {
                        total += Math.Round(Convert.ToDouble(row1.Cells["column5"].Value.ToString()), 2);
                    }
                }

                if (metroGridComprobantes.Rows.Count >= 1 && total > 2000)
                   retencion = new ImportarPadron().CalcularRetenciones(metroTextBoxNOMBRE.Text,float.Parse(total.ToString()));
                if (retencion!=null)
                {
                    double totalPAgar = total - Convert.ToDouble(retencion.Importe);
                    metroTextBoxIDRet.Text = retencion.IDRetencion.ToString();
                    metroTextBoxALi.Text = Math.Round((double)retencion.Alicuota, 2).ToString();
                    metroTextBoxImporteRet.Text = Math.Round((double)retencion.Importe, 2).ToString();
                    metroTextBoxTotalPagar.Text = Math.Round(totalPAgar, 2).ToString();
                    metroTextBoxiMPORTE.Text = Math.Round(totalPAgar, 2).ToString();
                    metroTextBoxTotalFact.Text = total.ToString();

                }
                else{
                    if (retencion==null)
                    
                   
                    metroTextBoxIDRet.Clear();
                    metroTextBoxALi.Clear();
                    metroTextBoxImporteRet.Clear();
                    metroTextBoxTotalPagar.Clear();
                    metroTextBoxiMPORTE.Clear();
                    metroTextBoxTotalFact.Clear();
                }
                
               }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(metroTextBoxIDRet.Text) == true)
                MessageBox.Show("Error, No tienes Retencion para Eliminar","Sistema de Gestion",MessageBoxButtons.OK,MessageBoxIcon.Information);
            new ImportarPadron().DeleteRetencion(int.Parse(metroTextBoxIDRet.Text));
            metroTextBoxIDRet.Clear();
            metroTextBoxALi.Clear();
            metroTextBoxImporteRet.Clear();
        }
    }
}
