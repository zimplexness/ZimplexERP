namespace ErpGestion
{
    partial class PadronForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.Regimen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaDesde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoConstribuyenteInsc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaAltaBaja = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaCambioAlicuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Alicuota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCantidadRegistros = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonImportar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(108, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Importar Padrón";
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(137, 60);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(44, 19);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "...";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Regimen,
            this.FechaPublicacion,
            this.FechaDesde,
            this.FechaHasta,
            this.Cuit,
            this.TipoConstribuyenteInsc,
            this.MarcaAltaBaja,
            this.MarcaCambioAlicuota,
            this.Alicuota,
            this.Grupo});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(11, 96);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(834, 282);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGrid1.TabIndex = 2;
            // 
            // Regimen
            // 
            this.Regimen.HeaderText = "Regimen";
            this.Regimen.Name = "Regimen";
            // 
            // FechaPublicacion
            // 
            this.FechaPublicacion.HeaderText = "Fecha Publicación";
            this.FechaPublicacion.Name = "FechaPublicacion";
            // 
            // FechaDesde
            // 
            this.FechaDesde.HeaderText = "Desde";
            this.FechaDesde.Name = "FechaDesde";
            // 
            // FechaHasta
            // 
            this.FechaHasta.HeaderText = "Hasta";
            this.FechaHasta.Name = "FechaHasta";
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // TipoConstribuyenteInsc
            // 
            this.TipoConstribuyenteInsc.HeaderText = "Tipo de Constribuyente";
            this.TipoConstribuyenteInsc.Name = "TipoConstribuyenteInsc";
            // 
            // MarcaAltaBaja
            // 
            this.MarcaAltaBaja.HeaderText = "Alta o Bja";
            this.MarcaAltaBaja.Name = "MarcaAltaBaja";
            // 
            // MarcaCambioAlicuota
            // 
            this.MarcaCambioAlicuota.HeaderText = "Cambio Alicuota";
            this.MarcaCambioAlicuota.Name = "MarcaCambioAlicuota";
            // 
            // Alicuota
            // 
            this.Alicuota.HeaderText = "Alícuota";
            this.Alicuota.Name = "Alicuota";
            // 
            // Grupo
            // 
            this.Grupo.HeaderText = "Grupo";
            this.Grupo.Name = "Grupo";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(586, 391);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Cantidad de Registro";
            // 
            // metroTextBoxCantidadRegistros
            // 
            // 
            // 
            // 
            this.metroTextBoxCantidadRegistros.CustomButton.Image = null;
            this.metroTextBoxCantidadRegistros.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBoxCantidadRegistros.CustomButton.Name = "";
            this.metroTextBoxCantidadRegistros.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCantidadRegistros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCantidadRegistros.CustomButton.TabIndex = 1;
            this.metroTextBoxCantidadRegistros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCantidadRegistros.CustomButton.UseSelectable = true;
            this.metroTextBoxCantidadRegistros.CustomButton.Visible = false;
            this.metroTextBoxCantidadRegistros.Enabled = false;
            this.metroTextBoxCantidadRegistros.Lines = new string[0];
            this.metroTextBoxCantidadRegistros.Location = new System.Drawing.Point(725, 391);
            this.metroTextBoxCantidadRegistros.MaxLength = 32767;
            this.metroTextBoxCantidadRegistros.Name = "metroTextBoxCantidadRegistros";
            this.metroTextBoxCantidadRegistros.PasswordChar = '\0';
            this.metroTextBoxCantidadRegistros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCantidadRegistros.SelectedText = "";
            this.metroTextBoxCantidadRegistros.SelectionLength = 0;
            this.metroTextBoxCantidadRegistros.SelectionStart = 0;
            this.metroTextBoxCantidadRegistros.ShortcutsEnabled = true;
            this.metroTextBoxCantidadRegistros.Size = new System.Drawing.Size(75, 23);
            this.metroTextBoxCantidadRegistros.TabIndex = 4;
            this.metroTextBoxCantidadRegistros.UseSelectable = true;
            this.metroTextBoxCantidadRegistros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCantidadRegistros.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButtonImportar
            // 
            this.metroButtonImportar.BackgroundImage = global::ErpGestion.Properties.Resources._1497285414_Checkmark;
            this.metroButtonImportar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonImportar.Location = new System.Drawing.Point(198, 41);
            this.metroButtonImportar.Name = "metroButtonImportar";
            this.metroButtonImportar.Size = new System.Drawing.Size(44, 38);
            this.metroButtonImportar.TabIndex = 5;
            this.metroButtonImportar.UseSelectable = true;
            this.metroButtonImportar.Click += new System.EventHandler(this.metroButtonImportar_Click);
            // 
            // PadronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 430);
            this.Controls.Add(this.metroButtonImportar);
            this.Controls.Add(this.metroTextBoxCantidadRegistros);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroGrid1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "PadronForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Padron";
            this.Load += new System.EventHandler(this.PadronForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Regimen;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaDesde;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoConstribuyenteInsc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaAltaBaja;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaCambioAlicuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Alicuota;
        private System.Windows.Forms.DataGridViewTextBoxColumn Grupo;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCantidadRegistros;
        private MetroFramework.Controls.MetroButton metroButtonImportar;
    }
}