namespace ErpGestion
{
    partial class AdminActividadesMantenimientoForm
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRubro = new MetroFramework.Controls.MetroTextBox();
            this.metroGridActividad = new MetroFramework.Controls.MetroGrid();
            this.IdActividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actividades = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceActividad = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridActividad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(274, 87);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(119, 13);
            this.linkLabel1.TabIndex = 36;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "NUEVO ACTIVIDADES";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 55);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 35;
            this.metroLabel1.Text = "ACTIVIDADES";
            // 
            // metroTextBoxRubro
            // 
            // 
            // 
            // 
            this.metroTextBoxRubro.CustomButton.Image = null;
            this.metroTextBoxRubro.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.metroTextBoxRubro.CustomButton.Name = "";
            this.metroTextBoxRubro.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxRubro.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxRubro.CustomButton.TabIndex = 1;
            this.metroTextBoxRubro.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxRubro.CustomButton.UseSelectable = true;
            this.metroTextBoxRubro.CustomButton.Visible = false;
            this.metroTextBoxRubro.Lines = new string[0];
            this.metroTextBoxRubro.Location = new System.Drawing.Point(23, 77);
            this.metroTextBoxRubro.MaxLength = 32767;
            this.metroTextBoxRubro.Name = "metroTextBoxRubro";
            this.metroTextBoxRubro.PasswordChar = '\0';
            this.metroTextBoxRubro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRubro.SelectedText = "";
            this.metroTextBoxRubro.SelectionLength = 0;
            this.metroTextBoxRubro.SelectionStart = 0;
            this.metroTextBoxRubro.ShortcutsEnabled = true;
            this.metroTextBoxRubro.Size = new System.Drawing.Size(245, 23);
            this.metroTextBoxRubro.TabIndex = 34;
            this.metroTextBoxRubro.UseSelectable = true;
            this.metroTextBoxRubro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRubro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroGridActividad
            // 
            this.metroGridActividad.AllowUserToAddRows = false;
            this.metroGridActividad.AllowUserToResizeRows = false;
            this.metroGridActividad.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridActividad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridActividad.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridActividad.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridActividad.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGridActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdActividad,
            this.Actividades});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridActividad.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGridActividad.EnableHeadersVisualStyles = false;
            this.metroGridActividad.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridActividad.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridActividad.Location = new System.Drawing.Point(23, 107);
            this.metroGridActividad.Name = "metroGridActividad";
            this.metroGridActividad.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridActividad.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGridActividad.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridActividad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridActividad.ShowEditingIcon = false;
            this.metroGridActividad.Size = new System.Drawing.Size(394, 320);
            this.metroGridActividad.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridActividad.TabIndex = 33;
            this.metroGridActividad.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridActividad.UseStyleColors = true;
            // 
            // IdActividad
            // 
            this.IdActividad.HeaderText = "ID";
            this.IdActividad.Name = "IdActividad";
            this.IdActividad.Width = 50;
            // 
            // Actividades
            // 
            this.Actividades.HeaderText = "Actividades";
            this.Actividades.Name = "Actividades";
            this.Actividades.Width = 300;
            // 
            // AdminActividadesMantenimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxRubro);
            this.Controls.Add(this.metroGridActividad);
            this.Name = "AdminActividadesMantenimientoForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Actividades de Mantenimiento";
            this.Load += new System.EventHandler(this.AdminActividadesMantenimientoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridActividad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRubro;
        private MetroFramework.Controls.MetroGrid metroGridActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdActividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividades;
        private System.Windows.Forms.BindingSource bindingSourceActividad;
    }
}