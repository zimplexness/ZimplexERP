namespace ErpGestion
{
    partial class AdminCuentaCorrienteForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroGridCuenta = new MetroFramework.Controls.MetroGrid();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Razon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxFiltro = new MetroFramework.Controls.MetroTextBox();
            this.bindingSourceCuenta = new System.Windows.Forms.BindingSource(this.components);
            this.metroButtonAgregarPago = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCuenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(760, 370);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroButtonAgregarPago);
            this.metroTabPage2.Controls.Add(this.linkLabel1);
            this.metroTabPage2.Controls.Add(this.metroGridCuenta);
            this.metroTabPage2.Controls.Add(this.metroLabel16);
            this.metroTabPage2.Controls.Add(this.metroTextBoxFiltro);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(752, 328);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Cuentas Corrientes";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(281, 32);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(157, 13);
            this.linkLabel1.TabIndex = 29;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NUEVA CUENTA CORRIENTE";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // metroGridCuenta
            // 
            this.metroGridCuenta.AllowUserToAddRows = false;
            this.metroGridCuenta.AllowUserToResizeColumns = false;
            this.metroGridCuenta.AllowUserToResizeRows = false;
            this.metroGridCuenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCuenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridCuenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridCuenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCuenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridCuenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cuit,
            this.Razon,
            this.NumeroCuenta,
            this.Vencimiento,
            this.Comentario});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridCuenta.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridCuenta.EnableHeadersVisualStyles = false;
            this.metroGridCuenta.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridCuenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridCuenta.Location = new System.Drawing.Point(3, 51);
            this.metroGridCuenta.Name = "metroGridCuenta";
            this.metroGridCuenta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridCuenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridCuenta.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridCuenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridCuenta.ShowEditingIcon = false;
            this.metroGridCuenta.Size = new System.Drawing.Size(746, 274);
            this.metroGridCuenta.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridCuenta.TabIndex = 28;
            this.metroGridCuenta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridCuenta.UseStyleColors = true;
            this.metroGridCuenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridFiltrarProveedores_CellContentClick);
            this.metroGridCuenta.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGridCuenta_CellContentDoubleClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Proveedor";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 150;
            // 
            // Cuit
            // 
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.Name = "Cuit";
            // 
            // Razon
            // 
            this.Razon.HeaderText = "Razon Social";
            this.Razon.Name = "Razon";
            this.Razon.Width = 150;
            // 
            // NumeroCuenta
            // 
            this.NumeroCuenta.HeaderText = "Número de Cuenta";
            this.NumeroCuenta.Name = "NumeroCuenta";
            // 
            // Vencimiento
            // 
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.Width = 70;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = "Comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.Width = 300;
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(3, 0);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(69, 19);
            this.metroLabel16.TabIndex = 17;
            this.metroLabel16.Text = "NOMBRE ";
            // 
            // metroTextBoxFiltro
            // 
            // 
            // 
            // 
            this.metroTextBoxFiltro.CustomButton.Image = null;
            this.metroTextBoxFiltro.CustomButton.Location = new System.Drawing.Point(250, 1);
            this.metroTextBoxFiltro.CustomButton.Name = "";
            this.metroTextBoxFiltro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxFiltro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxFiltro.CustomButton.TabIndex = 1;
            this.metroTextBoxFiltro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxFiltro.CustomButton.UseSelectable = true;
            this.metroTextBoxFiltro.CustomButton.Visible = false;
            this.metroTextBoxFiltro.Lines = new string[0];
            this.metroTextBoxFiltro.Location = new System.Drawing.Point(3, 22);
            this.metroTextBoxFiltro.MaxLength = 32767;
            this.metroTextBoxFiltro.Name = "metroTextBoxFiltro";
            this.metroTextBoxFiltro.PasswordChar = '\0';
            this.metroTextBoxFiltro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFiltro.SelectedText = "";
            this.metroTextBoxFiltro.SelectionLength = 0;
            this.metroTextBoxFiltro.SelectionStart = 0;
            this.metroTextBoxFiltro.ShortcutsEnabled = true;
            this.metroTextBoxFiltro.Size = new System.Drawing.Size(272, 23);
            this.metroTextBoxFiltro.TabIndex = 16;
            this.metroTextBoxFiltro.UseSelectable = true;
            this.metroTextBoxFiltro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxFiltro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxFiltro.TextChanged += new System.EventHandler(this.metroTextBoxNombre_TextChanged);
            // 
            // metroButtonAgregarPago
            // 
            this.metroButtonAgregarPago.BackgroundImage = global::ErpGestion.Properties.Resources.if_18_330400;
            this.metroButtonAgregarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonAgregarPago.Location = new System.Drawing.Point(707, 3);
            this.metroButtonAgregarPago.Name = "metroButtonAgregarPago";
            this.metroButtonAgregarPago.Size = new System.Drawing.Size(42, 43);
            this.metroButtonAgregarPago.TabIndex = 30;
            this.metroButtonAgregarPago.UseSelectable = true;
            this.metroButtonAgregarPago.Click += new System.EventHandler(this.metroButtonAgregarPago_Click);
            // 
            // AdminCuentaCorrienteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "AdminCuentaCorrienteForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Administración Cuentas Corrientes";
            this.Load += new System.EventHandler(this.AdminCuentaCorrienteForm_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridCuenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceCuenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid metroGridCuenta;
        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxFiltro;
        private System.Windows.Forms.BindingSource bindingSourceCuenta;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Razon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
        private MetroFramework.Controls.MetroButton metroButtonAgregarPago;
    }
}