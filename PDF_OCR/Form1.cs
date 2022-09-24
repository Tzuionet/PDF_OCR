namespace PDF_OCR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pbEinstellungen_Click(object sender, EventArgs e)
        {
            lbAktuellePDF.Text = Properties.Settings.Default["DPI"].ToString();
            //Properties.Settings.Default["SomeProperty"] = "Some Value";
            //Properties.Settings.Default.Save();
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