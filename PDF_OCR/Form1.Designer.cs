using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;

namespace PDF_OCR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pbEinstellungen = new System.Windows.Forms.PictureBox();
            this.pbKonvertieren = new System.Windows.Forms.PictureBox();
            this.lbAktuellePDF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbEinstellungen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKonvertieren)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 229);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(460, 20);
            this.progressBar.TabIndex = 1;
            // 
            // pbEinstellungen
            // 
            this.pbEinstellungen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbEinstellungen.Image = ((System.Drawing.Image)(resources.GetObject("pbEinstellungen.Image")));
            this.pbEinstellungen.Location = new System.Drawing.Point(442, 12);
            this.pbEinstellungen.Name = "pbEinstellungen";
            this.pbEinstellungen.Size = new System.Drawing.Size(30, 30);
            this.pbEinstellungen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbEinstellungen.TabIndex = 2;
            this.pbEinstellungen.TabStop = false;
            this.pbEinstellungen.Click += new System.EventHandler(this.pbEinstellungen_Click);
            // 
            // pbKonvertieren
            // 
            this.pbKonvertieren.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbKonvertieren.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbKonvertieren.Image = ((System.Drawing.Image)(resources.GetObject("pbKonvertieren.Image")));
            this.pbKonvertieren.Location = new System.Drawing.Point(12, 41);
            this.pbKonvertieren.Name = "pbKonvertieren";
            this.pbKonvertieren.Size = new System.Drawing.Size(460, 130);
            this.pbKonvertieren.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbKonvertieren.TabIndex = 3;
            this.pbKonvertieren.TabStop = false;
            this.pbKonvertieren.Click += new System.EventHandler(this.pbKonvertieren_Click);
            // 
            // lbAktuellePDF
            // 
            this.lbAktuellePDF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAktuellePDF.Font = new System.Drawing.Font("Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAktuellePDF.ForeColor = System.Drawing.Color.White;
            this.lbAktuellePDF.Location = new System.Drawing.Point(12, 196);
            this.lbAktuellePDF.Name = "lbAktuellePDF";
            this.lbAktuellePDF.Size = new System.Drawing.Size(460, 22);
            this.lbAktuellePDF.TabIndex = 4;
            this.lbAktuellePDF.Text = "Aktuelle_Datei.pdf";
            this.lbAktuellePDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(80)))), ((int)(((byte)(87)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lbAktuellePDF);
            this.Controls.Add(this.pbKonvertieren);
            this.Controls.Add(this.pbEinstellungen);
            this.Controls.Add(this.progressBar);
            this.Font = new System.Drawing.Font("Noto Sans", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PDF 2 OCR";
            ((System.ComponentModel.ISupportInitialize)(this.pbEinstellungen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKonvertieren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private ProgressBar progressBar;
        private PictureBox pbEinstellungen;
        private PictureBox pbKonvertieren;
        private Label lbAktuellePDF;
    }
}