using PDF_OCR.Properties;

namespace PDF_OCR
{
    partial class Einstellungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Einstellungen));
            this.lbExe = new System.Windows.Forms.Label();
            this.lbQuelle = new System.Windows.Forms.Label();
            this.lbZiel = new System.Windows.Forms.Label();
            this.tbPDF24 = new System.Windows.Forms.TextBox();
            this.tbQuelle = new System.Windows.Forms.TextBox();
            this.tbZiel = new System.Windows.Forms.TextBox();
            this.pbSpeichern = new System.Windows.Forms.PictureBox();
            this.lbVersion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeichern)).BeginInit();
            this.SuspendLayout();
            // 
            // lbExe
            // 
            this.lbExe.AutoSize = true;
            this.lbExe.Font = new System.Drawing.Font("Noto Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbExe.ForeColor = System.Drawing.Color.Black;
            this.lbExe.Location = new System.Drawing.Point(12, 9);
            this.lbExe.Name = "lbExe";
            this.lbExe.Size = new System.Drawing.Size(75, 26);
            this.lbExe.TabIndex = 0;
            this.lbExe.Text = "PDF24:";
            // 
            // lbQuelle
            // 
            this.lbQuelle.AutoSize = true;
            this.lbQuelle.Font = new System.Drawing.Font("Noto Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbQuelle.ForeColor = System.Drawing.Color.Black;
            this.lbQuelle.Location = new System.Drawing.Point(12, 45);
            this.lbQuelle.Name = "lbQuelle";
            this.lbQuelle.Size = new System.Drawing.Size(128, 26);
            this.lbQuelle.TabIndex = 1;
            this.lbQuelle.Text = "Quellordner:";
            // 
            // lbZiel
            // 
            this.lbZiel.AutoSize = true;
            this.lbZiel.Font = new System.Drawing.Font("Noto Sans", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbZiel.ForeColor = System.Drawing.Color.Black;
            this.lbZiel.Location = new System.Drawing.Point(12, 81);
            this.lbZiel.Name = "lbZiel";
            this.lbZiel.Size = new System.Drawing.Size(112, 26);
            this.lbZiel.TabIndex = 2;
            this.lbZiel.Text = "Zielordner:";
            // 
            // tbPDF24
            // 
            this.tbPDF24.BackColor = System.Drawing.Color.White;
            this.tbPDF24.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPDF24.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbPDF24.ForeColor = System.Drawing.Color.Black;
            this.tbPDF24.Location = new System.Drawing.Point(150, 11);
            this.tbPDF24.Name = "tbPDF24";
            this.tbPDF24.Size = new System.Drawing.Size(329, 22);
            this.tbPDF24.TabIndex = 5;
            // 
            // tbQuelle
            // 
            this.tbQuelle.BackColor = System.Drawing.Color.White;
            this.tbQuelle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbQuelle.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQuelle.ForeColor = System.Drawing.Color.Black;
            this.tbQuelle.Location = new System.Drawing.Point(150, 48);
            this.tbQuelle.Name = "tbQuelle";
            this.tbQuelle.Size = new System.Drawing.Size(329, 22);
            this.tbQuelle.TabIndex = 6;
            // 
            // tbZiel
            // 
            this.tbZiel.BackColor = System.Drawing.Color.White;
            this.tbZiel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbZiel.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbZiel.ForeColor = System.Drawing.Color.Black;
            this.tbZiel.Location = new System.Drawing.Point(150, 84);
            this.tbZiel.Name = "tbZiel";
            this.tbZiel.Size = new System.Drawing.Size(329, 22);
            this.tbZiel.TabIndex = 7;
            // 
            // pbSpeichern
            // 
            this.pbSpeichern.Image = ((System.Drawing.Image)(resources.GetObject("pbSpeichern.Image")));
            this.pbSpeichern.Location = new System.Drawing.Point(219, 197);
            this.pbSpeichern.Name = "pbSpeichern";
            this.pbSpeichern.Size = new System.Drawing.Size(50, 50);
            this.pbSpeichern.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbSpeichern.TabIndex = 10;
            this.pbSpeichern.TabStop = false;
            this.pbSpeichern.Click += new System.EventHandler(this.pbSpeichern_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Location = new System.Drawing.Point(396, 233);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(83, 19);
            this.lbVersion.TabIndex = 11;
            this.lbVersion.Text = "Version 1.0";
            // 
            // Einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.pbSpeichern);
            this.Controls.Add(this.tbZiel);
            this.Controls.Add(this.tbQuelle);
            this.Controls.Add(this.tbPDF24);
            this.Controls.Add(this.lbZiel);
            this.Controls.Add(this.lbQuelle);
            this.Controls.Add(this.lbExe);
            this.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Einstellungen";
            this.Text = "PDF2OCR - Einstellungen";
            ((System.ComponentModel.ISupportInitialize)(this.pbSpeichern)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private void ReadSettings()
        {
            this.tbPDF24.Text = Properties.Settings.Default["PDF24EXE"].ToString();
            this.tbQuelle.Text = Properties.Settings.Default["Quellordner"].ToString();
            this.tbZiel.Text = Properties.Settings.Default["Zielordner"].ToString();
        }

        private Label lbExe;
        private Label lbQuelle;
        private Label lbZiel;
        private TextBox tbPDF24;
        private TextBox tbQuelle;
        private TextBox tbZiel;
        private PictureBox pbSpeichern;
        private Label lbVersion;
    }
}