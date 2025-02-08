using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Opdracht6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInvoeren_Click(object sender, EventArgs e)
        {
            string voorletters = txtVoorletters.Text;
            string voorvoegsel = txtVoorvoegsel.Text;
            string achternaam = txtAchternaam.Text;
            string straat = txtStraat.Text;
            int huisnummer = int.Parse(txtHuisnummer.Text);
            string tHuisnummer = txtTHuisnummer.Text;
            string postcode = txtPostcode.Text;
            string woonplaats = txtWoonplaats.Text;
            string telefoon = txtTelefoon.Text;

            OleDbConnection con = new OleDbConnection();
            globaal.Connection.Open();
            string sql1 = "INSERT INTO Klanten (Voorletters,Tussenvoegsel," +
                "Achternaam,Straat,Huisnummer,[Toevoeging_huisnummer]," +
                "Postcode,Woonplaats,Telefoon) VALUES (@Voorletters, " +
                "@Tussenvoegsel, @Achternaam,@Straat, @Huisnummer, " +
                "@tHuisnummer, @Postcode, @Woonplaats, @Telefoon )";
            OleDbCommand dbcom2 = new OleDbCommand(sql1, globaal.Connection);
            dbcom2.Parameters.AddWithValue("@Voorletters", voorletters);
            dbcom2.Parameters.AddWithValue("@Tussenvoegsel", voorvoegsel);
            dbcom2.Parameters.AddWithValue("@Achternaam", achternaam);
            dbcom2.Parameters.AddWithValue("@Straat", straat);
            dbcom2.Parameters.AddWithValue("@Huisnummer", huisnummer);
            dbcom2.Parameters.AddWithValue("@tHuisnummer", tHuisnummer);
            dbcom2.Parameters.AddWithValue("@Postcode", postcode);
            dbcom2.Parameters.AddWithValue("@Woonplaats", woonplaats);
            dbcom2.Parameters.AddWithValue("@Telefoon", telefoon);
            dbcom2.ExecuteNonQuery();
            dbcom2.Dispose();
            globaal.Connection.Close();
            MessageBox.Show("Ingevoerd");
            this.Close();
            Form1.ActiveForm.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
