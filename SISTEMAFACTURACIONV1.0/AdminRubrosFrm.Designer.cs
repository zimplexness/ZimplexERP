namespace ErpGestion
{
    partial class AdminRubrosFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroGridRubro = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxRubro = new MetroFramework.Controls.MetroTextBox();
            this.IdRubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rubros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.metroGridRubro)).BeginInit();
            this.SuspendLayout();
            // 
            // metroGridRubro
            // 
            this.metroGridRubro.AllowUserToAddRows = false;
            this.metroGridRubro.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridRubro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGridRubro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGridRubro.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridRubro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGridRubro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGridRubro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRubro,
            this.Rubros});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGridRubro.DefaultCellStyle = dataGridViewCellStyle5;
            this.metroGridRubro.EnableHeadersVisualStyles = false;
            this.metroGridRubro.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGridRubro.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGridRubro.Location = new System.Drawing.Point(14, 112);
            this.metroGridRubro.Name = "metroGridRubro";
            this.metroGridRubro.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGridRubro.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.metroGridRubro.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGridRubro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGridRubro.ShowEditingIcon = false;
            this.metroGridRubro.Size = new System.Drawing.Size(329, 210);
            this.metroGridRubro.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroGridRubro.TabIndex = 29;
            this.metroGridRubro.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGridRubro.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(14, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 19);
            this.metroLabel1.TabIndex = 31;
            this.metroLabel1.Text = "RUBROS";
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
            this.metroTextBoxRubro.Location = new System.Drawing.Point(14, 82);
            this.metroTextBoxRubro.MaxLength = 32767;
            this.metroTextBoxRubro.Name = "metroTextBoxRubro";
            this.metroTextBoxRubro.PasswordChar = '\0';
            this.metroTextBoxRubro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxRubro.SelectedText = "";
            this.metroTextBoxRubro.SelectionLength = 0;
            this.metroTextBoxRubro.SelectionStart = 0;
            this.metroTextBoxRubro.ShortcutsEnabled = true;
            this.metroTextBoxRubro.Size = new System.Drawing.Size(245, 23);
            this.metroTextBoxRubro.TabIndex = 30;
            this.metroTextBoxRubro.UseSelectable = true;
            this.metroTextBoxRubro.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxRubro.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxRubro.TextChanged += new System.EventHandler(this.metroTextBoxRubro_TextChanged);
            // 
            // IdRubro
            // 
            this.IdRubro.HeaderText = "ID";
            this.IdRubro.Name = "IdRubro";
            this.IdRubro.Width = 50;
            // 
            // Rubros
            // 
            this.Rubros.HeaderText = "Rubros";
            this.Rubros.Name = "Rubros";
            this.Rubros.Width = 200;
            // 
            // AdminRubrosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 335);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroTextBoxRubro);
            this.Controls.Add(this.metroGridRubro);
            this.Name = "AdminRubrosFrm";
            this.Text = "Rubros";
            this.Load += new System.EventHandler(this.AdminRubrosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroGridRubro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid metroGridRubro;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBoxRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRubro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rubros;
    }
}