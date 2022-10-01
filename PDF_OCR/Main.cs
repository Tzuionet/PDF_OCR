using System;
using System.Diagnostics;
using System.IO;

namespace PDF_OCR
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void pbEinstellungen_Click(object sender, EventArgs e)
        {
            var frm = new Einstellungen();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Width = this.Width;
            frm.Height = this.Height;
            frm.BackColor = this.BackColor;
            frm.Font = this.Font;
            frm.AutoScaleDimensions = this.AutoScaleDimensions;
            frm.AutoScaleMode = this.AutoScaleMode;
            frm.ClientSize = this.ClientSize;
            frm.FormBorderStyle = this.FormBorderStyle;
            frm.MaximizeBox = this.MaximizeBox;
            frm.Show();
            this.Hide();
        }

        private async void pbKonvertieren_Click(object sender, EventArgs e)
        {
            String exePath = Properties.Settings.Default["PDF24EXE"].ToString();
            String pdfFolder = Properties.Settings.Default["Quellordner"].ToString();
            String ocrFolder = Properties.Settings.Default["Zielordner"].ToString();
            String orgFolder = pdfFolder + "\\Konvertierte Dateien\\";
            bool error = false;

            if (!File.Exists(exePath))
            {
                lbAktuellePDF.Text = "pdf24-Ocr.exe nicht gefunden!";
            }
            else if (!Directory.Exists(pdfFolder))
            {
                lbAktuellePDF.Text = "Quellordner nicht gefunden!";
            }
            else if (!Directory.Exists(ocrFolder))
            {
                lbAktuellePDF.Text = "Zielordner nicht gefunden!";
            }
            else
            {
                try
                {
                    string[] files = Directory.GetFiles(pdfFolder, "*.pdf");

                    if (files.Length == 0)
                    {
                        lbAktuellePDF.Text = "Keine PDFs im Ordner";
                    }
                    else
                    {
                        lbAktuellePDF.Text = "Konvertierung läuft ...";
                        progressBar.Maximum = files.Length * 100 + 25;
                        foreach (String file in files)
                        {
                            String filename = file.Split('\\').Last();
                            progressBar.Value = progressBar.Value + 100;
                            lbAktuellePDF.Text = "Konvertiere " + filename + " ...";

                            Process p = new Process();
                            p.StartInfo.FileName = exePath;
                            //Handbuch: https://creator.pdf24.org/manual/11/
                            p.StartInfo.Arguments = @"/K -file " + file + " -outputFile " + ocrFolder + filename + " -language deu -dpi 300 -autoRotatePages -deskew";
                            p.Start();
                            //await Task.Run => Verhindert das GUI geblockt wird
                            await Task.Run(() => p.WaitForExit());

                            #region Datei verschieben
                            if (!Directory.Exists(orgFolder))
                            {
                                Directory.CreateDirectory(orgFolder);
                            }

                            //File.Move(pdfFolder + filename, orgFolder + filename);
                            #endregion
                        }
                    }
                }
                catch (Exception ex)
                {
                    error = true;
                }

                lbAktuellePDF.Text = error ? "Fehler beim Konvertieren;" : "Erledigt.";
                progressBar.Value = 0;
            }
        }
    }
}
