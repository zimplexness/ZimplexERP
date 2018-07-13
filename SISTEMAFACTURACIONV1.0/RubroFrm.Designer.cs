namespace ErpGestion
{
    partial class RubroFrm
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
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBoxNombre = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButtonAgregarPago = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.Location = new System.Drawing.Point(23, 63);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(93, 19);
            this.metroLabel16.TabIndex = 19;
            this.metroLabel16.Text = "DESCRIPCION";
            // 
            // metroTextBoxNombre
            // 
            // 
            // 
            // 
            this.metroTextBoxNombre.CustomButton.Image = null;
            this.metroTextBoxNombre.CustomButton.Location = new System.Drawing.Point(293, 1);
            this.metroTextBoxNombre.CustomButton.Name = "";
            this.metroTextBoxNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBoxNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBoxNombre.CustomButton.TabIndex = 1;
            this.metroTextBoxNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBoxNombre.CustomButton.UseSelectable = true;
            this.metroTextBoxNombre.CustomButton.Visible = false;
            this.metroTextBoxNombre.Lines = new string[0];
            this.metroTextBoxNombre.Location = new System.Drawing.Point(23, 85);
            this.metroTextBoxNombre.MaxLength = 32767;
            this.metroTextBoxNombre.Name = "metroTextBoxNombre";
            this.metroTextBoxNombre.PasswordChar = '\0';
            this.metroTextBoxNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxNombre.SelectedText = "";
            this.metroTextBoxNombre.SelectionLength = 0;
            this.metroTextBoxNombre.SelectionStart = 0;
            this.metroTextBoxNombre.ShortcutsEnabled = true;
            this.metroTextBoxNombre.Size = new System.Drawing.Size(315, 23);
            this.metroTextBoxNombre.TabIndex = 18;
            this.metroTextBoxNombre.UseSelectable = true;
            this.metroTextBoxNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBoxNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = global::ErpGestion.Properties.Resources.if_17_330399__1_;
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButton1.Location = new System.Drawing.Point(245, 114);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(42, 43);
            this.metroButton1.TabIndex = 30;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButtonAgregarPago
            // 
            this.metroButtonAgregarPago.BackgroundImage = global::ErpGestion.Properties.Resources._1497285414_Checkmark;
            this.metroButtonAgregarPago.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroButtonAgregarPago.Location = new System.Drawing.Point(293, 114);
            this.metroButtonAgregarPago.Name = "metroButtonAgregarPago";
            this.metroButtonAgregarPago.Size = new System.Drawing.Size(42, 43);
            this.metroButtonAgregarPago.TabIndex = 29;
            this.metroButtonAgregarPago.UseSelectable = true;
            this.metroButtonAgregarPago.Click += new System.EventHandler(this.metroButtonAgregarPago_Click);
            // 
            // RubroFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 192);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroButtonAgregarPago);
            this.Controls.Add(this.metroLabel16);
            this.Controls.Add(this.metroTextBoxNombre);
            this.Name = "RubroFrm";
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Rubro";
            this.Load += new System.EventHandler(this.RubroFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel16;
        private MetroFramework.Controls.MetroTextBox metroTextBoxNombre;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButtonAgregarPago;
    }
}