using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project17
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            laadgegevens();
        }

        void laadgegevens()
        {
            //Het maken van een connectie
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            //Totaal aantal artikelen in de tabel artikelen
            string ArtikelAantal = "SELECT COUNT(*) FROM artikelen";
            OleDbCommand comArtikelAantal = new OleDbCommand(ArtikelAantal, Globaal.Connection);

            txtAantalArtikelen.Text = comArtikelAantal.ExecuteScalar().ToString();

            //Totaal aantal bestellingen in de tabel bestellingen
            string BestellingAantal = "SELECT COUNT(*) FROM bestelling";
            OleDbCommand comBestellingAantal = new OleDbCommand(BestellingAantal, Globaal.Connection);

            txtAantalBestellingen.Text = comBestellingAantal.ExecuteScalar().ToString();

            //Hoeveelheid klanten uit de tabel klanten
            string KlantenAantal = "SELECT COUNT(*) FROM klanten";
            OleDbCommand comKlantenAantal = new OleDbCommand(KlantenAantal, Globaal.Connection);

            txtAantalKlanten.Text = comKlantenAantal.ExecuteScalar().ToString();

            //Totaalprijs van alle bestellingen uit de tabel bestellingen
            string totaalPrijs = "SELECT SUM(prijs) FROM bestelregel INNER JOIN artikelen ON bestelregel.Artikelnr = artikelen.artikelnr";

            OleDbCommand comTotaalPrijs = new OleDbCommand(totaalPrijs, Globaal.Connection);

            txtTotaalPrijs.Text = "€ " + comTotaalPrijs.ExecuteScalar().ToString();

            //Minimale bestelwaarde uit de tabel
            string minPrijs = "SELECT MIN(prijs) FROM bestelregel INNER JOIN artikelen ON bestelregel.Artikelnr = artikelen.artikelnr";

            OleDbCommand comMinPrijs = new OleDbCommand(minPrijs, Globaal.Connection);

            txtMinPrijs.Text = "€ " + comMinPrijs.ExecuteScalar().ToString();

            //Maximale bestelwaarde uit de tabel
            string MaxPrijs = "SELECT MAX(prijs) FROM bestelregel INNER JOIN artikelen ON bestelregel.Artikelnr = artikelen.artikelnr";

            OleDbCommand comMaxPrijs = new OleDbCommand(MaxPrijs, Globaal.Connection);

            txtMaxPrijs.Text = "€ " + comMaxPrijs.ExecuteScalar().ToString();

            //Het sluiten van de verbinding
            comArtikelAantal.Dispose();
            comBestellingAantal.Dispose();
            comKlantenAantal.Dispose();
            comTotaalPrijs.Dispose();
            comMinPrijs.Dispose();
            comMaxPrijs.Dispose();
            Globaal.Connection.Close();
        }

        private void lblAantalArtikelen_Click(object sender, EventArgs e)
        {

        }

        private void txtAantalArtikelen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAantalBestellingen_Click(object sender, EventArgs e)
        {

        }

        private void txtAantalBestellingen_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAantalKlanten_Click(object sender, EventArgs e)
        {

        }

        private void txtAantalKlanten_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTotaalPrijs_Click(object sender, EventArgs e)
        {

        }

        private void txtTotaalPrijs_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMinPrijs_Click(object sender, EventArgs e)
        {

        }

        private void txtMinPrijs_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMaxPrijs_Click(object sender, EventArgs e)
        {

        }

        private void txtMaxPrijs_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
