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
    public partial class EmpleadoForm : MetroFramework.Forms.MetroForm
    {
        public EmpleadoForm()
        {
            InitializeComponent();
        }

        private void EmpleadoForm_Load(object sender, EventArgs e)
        {
            //llenar combobox

           

            metroComboBoxNacionalidades.DataSource = new NacionalidadesController().ListarNacionalidades();
            metroComboBoxNacionalidades.DisplayMember = "Nacionalidad";
            metroComboBoxNacionalidades.ValueMember = "IdNacionalidad";


            metroComboBoxLocalidades.DataSource = new Provincia_localidad().ListarLocalidades();
            metroComboBoxLocalidades.DisplayMember = "Localidades1";
            metroComboBoxLocalidades.ValueMember = "IdLocalidad";

            metroComboBoxEstadoCivil.DataSource = new EstadoCivilController().ListarEstadoCivil();
            metroComboBoxEstadoCivil.DisplayMember = "EstadoCivil1";
            metroComboBoxEstadoCivil.ValueMember = "IDEstadoCivil";

            metroComboBoxObraSocial.DataSource = new ObraSocialController().ListarObraSocial();
            metroComboBoxObraSocial.DisplayMember = "Descripcion";
            metroComboBoxObraSocial.ValueMember = "idObraSocial";

            metroComboBoxSexo.DataSource = new SexosController().ListarSexos();
            metroComboBoxSexo.DisplayMember = "Sexo";
            metroComboBoxSexo.ValueMember = "IDSexo";

            EmpleadosManager objectempleado = new EmpleadosManager();

            metroComboBoxDepartamento.DataSource = objectempleado.ListarDepartamentos();
            metroComboBoxDepartamento.DisplayMember = "Descripcion";
            metroComboBoxDepartamento.ValueMember = "IdDepartamento";



            metroComboBoxSindicato.DataSource = objectempleado.ListarSindicatos();
            metroComboBoxSindicato.DisplayMember = "Descripcion";
            metroComboBoxSindicato.ValueMember = "idSindicato";

            metroComboBoxEspecialidad.DataSource = objectempleado.ListarEspecialidades();
            metroComboBoxEspecialidad.DisplayMember = "Descripcion";
            metroComboBoxEspecialidad.ValueMember = "idEspecialidad";

            metroComboBoxCategoria.DataSource = objectempleado.ListarCategoriaEmpleado();
            metroComboBoxCategoria.DisplayMember = "Descripcion";
            metroComboBoxCategoria.ValueMember = "idCategoriaEmpleado";

            metroComboBoxZona.DataSource = new ZonasController().ListarZonas();
            metroComboBoxZona.DisplayMember = "Zonas1";
            metroComboBoxZona.ValueMember = "idZona";

            metroComboBoxAfectado.DataSource = new Afectado_a_Cliente().ListarEmpresasClientes();
            metroComboBoxAfectado.DisplayMember = "Nombre";
            metroComboBoxAfectado.ValueMember = "IDEmpresaCliente";

            //Configurar el datanavigator y databinding source

        

            
            bindingSourceEmpleado.DataSource = new EmpleadosManager().ListarEmpleadosActivos();

            bindingSourceHistorialEmpleados.DataSource = new EmpleadosManager().HistorialEmpleados();
            metroGridHistorial.DataSource = bindingSourceHistorialEmpleados;

            metroTextBoxNombre.DataBindings.Add("Text", bindingSourceEmpleado, "Nombres", true);
            PropertyDescriptor Chkactivo = bindingSourceEmpleado.GetItemProperties(null)["Activo"];





            pictureBox2.DataBindings.Add("Image", bindingSourceEmpleado, "ImagenPerfil", true);

            metroCheckBoxActivo.Checked= (bool)Chkactivo.GetValue(bindingSourceEmpleado.Current);
            metroTextBoxLegajo.DataBindings.Add("Text",bindingSourceEmpleado,"NoLegajo",true);
            metroTextBoxApellidos.DataBindings.Add("Text", bindingSourceEmpleado, "Apellidos", true);
            metroTextBoxDNI.DataBindings.Add("Text", bindingSourceEmpleado, "DNI", true);
            metroTextBoxCUIL.DataBindings.Add("Text", bindingSourceEmpleado, "CUIL", true);
            maskedTextBoxFechaAlta.DataBindings.Add("Text", bindingSourceEmpleado, "FechaIngreso", true);
            maskedTextBoxFechaNacimiento.DataBindings.Add("Text", bindingSourceEmpleado, "FechaNacimiento", true);
            metroComboBoxSexo.DataBindings.Add("Text", bindingSourceEmpleado, "Sexo", true);
            metroComboBoxEstadoCivil.DataBindings.Add("Text", bindingSourceEmpleado, "EstadoCivil", true);
            metroTextBoxDireccion.DataBindings.Add("Text", bindingSourceEmpleado, "Domicilio", true);
            metroComboBoxNacionalidades.DataBindings.Add("Text", bindingSourceEmpleado, "Nacionalidad", true);

            metroTextBoxTelefono.DataBindings.Add("Text", bindingSourceEmpleado, "Telefono", true);
            metroTextBoxCelular.DataBindings.Add("Text", bindingSourceEmpleado, "Celular", true);
            metroComboBoxSindicato.DataBindings.Add("Text", bindingSourceEmpleado, "Sindicato", true);
            metroComboBoxObraSocial.DataBindings.Add("Text", bindingSourceEmpleado, "Obrasocial", true);
            metroComboBoxCategoria.DataBindings.Add("Text", bindingSourceEmpleado, "CategoriaEmpleado", true);
            metroTextBoxHijos.DataBindings.Add("Text", bindingSourceEmpleado, "Hijos", true);
            metroTextBoxCuentaFD.DataBindings.Add("Text", bindingSourceEmpleado, "NoCuentaFondoDesempleo", true);
            metroComboBoxLocalidades.DataBindings.Add("Text",bindingSourceEmpleado, "Localidades", true);
            metroComboBoxZona.DataBindings.Add("Text",bindingSourceEmpleado,"Zonas",true);
            metroComboBoxEspecialidad.DataBindings.Add("Text",bindingSourceEmpleado,"Especialidad",true);
            metroComboBoxDepartamento.DataBindings.Add("Text", bindingSourceEmpleado, "Departamento", true);

            PropertyDescriptor Chkieric = bindingSourceEmpleado.GetItemProperties(null)["Ieric"];

            metroCheckIEric.Checked = (bool)Chkieric.GetValue(bindingSourceEmpleado.Current);

            PropertyDescriptor Chkregistro = bindingSourceEmpleado.GetItemProperties(null)["RegistroConducir"];

            metroRegistro.Checked = (bool)Chkregistro.GetValue(bindingSourceEmpleado.Current);
           
            metroTextBoxComentario.DataBindings.Add("Text", bindingSourceEmpleado, "Comentario", true);
            metroComboBoxAfectado.DataBindings.Add("Text",bindingSourceEmpleado,"EmpresaCliente",true);
            CodigoPtextbox.DataBindings.Add("Text",bindingSourceEmpleado,"CodigoPostal",true);

            //llenar datagrid empleados
            //List<Model.ListaEmpleadosActivos_Result> EmpleadosActivos =new EmpleadosManager().ListarEmpleadosActivos(); 

            metroGridEmpleadosActivos.AutoGenerateColumns = false;
            metroGridEmpleadosActivos.DataSource = bindingSourceEmpleado;
            metroGridEmpleadosActivos.AutoSize = false;

            foreach (var item in bindingSourceEmpleado)
            {

                NoLegajo.DataPropertyName = "Nolegajo";
               
                Nombres.DataPropertyName = "Nombres";
                Apellidos.DataPropertyName = "Apellidos";
                DNI.DataPropertyName = "DNI";
                CUIL.DataPropertyName = "CUIL";
                FechaIngreso.DataPropertyName = "FechaIngreso";
                Sexo.DataPropertyName = "Sexo";
                Domicilio.DataPropertyName = "Domicilio";
                Localidad.DataPropertyName = "Localidades";
                Nacionalidad.DataPropertyName = "Nacionalidad";
                


            }


            //llenar datagrid nomina telecentro
            bindingSourceNominaTelecentro.DataSource = new EmpleadosManager().NominaTelecentro();
            metroGridNominaTelecentro.DataSource = bindingSourceNominaTelecentro;

            //llenar datagrid nomina cablevision
            bindingSourceCablevision.DataSource = new EmpleadosManager().NominaCablevision();




        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
           





           
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            metroTextBoxNombre.Clear();
            metroTextBoxApellidos.Clear();
            metroTextBoxDNI.Clear();
            metroTextBoxCUIL.Clear();
            metroTextBoxLegajo.Clear();
            metroCheckBoxActivo.Checked = true;
            metroCheckIEric.Checked = false;
            metroTextBoxHijos.Text ="0";
            metroTextBoxTelefono.Clear();
            metroTextBoxCelular.Clear();
            metroRegistro.Checked = false;
            metroCheckBoxLIBRETA.Checked = false;
            metroTextBoxCuentaFD.Clear();
            metroTextBoxComentario.Clear();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            //Metodo Insertar Empleado

            try
            {
                EmpleadosManager empleado = new EmpleadosManager();
                if (string.IsNullOrEmpty(metroTextBoxNombre.Text) || string.IsNullOrEmpty(metroTextBoxApellidos.Text) || string.IsNullOrEmpty(metroTextBoxDNI.Text)
                    || string.IsNullOrEmpty(metroTextBoxCUIL.Text)
                    )
                {
                    MessageBox.Show("Error, Debe Insertar los Datos Principales, NOMBRE, APELLIDOS, DNI, CUIL", "Sistema de Gestion", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                //validar si existe el empleado
                if (empleado.validarEmpleado(int.Parse(metroTextBoxLegajo.Text))==1)
                {
                    DialogResult dialogresult = MessageBox.Show("Ya existe el empleado, Desea Actualizarlo ?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                    //si existe y el usuario quiere actualizarlo se actualiza
                    if (dialogresult == DialogResult.Yes)
                    {

                        int idemp = new EmpleadosManager().DevolverIDEmpleado(int.Parse(   metroTextBoxLegajo.Text));
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        // Se guarda la imagen en el buffer
                        pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        // Se extraen los bytes del buffer para asignarlos como valor para el 
                        // parámetro.
                        //solicitud.ImagenPerfil = ms.GetBuffer();
                       
                        empleado.UpdateEmpleado(idemp,ms.GetBuffer(), metroCheckBoxActivo.Checked,int.Parse( metroTextBoxLegajo.Text),metroTextBoxNombre.Text, metroTextBoxApellidos.Text, metroTextBoxDNI.Text, metroTextBoxCUIL.Text,
                            DateTime.Parse( maskedTextBoxFechaNacimiento.Text), metroTextBoxTelefono.Text, metroTextBoxCelular.Text, metroTextBoxDireccion.Text,DateTime.Parse( maskedTextBoxFechaAlta.Text),
                            int.Parse(metroTextBoxHijos.Text),(int)metroComboBoxDepartamento.SelectedValue, (int)metroComboBoxObraSocial.SelectedValue, (int)metroComboBoxSindicato.SelectedValue,
                            (int)metroComboBoxEspecialidad.SelectedValue, (int)metroComboBoxCategoria.SelectedValue,metroTextBoxCuentaFD.Text,metroCheckIEric.Checked,
                            metroTextBoxComentario.Text, (int)metroComboBoxLocalidades.SelectedValue, (int)metroComboBoxEstadoCivil.SelectedValue, (int)metroComboBoxNacionalidades.SelectedValue,metroCheckBoxLIBRETA.Checked,
                            (int)metroComboBoxSexo.SelectedValue,metroRegistro.Checked,(int)metroComboBoxAfectado.SelectedValue,(int)metroComboBoxZona.SelectedValue);
                        bindingSourceEmpleado.DataSource = new EmpleadosManager().ListarEmpleadosActivos();
                        bindingSourceEmpleado.ResetBindings(true);
                        MessageBox.Show("Se ha Actualizado con Exito el empleado","Sistema de Gestion Integral",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                

                }
                //Crear el empleado ya que no existe en la base de datos

                if (empleado.validarEmpleado(int.Parse(metroTextBoxLegajo.Text)) == 0)
                {

                    DialogResult dialogresult = MessageBox.Show("El empleado no Exite, Desea darle el Alta en el Sistema?", "Sistema de Gestion", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);


                    //si existe y el usuario quiere actualizarlo se actualiza
                    if (dialogresult == DialogResult.Yes)
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        // Se guarda la imagen en el buffer
                        pictureBox2.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        // Se extraen los bytes del buffer para asignarlos como valor para el 
                        // parámetro.
                        //solicitud.ImagenPerfil = ms.GetBuffer();

                            empleado.InsertarEmpleado(ms.GetBuffer(), metroCheckBoxActivo.Checked,int.Parse( metroTextBoxLegajo.Text), metroTextBoxNombre.Text, metroTextBoxApellidos.Text, metroTextBoxDNI.Text, metroTextBoxCUIL.Text,
                            DateTime.Parse(maskedTextBoxFechaNacimiento.Text), metroTextBoxTelefono.Text, metroTextBoxCelular.Text, metroTextBoxDireccion.Text, DateTime.Parse(maskedTextBoxFechaAlta.Text),
                            int.Parse(metroTextBoxHijos.Text), (int)metroComboBoxDepartamento.SelectedValue, (int)metroComboBoxObraSocial.SelectedValue, (int)metroComboBoxSindicato.SelectedValue,
                            (int)metroComboBoxEspecialidad.SelectedValue, (int)metroComboBoxCategoria.SelectedValue, metroTextBoxCuentaFD.Text, metroCheckIEric.Checked, 
                            metroTextBoxComentario.Text, (int)metroComboBoxLocalidades.SelectedValue, (int)metroComboBoxEstadoCivil.SelectedValue, (int)metroComboBoxNacionalidades.SelectedValue, metroCheckBoxLIBRETA.Checked,
                            (int)metroComboBoxSexo.SelectedValue, metroRegistro.Checked,(int)metroComboBoxAfectado.SelectedValue,(int)metroComboBoxZona.SelectedValue);
                        bindingSourceEmpleado.DataSource = new EmpleadosManager().ListarEmpleadosActivos();
                        bindingSourceEmpleado.ResetBindings(true);
                        MessageBox.Show("Se Inserto el Empleado con Exito", "Sistema de Gestion Integral", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }






                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
           

         


        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void metroTextBox5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadosManager empleado = new EmpleadosManager();
                DialogResult dialogresult = MessageBox.Show("Realmente deseas eliminar el empleado","Sistema de Gestion Integral",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                if (dialogresult==DialogResult.Yes)
                {
                    

                    empleado.EliminarEmpleado(metroTextBoxDNI.Text,metroTextBoxCUIL.Text);
                    MessageBox.Show("Se ha Eliminado con Exito","Sistema de Gestion Integral",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    bindingSourceEmpleado.DataSource = new EmpleadosManager().ListarEmpleadosActivos();
                    bindingSourceEmpleado.ResetBindings(true);
                }
                else
                {

                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)
            // la mostramos en el PictureBox de la inferfaz
            if (result == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void metroTabControl1_Selected(object sender, TabControlEventArgs e)
        {
           
        }

        private void metroGridEmpleadosActivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

            try
            {



                NominaTelecentroForm nominatlcfrm = new NominaTelecentroForm();
                nominatlcfrm.FechaFin = metroDateTimeFechafin.Value;
                


                nominatlcfrm.ShowDialog();



            }
            catch (Exception)
            {

                throw;
            }






            
            
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            filterLegajo.Clear();
        }

        private void toolStripTextBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               


                bindingSourceEmpleado.DataSource = new EmpleadosManager().FiltroNolegajo(int.Parse(filterLegajo.Text));
                //bindingSourceEmpleado.DataSource=
                

            }
        }

        private void FiltroApellido_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {



                bindingSourceEmpleado.DataSource = new EmpleadosManager().FiltroApellidos(FiltroApellido.Text);
                //bindingSourceEmpleado.DataSource=


            }
        }

        private void FiltroApellido_Click(object sender, EventArgs e)
        {
            FiltroApellido.Text = "";
        }

        private void FiltroDNI_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {



                bindingSourceEmpleado.DataSource = new EmpleadosManager().FiltroDNI(FiltroDNI.Text);
              //bindingSourceEmpleado.DataSource=


            }
        }

        private void FiltroDNI_Click(object sender, EventArgs e)
        {
            FiltroDNI.Text = "";
        }

        private void filterLegajo_TextChanged(object sender, EventArgs e)
        {
            //bindingSourceEmpleado.DataSource = new EmpleadosManager().FiltroNolegajo(int.Parse(filterLegajo.Text));

        }

        private void FiltroDNI_TextChanged(object sender, EventArgs e)
        {
            bindingSourceEmpleado.DataSource = new EmpleadosManager().FiltroDNI(FiltroDNI.Text);
        }

        private void FiltroApellido_TextChanged(object sender, EventArgs e)
        {
            bindingSourceEmpleado.DataSource = new EmpleadosManager().FiltroApellidos(FiltroApellido.Text);
           //bindingSourceEmpleado.DataSource=
        }

        private void metroButtonBuscar_Click(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void toolStripButton11_Click_1(object sender, EventArgs e)
        {
            try
            {
                EmpleadosManager ObjectE = new EmpleadosManager();
                metroGridEmpleadosActivos.DataSource = ObjectE.FiltroFechadeAlta(metroDateTimeInicio.Value, metroDateTimeFin.Value);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripTextBoxFiltroApellido_TextChanged(object sender, EventArgs e)
        {
            bindingSourceEmpleado.DataSource = new EmpleadosManager().FiltroApellidos(toolStripTextBoxFiltroApellido.Text);

        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(metroTextBoxMotivoBaja.Text))
                {
                    MessageBox.Show("Error, debe insertar la fecha de baja y el motivo","Sistema de Gestion Integral",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

                else
                {
                   DialogResult dialogresult= MessageBox.Show("Quieres darle de Baja a "+metroTextBoxNombre.Text+"?", "Sistema de Gestion Integral", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (dialogresult==DialogResult.OK)
                    {
                        EmpleadosManager EmpObject = new EmpleadosManager();
                        EmpObject.DarBaja(int.Parse(metroTextBoxLegajo.Text),metroDateTimeFechaBaja.Value,metroTextBoxMotivoBaja.Text);
                        MessageBox.Show("Baja Exitosa","Sistema de Gestion Integral",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        bindingSourceEmpleado.DataSource = new EmpleadosManager().ListarEmpleadosActivos();
                        bindingSourceEmpleado.ResetBindings(true);
                        metroTextBoxMotivoBaja.Clear();
                    }



                }





            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripButton16_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadosManager ObjectE = new EmpleadosManager();
                metroGridEmpleadosActivos.DataSource = ObjectE.FiltroFechadeAlta(metroDateTimeInicio.Value, metroDateTimeFin.Value);


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void toolStripTextBox3_TextChanged(object sender, EventArgs e)
        {
            bindingSourceHistorialEmpleados.DataSource = new EmpleadosManager().FiltroApellidosHistorial(toolStripTextBoxFilterApellidosH.Text);

        }

        private void metroTabPage6_Click(object sender, EventArgs e)
        {

        }

        private void metroGridNominaTelecentro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
