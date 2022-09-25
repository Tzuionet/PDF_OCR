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

        private void pbKonvertieren_Click(object sender, EventArgs e)
        {
            int anzPDF = 10;

            if (anzPDF == 0)
            {
                lbAktuellePDF.Text = "Keine PDFs im Ordner";
            }
            else
            {
                progressBar.Maximum = anzPDF;

                for (int i = 0; i < anzPDF; i++)
                {
                    progressBar.Value = i + 1;
                    Thread.Sleep(1000);
                }

                progressBar.Value = 0;
                lbAktuellePDF.Text = "Erledigt.";
            }
        }
    }
}
