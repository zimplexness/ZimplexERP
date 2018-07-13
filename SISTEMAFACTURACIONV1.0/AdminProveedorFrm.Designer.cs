namespace ErpGestion
{
    partial class AdminProveedorFrm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroGridFiltrarProveedores = new MetroFramework.Controls.MetroGrid();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IIBB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Provincia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFilterRubro = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFilterRazon = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNombre = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceProveedores = new System.Windows.Forms.BindingSource(this.components);
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridFiltrarProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(857, 448);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroGridFiltrarProveedores);
            this.metroTabPage2.Controls.Add(this.metroLabel10);
            this.metroTabPage2.Controls.Add(this.metroTextBoxFilterRubro);
            this.metroTabPage2.Controls.Add(this.metroLabel15);
            this.metroTabPage2.Controls.Add(this.metroTextBoxFilterRazon);
            this.metroTabPage2.Controls.Add(this.metroLabel16);
            this.metroTabPage2.Controls.Add(this.metroTextBoxNombre);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(849, 406);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Filtrar Proveedores";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroGridFiltrarProveedores
            // 
            this.metroGridFiltrarProveedores.AllowUserToAddRows = false;
            this.metroGridFiltrarProveedores.AllowUserToResizeColumns = false;
            this.metroGridFiltrarProveedores.AllowUserToResizeRows = false;
            this.metroGridFiltrarProveedores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridFiltrarProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridFiltrarProveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridFiltrarProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridFiltrarProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridFiltrarProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridFiltrarProveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Razon,
            this.Cuit,
            this.IIBB,
            this.Direccion,
            this.Provincia,
            this.Localidad,
            this.Rubro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridFiltrarProveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridFiltrarProveedores.EnableHeadersVisualStyles = false;
            this.metroGridFiltrarProveedores.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridFiltrarProveedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridFiltrarProveedores.Location = new System.Drawing.Point(-4, 62);
            this.metroGridFiltrarProveedores.Name = "metroGridFiltrarProveedores";
            this.metroGridFiltrarProveedores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridFiltrarProveedores.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridFiltrarProveedores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridFiltrarProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridFiltrarProveedores.ShowEditingIcon = false;
            this.metroGridFiltrarProveedores.Size = new System.Drawing.Size(856, 348);
            this.metroGridFiltrarProveedores.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridFiltrarProveedores.TabIndex = 28;
            this.metroGridFiltrarProveedores.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridFiltrarProveedores.UseStyleColors = true;
            this.metroGridFiltrarProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridFiltrarProveedores_CellContentClick);
            this.metroGridFiltrarProveedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridFiltrarProveedores_CellContentDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Razon
            // 
            this.Razon.DataPropertyName = "Razon";
            this.Razon.HeaderText = "Razon Social";
            this.Razon.Name = "Razon";
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "Cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // IIBB
            // 
            this.IIBB.DataPropertyName = "IngresosBrutos";
            this.IIBB.HeaderText = "IIBB";
            this.IIBB.Name = "IIBB";
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Provincia
            // 
            this.Provincia.DataPropertyName = "Provincia";
            this.Provincia.HeaderText = "Provincia";
            this.Provincia.Name = "Provincia";
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            // 
            // Rubro
            // 
            this.Rubro.HeaderText = "Rubro";
            this.Rubro.Name = "Rubro";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(556, 11);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(60, 19);
            this.metroLabel10.TabIndex = 21;
            this.metroLabel10.Text = "RUBROS";
            // 
            // metroTextBoxFilterRubro
            // 
            // 
            // 
            // 
            this.metroTextBoxFilterRubro.CustomButton.Image = null;
            this.metroTextBoxFilterRubro.CustomButton.Location = new System.Drawing.Point(216, 1);
            this.metroTextBoxFilterRubro.CustomButton.Name = "";
            this.metroTextBoxFilterRubro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFilterRubro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFilterRubro.CustomButton.TabIndex = 1;
            this.metroTextBoxFilterRubro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFilterRubro.CustomButton.UseSelectable = true;
            this.metroTextBoxFilterRubro.CustomButton.Visible = false;
            this.metroTextBoxFilterRubro.Lines = new string[0];
            this.metroTextBoxFilterRubro.Location = new System.Drawing.Point(556, 33);
            this.metroTextBoxFilterRubro.MaxLength = 32767;
            this.metroTextBoxFilterRubro.Name = "metroTextBoxFilterRubro";
            this.metroTextBoxFilterRubro.PasswordChar = '\0';
            this.metroTextBoxFilterRubro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFilterRubro.SelectedText = "";
            this.metroTextBoxFilterRubro.SelectionLength = 0;
            this.metroTextBoxFilterRubro.SelectionStart = 0;
            this.metroTextBoxFilterRubro.ShortcutsEnabled = true;
            this.metroTextBoxFilterRubro.Size = new System.Drawing.Size(238, 23);
            this.metroTextBoxFilterRubro.TabIndex = 20;
            this.metroTextBoxFilterRubro.UseSelectable = true;
            this.metroTextBoxFilterRubro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFilterRubro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxFilterRubro.TextChanged += new System.EventHandler(this.metroTextBoxFilterRubro_TextChanged);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(279, 11);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(105, 19);
            this.metroLabel15.TabIndex = 19;
            this.metroLabel15.Text = "RAZON SOCIAL";
            // 
            // metroTextBoxFilterRazon
            // 
            // 
            // 
            // 
            this.metroTextBoxFilterRazon.CustomButton.Image = null;
            this.metroTextBoxFilterRazon.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.metroTextBoxFilterRazon.CustomButton.Name = "";
            this.metroTextBoxFilterRazon.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFilterRazon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFilterRazon.CustomButton.TabIndex = 1;
            this.metroTextBoxFilterRazon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFilterRazon.CustomButton.UseSelectable = true;
            this.metroTextBoxFilterRazon.CustomButton.Visible = false;
            this.metroTextBoxFilterRazon.Lines = new string[0];
            this.metroTextBoxFilterRazon.Location = new System.Drawing.Point(279, 33);
            this.metroTextBoxFilterRazon.MaxLength = 32767;
            this.metroTextBoxFilterRazon.Name = "metroTextBoxFilterRazon";
            this.metroTextBoxFilterRazon.PasswordChar = '\0';
            this.metroTextBoxFilterRazon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFilterRazon.SelectedText = "";
            this.metroTextBoxFilterRazon.SelectionLength = 0;
            this.metroTextBoxFilterRazon.SelectionStart = 0;
            this.metroTextBoxFilterRazon.ShortcutsEnabled = true;
            this.metroTextBoxFilterRazon.Size = new System.Drawing.Size(272, 23);
            this.metroTextBoxFilterRazon.TabIndex = 18;
            this.metroTextBoxFilterRazon.UseSelectable = true;
            this.metroTextBoxFilterRazon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFilterRazon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxFilterRazon.TextChanged += new System.EventHandler(this.metroTextBoxFilterRazon_TextChanged);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(4, 11);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(69, 19);
            this.metroLabel16.TabIndex = 17;
            this.metroLabel16.Text = "NOMBRE ";
            // 
            // metroTextBoxNombre
            // 
            // 
            // 
            // 
            this.metroTextBoxNombre.CustomButton.Image = null;
            this.metroTextBoxNombre.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.metroTextBoxNombre.CustomButton.Name = "";
            this.metroTextBoxNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre.CustomButton.Visible = false;
            this.metroTextBoxNombre.Lines = new string[0];
            this.metroTextBoxNombre.Location = new System.Drawing.Point(4, 33);
            this.metroTextBoxNombre.MaxLength = 32767;
            this.metroTextBoxNombre.Name = "metroTextBoxNombre";
            this.metroTextBoxNombre.PasswordChar = '\0';
            this.metroTextBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre.SelectedText = "";
            this.metroTextBoxNombre.SelectionLength = 0;
            this.metroTextBoxNombre.SelectionStart = 0;
            this.metroTextBoxNombre.ShortcutsEnabled = true;
            this.metroTextBoxNombre.Size = new System.Drawing.Size(272, 23);
            this.metroTextBoxNombre.TabIndex = 16;
            this.metroTextBoxNombre.UseSelectable = true;
            this.metroTextBoxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxNombre.TextChanged += new System.EventHandler(this.metroTextBox3_TextChanged);
            // 
            // AdminProveedorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 528);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "AdminProveedorFrm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.ProveedoresForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridFiltrarProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFilterRubro;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFilterRazon;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre;
        private MetroFramework.Controls.MetroGrid metroGridFiltrarProveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IIBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.BindingSource bindingSourceProveedores;
    }
}