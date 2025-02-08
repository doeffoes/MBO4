
namespace project17
{
    partial class Dashboard
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
            this.lblAantalArtikelen = new System.Windows.Forms.Label();
            this.txtAantalArtikelen = new System.Windows.Forms.TextBox();
            this.txtAantalBestellingen = new System.Windows.Forms.TextBox();
            this.lblAantalBestellingen = new System.Windows.Forms.Label();
            this.txtAantalKlanten = new System.Windows.Forms.TextBox();
            this.lblAantalKlanten = new System.Windows.Forms.Label();
            this.txtTotaalPrijs = new System.Windows.Forms.TextBox();
            this.lblTotaalPrijs = new System.Windows.Forms.Label();
            this.txtMinPrijs = new System.Windows.Forms.TextBox();
            this.lblMinPrijs = new System.Windows.Forms.Label();
            this.txtMaxPrijs = new System.Windows.Forms.TextBox();
            this.lblMaxPrijs = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.lblReservering = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAantalArtikelen
            // 
            this.lblAantalArtikelen.AutoSize = true;
            this.lblAantalArtikelen.Location = new System.Drawing.Point(6, 47);
            this.lblAantalArtikelen.Name = "lblAantalArtikelen";
            this.lblAantalArtikelen.Size = new System.Drawing.Size(80, 13);
            this.lblAantalArtikelen.TabIndex = 0;
            this.lblAantalArtikelen.Text = "Aantal artikelen";
            this.lblAantalArtikelen.Click += new System.EventHandler(this.lblAantalArtikelen_Click);
            // 
            // txtAantalArtikelen
            // 
            this.txtAantalArtikelen.Location = new System.Drawing.Point(126, 44);
            this.txtAantalArtikelen.Name = "txtAantalArtikelen";
            this.txtAantalArtikelen.ReadOnly = true;
            this.txtAantalArtikelen.Size = new System.Drawing.Size(100, 20);
            this.txtAantalArtikelen.TabIndex = 1;
            this.txtAantalArtikelen.TextChanged += new System.EventHandler(this.txtAantalArtikelen_TextChanged);
            // 
            // txtAantalBestellingen
            // 
            this.txtAantalBestellingen.Location = new System.Drawing.Point(126, 70);
            this.txtAantalBestellingen.Name = "txtAantalBestellingen";
            this.txtAantalBestellingen.ReadOnly = true;
            this.txtAantalBestellingen.Size = new System.Drawing.Size(100, 20);
            this.txtAantalBestellingen.TabIndex = 3;
            this.txtAantalBestellingen.TextChanged += new System.EventHandler(this.txtAantalBestellingen_TextChanged);
            // 
            // lblAantalBestellingen
            // 
            this.lblAantalBestellingen.AutoSize = true;
            this.lblAantalBestellingen.Location = new System.Drawing.Point(6, 73);
            this.lblAantalBestellingen.Name = "lblAantalBestellingen";
            this.lblAantalBestellingen.Size = new System.Drawing.Size(96, 13);
            this.lblAantalBestellingen.TabIndex = 2;
            this.lblAantalBestellingen.Text = "Aantal bestellingen";
            this.lblAantalBestellingen.Click += new System.EventHandler(this.lblAantalBestellingen_Click);
            // 
            // txtAantalKlanten
            // 
            this.txtAantalKlanten.Location = new System.Drawing.Point(126, 96);
            this.txtAantalKlanten.Name = "txtAantalKlanten";
            this.txtAantalKlanten.ReadOnly = true;
            this.txtAantalKlanten.Size = new System.Drawing.Size(100, 20);
            this.txtAantalKlanten.TabIndex = 5;
            this.txtAantalKlanten.TextChanged += new System.EventHandler(this.txtAantalKlanten_TextChanged);
            // 
            // lblAantalKlanten
            // 
            this.lblAantalKlanten.AutoSize = true;
            this.lblAantalKlanten.Location = new System.Drawing.Point(6, 99);
            this.lblAantalKlanten.Name = "lblAantalKlanten";
            this.lblAantalKlanten.Size = new System.Drawing.Size(75, 13);
            this.lblAantalKlanten.TabIndex = 4;
            this.lblAantalKlanten.Text = "Aantal klanten";
            this.lblAantalKlanten.Click += new System.EventHandler(this.lblAantalKlanten_Click);
            // 
            // txtTotaalPrijs
            // 
            this.txtTotaalPrijs.Location = new System.Drawing.Point(126, 122);
            this.txtTotaalPrijs.Name = "txtTotaalPrijs";
            this.txtTotaalPrijs.ReadOnly = true;
            this.txtTotaalPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtTotaalPrijs.TabIndex = 7;
            this.txtTotaalPrijs.TextChanged += new System.EventHandler(this.txtTotaalPrijs_TextChanged);
            // 
            // lblTotaalPrijs
            // 
            this.lblTotaalPrijs.AutoSize = true;
            this.lblTotaalPrijs.Location = new System.Drawing.Point(6, 125);
            this.lblTotaalPrijs.Name = "lblTotaalPrijs";
            this.lblTotaalPrijs.Size = new System.Drawing.Size(103, 13);
            this.lblTotaalPrijs.TabIndex = 6;
            this.lblTotaalPrijs.Text = "Totale bestelwaarde";
            this.lblTotaalPrijs.Click += new System.EventHandler(this.lblTotaalPrijs_Click);
            // 
            // txtMinPrijs
            // 
            this.txtMinPrijs.Location = new System.Drawing.Point(126, 148);
            this.txtMinPrijs.Name = "txtMinPrijs";
            this.txtMinPrijs.ReadOnly = true;
            this.txtMinPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtMinPrijs.TabIndex = 9;
            this.txtMinPrijs.TextChanged += new System.EventHandler(this.txtMinPrijs_TextChanged);
            // 
            // lblMinPrijs
            // 
            this.lblMinPrijs.AutoSize = true;
            this.lblMinPrijs.Location = new System.Drawing.Point(6, 151);
            this.lblMinPrijs.Name = "lblMinPrijs";
            this.lblMinPrijs.Size = new System.Drawing.Size(114, 13);
            this.lblMinPrijs.TabIndex = 8;
            this.lblMinPrijs.Text = "Minimale bestelwaarde";
            this.lblMinPrijs.Click += new System.EventHandler(this.lblMinPrijs_Click);
            // 
            // txtMaxPrijs
            // 
            this.txtMaxPrijs.Location = new System.Drawing.Point(126, 174);
            this.txtMaxPrijs.Name = "txtMaxPrijs";
            this.txtMaxPrijs.ReadOnly = true;
            this.txtMaxPrijs.Size = new System.Drawing.Size(100, 20);
            this.txtMaxPrijs.TabIndex = 11;
            this.txtMaxPrijs.TextChanged += new System.EventHandler(this.txtMaxPrijs_TextChanged);
            // 
            // lblMaxPrijs
            // 
            this.lblMaxPrijs.AutoSize = true;
            this.lblMaxPrijs.Location = new System.Drawing.Point(6, 177);
            this.lblMaxPrijs.Name = "lblMaxPrijs";
            this.lblMaxPrijs.Size = new System.Drawing.Size(117, 13);
            this.lblMaxPrijs.TabIndex = 10;
            this.lblMaxPrijs.Text = "Maximale bestelwaarde";
            this.lblMaxPrijs.Click += new System.EventHandler(this.lblMaxPrijs_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Location = new System.Drawing.Point(50, 13);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(59, 13);
            this.lblDashboard.TabIndex = 12;
            this.lblDashboard.Text = "Dashboard";
            // 
            // lblReservering
            // 
            this.lblReservering.AutoSize = true;
            this.lblReservering.Location = new System.Drawing.Point(123, 13);
            this.lblReservering.Name = "lblReservering";
            this.lblReservering.Size = new System.Drawing.Size(64, 13);
            this.lblReservering.TabIndex = 13;
            this.lblReservering.Text = "Reservering";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 205);
            this.Controls.Add(this.lblReservering);
            this.Controls.Add(this.lblDashboard);
            this.Controls.Add(this.txtMaxPrijs);
            this.Controls.Add(this.lblMaxPrijs);
            this.Controls.Add(this.txtMinPrijs);
            this.Controls.Add(this.lblMinPrijs);
            this.Controls.Add(this.txtTotaalPrijs);
            this.Controls.Add(this.lblTotaalPrijs);
            this.Controls.Add(this.txtAantalKlanten);
            this.Controls.Add(this.lblAantalKlanten);
            this.Controls.Add(this.txtAantalBestellingen);
            this.Controls.Add(this.lblAantalBestellingen);
            this.Controls.Add(this.txtAantalArtikelen);
            this.Controls.Add(this.lblAantalArtikelen);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAantalArtikelen;
        private System.Windows.Forms.TextBox txtAantalArtikelen;
        private System.Windows.Forms.TextBox txtAantalBestellingen;
        private System.Windows.Forms.Label lblAantalBestellingen;
        private System.Windows.Forms.TextBox txtAantalKlanten;
        private System.Windows.Forms.Label lblAantalKlanten;
        private System.Windows.Forms.TextBox txtTotaalPrijs;
        private System.Windows.Forms.Label lblTotaalPrijs;
        private System.Windows.Forms.TextBox txtMinPrijs;
        private System.Windows.Forms.Label lblMinPrijs;
        private System.Windows.Forms.TextBox txtMaxPrijs;
        private System.Windows.Forms.Label lblMaxPrijs;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label lblReservering;
    }
}