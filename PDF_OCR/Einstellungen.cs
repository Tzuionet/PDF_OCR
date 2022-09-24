﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_OCR
{
    public partial class Einstellungen : Form
    {
        public Einstellungen()
        {
            InitializeComponent();
            ReadSettings();
        }

        private void pbSpeichern_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default["PDF24EXE"] = tbPDF24.Text;
            Properties.Settings.Default["Quellordner"] = tbQuelle.Text;
            Properties.Settings.Default["Zielordner"] = tbZiel.Text;
            Properties.Settings.Default["Sprache"] = tbSprache.Text;
            Properties.Settings.Default["DPI"] = Convert.ToInt32(tbDPI.Text);
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
