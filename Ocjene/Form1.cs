using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ocjene
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double s = 0;
        double prosjek;

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string uv = "";
            if ((nudIndeks.Value >= 1) && (nudIndeks.Value <= 4)) {
                uv = "Nizak UV indeks";
            }
            else if ((nudIndeks.Value >= 5) && (nudIndeks.Value <= 8)) {
                uv = "Umjeren UV indeks";
            }
            
            else if (nudIndeks.Value >= 9) {
                uv = "Visok UV indeks";
            }


            string tlak = "";
            if (rbVisok.Checked) {
                tlak = "Visok tlak";
            }
            else {
                tlak = "Nizak tlak";
            }



            if (txtTemperatura.Text == "")
            {
                MessageBox.Show("Niste unijeli temperaturu!", "Upozorenje");
            }
            else { 

                lbMjerenja.Items.Add(
                    dtpDatum.Value.ToShortDateString() + " - " +
                    txtTemperatura.Text + " C - " +
                    uv + " - " + 
                    tlak + " - " +
                    cbVjetar.Text
                    );

                //izračun prosječne temperature
                s += Convert.ToDouble(txtTemperatura.Text);
                // lblZbroj.Text = s.ToString();
                prosjek = s / lbMjerenja.Items.Count;
                lblProsjek.Text = "Prosječna temperatura iznosi " + prosjek.ToString("0.00") + " celzijevih stupnjeva";

                //reset
                txtTemperatura.Text = "";
                txtTemperatura.Focus();
                cbVjetar.ResetText();
                nudIndeks.Value = 1;


            }
          
          
        }

        private void zatvoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            while (lbMjerenja.SelectedItems.Count > 0)
            {
                lbMjerenja.Items.Remove(lbMjerenja.SelectedItems[0]);
            }
        }

        private void oAutoruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ivan Horvat", "Podaci o autoru", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
