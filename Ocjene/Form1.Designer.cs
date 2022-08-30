namespace Ocjene
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTemperatura = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.nudIndeks = new System.Windows.Forms.NumericUpDown();
            this.rbVisok = new System.Windows.Forms.RadioButton();
            this.rbNizak = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbVjetar = new System.Windows.Forms.ComboBox();
            this.lbMjerenja = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.lblProsjek = new System.Windows.Forms.Label();
            this.lblZbroj = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aplikacijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAutoruToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zatvoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.nudIndeks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperatura (C):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mjerenja:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "UV indeks:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Datum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(285, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Vjetar:";
            // 
            // txtTemperatura
            // 
            this.txtTemperatura.Location = new System.Drawing.Point(104, 69);
            this.txtTemperatura.Name = "txtTemperatura";
            this.txtTemperatura.Size = new System.Drawing.Size(61, 20);
            this.txtTemperatura.TabIndex = 2;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(104, 31);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(153, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // nudIndeks
            // 
            this.nudIndeks.Location = new System.Drawing.Point(104, 110);
            this.nudIndeks.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudIndeks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudIndeks.Name = "nudIndeks";
            this.nudIndeks.Size = new System.Drawing.Size(61, 20);
            this.nudIndeks.TabIndex = 5;
            this.nudIndeks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rbVisok
            // 
            this.rbVisok.AutoSize = true;
            this.rbVisok.Checked = true;
            this.rbVisok.Location = new System.Drawing.Point(6, 19);
            this.rbVisok.Name = "rbVisok";
            this.rbVisok.Size = new System.Drawing.Size(51, 17);
            this.rbVisok.TabIndex = 6;
            this.rbVisok.TabStop = true;
            this.rbVisok.Text = "Visok";
            this.rbVisok.UseVisualStyleBackColor = true;
            // 
            // rbNizak
            // 
            this.rbNizak.AutoSize = true;
            this.rbNizak.Location = new System.Drawing.Point(63, 19);
            this.rbNizak.Name = "rbNizak";
            this.rbNizak.Size = new System.Drawing.Size(52, 17);
            this.rbNizak.TabIndex = 7;
            this.rbNizak.Text = "Nizak";
            this.rbNizak.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbVisok);
            this.groupBox1.Controls.Add(this.rbNizak);
            this.groupBox1.Location = new System.Drawing.Point(288, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 51);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tlak zraka:";
            // 
            // cbVjetar
            // 
            this.cbVjetar.FormattingEnabled = true;
            this.cbVjetar.Items.AddRange(new object[] {
            "Nema vjetra",
            "Slab vjetar",
            "Umjeren vjetar",
            "Jak vjetar",
            "Olujni vjetar",
            "Orkan"});
            this.cbVjetar.Location = new System.Drawing.Point(328, 109);
            this.cbVjetar.Name = "cbVjetar";
            this.cbVjetar.Size = new System.Drawing.Size(138, 21);
            this.cbVjetar.TabIndex = 9;
            // 
            // lbMjerenja
            // 
            this.lbMjerenja.FormattingEnabled = true;
            this.lbMjerenja.Location = new System.Drawing.Point(12, 238);
            this.lbMjerenja.Name = "lbMjerenja";
            this.lbMjerenja.ScrollAlwaysVisible = true;
            this.lbMjerenja.Size = new System.Drawing.Size(512, 121);
            this.lbMjerenja.TabIndex = 10;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(328, 171);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 11;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(430, 171);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(75, 23);
            this.btnObrisi.TabIndex = 11;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // lblProsjek
            // 
            this.lblProsjek.AutoSize = true;
            this.lblProsjek.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblProsjek.Location = new System.Drawing.Point(12, 376);
            this.lblProsjek.Name = "lblProsjek";
            this.lblProsjek.Size = new System.Drawing.Size(116, 13);
            this.lblProsjek.TabIndex = 12;
            this.lblProsjek.Text = "Prosječna temperatura:";
            // 
            // lblZbroj
            // 
            this.lblZbroj.AutoSize = true;
            this.lblZbroj.Location = new System.Drawing.Point(338, 461);
            this.lblZbroj.Name = "lblZbroj";
            this.lblZbroj.Size = new System.Drawing.Size(31, 13);
            this.lblZbroj.TabIndex = 12;
            this.lblZbroj.Text = "Zbroj";
            this.lblZbroj.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aplikacijaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aplikacijaToolStripMenuItem
            // 
            this.aplikacijaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oAutoruToolStripMenuItem,
            this.zatvoriToolStripMenuItem});
            this.aplikacijaToolStripMenuItem.Name = "aplikacijaToolStripMenuItem";
            this.aplikacijaToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aplikacijaToolStripMenuItem.Text = "Aplikacija";
            // 
            // oAutoruToolStripMenuItem
            // 
            this.oAutoruToolStripMenuItem.Name = "oAutoruToolStripMenuItem";
            this.oAutoruToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.oAutoruToolStripMenuItem.Text = "O autoru";
            this.oAutoruToolStripMenuItem.Click += new System.EventHandler(this.oAutoruToolStripMenuItem_Click);
            // 
            // zatvoriToolStripMenuItem
            // 
            this.zatvoriToolStripMenuItem.Name = "zatvoriToolStripMenuItem";
            this.zatvoriToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.zatvoriToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.zatvoriToolStripMenuItem.Text = "Zatvori";
            this.zatvoriToolStripMenuItem.Click += new System.EventHandler(this.zatvoriToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 408);
            this.Controls.Add(this.lblZbroj);
            this.Controls.Add(this.lblProsjek);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lbMjerenja);
            this.Controls.Add(this.cbVjetar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudIndeks);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.txtTemperatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vremenska prognoza";
            ((System.ComponentModel.ISupportInitialize)(this.nudIndeks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTemperatura;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.NumericUpDown nudIndeks;
        private System.Windows.Forms.RadioButton rbVisok;
        private System.Windows.Forms.RadioButton rbNizak;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbVjetar;
        private System.Windows.Forms.ListBox lbMjerenja;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Label lblProsjek;
        private System.Windows.Forms.Label lblZbroj;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aplikacijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAutoruToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zatvoriToolStripMenuItem;
    }
}

