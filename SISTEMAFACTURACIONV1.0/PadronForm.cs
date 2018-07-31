using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using BLayer.Controller;

namespace ErpGestion
{
    public partial class PadronForm : MetroFramework.Forms.MetroForm
    {
        ImportarPadron padron = new ImportarPadron();
        public String FileLocation { get; set; }
        public PadronForm()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void PadronForm_Load(object sender, EventArgs e)
        {
            // Start the BackgroundWorker.
            backgroundWorker1.RunWorkerAsync();

            //bindingSourcePadron.DataSource = new ImportarPadron().GetAllPadron();
            //metroGridPadron.AutoGenerateColumns = false;
            //metroGridPadron.DataSource = bindingSourcePadron;
            //metroGridPadron.AutoSize = false;

            //foreach (var item in bindingSourcePadron)
            //{
            //    ID.DataPropertyName = "ID";
            //    Regimen.DataPropertyName = "Regimen";
            //    FechaPublicacion.DataPropertyName = "FechaPublicacion";
            //    FechaDesde.DataPropertyName = "FechaDesde";
            //    FechaHasta.DataPropertyName = "FechaHasta";
            //    Cuit.DataPropertyName = "Cuit";
            //    TipoConstribuyenteInsc.DataPropertyName = "TipoContribuyenteInsc";
            //    MarcaAltaBaja.DataPropertyName = "MarcaAltaBaja";
            //    MarcaCambioAlicuota.DataPropertyName = "MarcaCambioAlicuota";
            //    Alicuota.DataPropertyName = "Alicuota";
            //    Grupo.DataPropertyName = "Grupo";



            //}


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            // Se crea el OpenFileDialog
            OpenFileDialog dialog = new OpenFileDialog();
            // Se muestra al usuario esperando una acción
            DialogResult result = dialog.ShowDialog();

           
            if (result == DialogResult.OK)
            {
                FileLocation = dialog.FileName;
            }
        }

        private void metroButtonImportar_Click(object sender, EventArgs e)
        {

            metroProgressSpinner1.Maximum = 100;
            metroProgressSpinner1.Speed = 1;
            metroProgressSpinner1.Value = 0;
            metroProgressSpinner1.Visible = true;
            backgroundWorker1.RunWorkerAsync();

       }

        private void DoWork(IProgress<int> progress)
        {
            // This method is executed in the context of
            // another thread (different than the main UI thread),
            // so use only thread-safe code
            string[] lines = File.ReadAllLines(FileLocation);

            foreach (var line in lines)
            {
                string[] fields = line.Split(';');
                // TODO: verify fields contains what you want
                // SqlCommand implements IDisposable too
                padron.ImportarPadronMethod(fields[0], padron.ConvertToDateTime(fields[1]),
                    padron.ConvertToDateTime(fields[2]), padron.ConvertToDateTime(fields[3]),
                    fields[4],fields[5],fields[6],fields[7],float.Parse(fields[8]),int.Parse(fields[9]));

                // Use progress to notify UI thread that progress has
                // changed
                if (progress != null)
                    progress.Report(line.Count() * 100 / line.Length);

            }
           

               
        }
        

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (FileLocation!=null)
            {
                var backgroundWorker = sender as BackgroundWorker;
                string[] lines = File.ReadAllLines(FileLocation);

                foreach (var line in lines)
                {
                    string[] fields = line.Split(';');
                    // TODO: verify fields contains what you want
                    // SqlCommand implements IDisposable too
                    padron.ImportarPadronMethod(fields[0], padron.ConvertToDateTime(fields[1]),
                        padron.ConvertToDateTime(fields[2]), padron.ConvertToDateTime(fields[3]),
                        fields[4], fields[5], fields[6], fields[7], float.Parse(fields[8]), int.Parse(fields[9]));

                    // Use progress to notify UI thread that progress has
                    // changed
                    backgroundWorker.ReportProgress((line.Count() * 100) / line.Length);


                }

            }
           

        }
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            metroProgressSpinner1.Value = e.ProgressPercentage;

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Importacion Completa","Sistema de Gestion",MessageBoxButtons.OK,MessageBoxIcon.Information);
           
        }
    }
}
