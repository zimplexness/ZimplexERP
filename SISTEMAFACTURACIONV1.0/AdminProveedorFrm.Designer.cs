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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminProveedorFrm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingSourceProveedores = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroGridFiltrarProveedores = new MetroFramework.Controls.MetroGrid();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxCuit = new MetroFramework.Controls.MetroTextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridFiltrarProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1018, 520);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.metroTextBoxCuit);
            this.metroTabPage2.Controls.Add(this.bindingNavigator1);
            this.metroTabPage2.Controls.Add(this.linkLabel1);
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
            this.metroTabPage2.Size = new System.Drawing.Size(1010, 478);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Filtrar Proveedores";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.bindingSourceProveedores;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 453);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(1010, 25);
            this.bindingNavigator1.TabIndex = 30;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ErpGestion.Properties.Resources._1497285708_Cancel;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(3, 16);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(116, 13);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NUEVO PROVEEDOR";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // metroGridFiltrarProveedores
            // 
            this.metroGridFiltrarProveedores.AllowUserToAddRows = false;
            this.metroGridFiltrarProveedores.AllowUserToResizeColumns = false;
            this.metroGridFiltrarProveedores.AllowUserToResizeRows = false;
            this.metroGridFiltrarProveedores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.Select,
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
            this.metroGridFiltrarProveedores.Location = new System.Drawing.Point(-3, 91);
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
            this.metroGridFiltrarProveedores.Size = new System.Drawing.Size(1017, 348);
            this.metroGridFiltrarProveedores.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridFiltrarProveedores.TabIndex = 28;
            this.metroGridFiltrarProveedores.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridFiltrarProveedores.UseStyleColors = true;
            this.metroGridFiltrarProveedores.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridFiltrarProveedores_CellContentClick);
            this.metroGridFiltrarProveedores.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridFiltrarProveedores_CellContentDoubleClick);
            // 
            // Select
            // 
            this.Select.HeaderText = "Seleccionar";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 250;
            // 
            // Razon
            // 
            this.Razon.DataPropertyName = "Razon";
            this.Razon.HeaderText = "Razon Social";
            this.Razon.Name = "Razon";
            this.Razon.Width = 250;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "Cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            this.Cuit.Width = 80;
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
            this.Direccion.Width = 250;
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
            this.Rubro.Width = 200;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(694, 40);
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
            this.metroTextBoxFilterRubro.Location = new System.Drawing.Point(694, 62);
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
            this.metroLabel15.Location = new System.Drawing.Point(278, 40);
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
            this.metroTextBoxFilterRazon.Location = new System.Drawing.Point(278, 62);
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
            this.metroLabel16.Location = new System.Drawing.Point(3, 40);
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
            this.metroTextBoxNombre.Location = new System.Drawing.Point(3, 62);
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
            this.metroTextBoxNombre.TextChanged += new System.EventHandler(this.metroTextBoxNombre_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(553, 40);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(37, 19);
            this.metroLabel1.TabIndex = 32;
            this.metroLabel1.Text = "CUIT";
            // 
            // metroTextBoxCuit
            // 
            // 
            // 
            // 
            this.metroTextBoxCuit.CustomButton.Image = null;
            this.metroTextBoxCuit.CustomButton.Location = new System.Drawing.Point(113, 1);
            this.metroTextBoxCuit.CustomButton.Name = "";
            this.metroTextBoxCuit.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxCuit.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxCuit.CustomButton.TabIndex = 1;
            this.metroTextBoxCuit.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxCuit.CustomButton.UseSelectable = true;
            this.metroTextBoxCuit.CustomButton.Visible = false;
            this.metroTextBoxCuit.Lines = new string[0];
            this.metroTextBoxCuit.Location = new System.Drawing.Point(553, 62);
            this.metroTextBoxCuit.MaxLength = 32767;
            this.metroTextBoxCuit.Name = "metroTextBoxCuit";
            this.metroTextBoxCuit.PasswordChar = '\0';
            this.metroTextBoxCuit.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxCuit.SelectedText = "";
            this.metroTextBoxCuit.SelectionLength = 0;
            this.metroTextBoxCuit.SelectionStart = 0;
            this.metroTextBoxCuit.ShortcutsEnabled = true;
            this.metroTextBoxCuit.Size = new System.Drawing.Size(135, 23);
            this.metroTextBoxCuit.TabIndex = 31;
            this.metroTextBoxCuit.UseSelectable = true;
            this.metroTextBoxCuit.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxCuit.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxCuit.TextChanged += new System.EventHandler(this.metroTextBoxCuit_TextChanged);
            // 
            // AdminProveedorFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 600);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "AdminProveedorFrm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Proveedores";
            this.Load += new System.EventHandler(this.ProveedoresForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridFiltrarProveedores)).EndInit();
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
        private System.Windows.Forms.BindingSource bindingSourceProveedores;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn IIBB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Provincia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubro;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxCuit;
    }
}