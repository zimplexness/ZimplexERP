namespace ErpGestion
{
    partial class ActividadMantenimientoForm
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
            this.metroTextBoxActividad = new MetroFramework.Controls.MetroTextBox();
            this.metroButtonAdd = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroTextBoxActividad
            // 
            // 
            // 
            // 
            this.metroTextBoxActividad.CustomButton.Image = null;
            this.metroTextBoxActividad.CustomButton.Location = new System.Drawing.Point(310, 1);
            this.metroTextBoxActividad.CustomButton.Name = "";
            this.metroTextBoxActividad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxActividad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxActividad.CustomButton.TabIndex = 1;
            this.metroTextBoxActividad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxActividad.CustomButton.UseSelectable = true;
            this.metroTextBoxActividad.CustomButton.Visible = false;
            this.metroTextBoxActividad.Lines = new string[] {
        "Descripcion de Actividad"};
            this.metroTextBoxActividad.Location = new System.Drawing.Point(8, 63);
            this.metroTextBoxActividad.MaxLength = 32767;
            this.metroTextBoxActividad.Name = "metroTextBoxActividad";
            this.metroTextBoxActividad.PasswordChar = '\0';
            this.metroTextBoxActividad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxActividad.SelectedText = "";
            this.metroTextBoxActividad.SelectionLength = 0;
            this.metroTextBoxActividad.SelectionStart = 0;
            this.metroTextBoxActividad.ShortcutsEnabled = true;
            this.metroTextBoxActividad.Size = new System.Drawing.Size(332, 23);
            this.metroTextBoxActividad.TabIndex = 0;
            this.metroTextBoxActividad.Text = "Descripcion de Actividad";
            this.metroTextBoxActividad.UseSelectable = true;
            this.metroTextBoxActividad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxActividad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBoxActividad.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroButtonAdd
            // 
            this.metroButtonAdd.BackgroundImage = global::ErpGestion.Properties.Resources._1497285414_Checkmark;
            this.metroButtonAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonAdd.Location = new System.Drawing.Point(346, 52);
            this.metroButtonAdd.Name = "metroButtonAdd";
            this.metroButtonAdd.Size = new System.Drawing.Size(49, 34);
            this.metroButtonAdd.TabIndex = 2;
            this.metroButtonAdd.UseSelectable = true;
            this.metroButtonAdd.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ActividadMantenimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 127);
            this.Controls.Add(this.metroButtonAdd);
            this.Controls.Add(this.metroTextBoxActividad);
            this.Name = "ActividadMantenimientoForm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Actividades";
            this.Load += new System.EventHandler(this.ActividadVehiculoForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox metroTextBoxActividad;
        private MetroFramework.Controls.MetroButton metroButtonAdd;
    }
}