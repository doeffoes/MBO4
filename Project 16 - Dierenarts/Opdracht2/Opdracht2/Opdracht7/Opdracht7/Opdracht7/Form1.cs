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

namespace Opdracht7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            string woord = lbxOverzicht.SelectedItem.ToString();
            string[] woordenArray = woord.Split(' ');
            int klantid = int.Parse(woordenArray[0]);
            LadenKlantDetails(klantid);
        }

        private void btnNieuweKlant_Click(object sender, EventArgs e)
        {
            FrmKlantInvoer frm = new FrmKlantInvoer();
            frm.ShowDialog();
        }

        public void WijzigKlantgegevens(int klantid)
        {
            globaal.Connection.Open();
            OleDbConnection con = new OleDbConnection();
            string sql = "UPDATE Klanten SET Voorletters = @Voorletters, " +
                "Tussenvoegsel = @Tussenvoegsel, Achternaam = @Achternaam, " +
                "Straat = @Straat, Huisnummer = @Huisnummer, Postcode = @Postcode, " +
                "Woonplaats = @Woonplaats, Telefoon = @Telefoon WHERE klantid = " +
                "@klantid";
            OleDbCommand dbcom = new OleDbCommand(sql, globaal.Connection);
            dbcom.Parameters.AddWithValue("@Voorletters", txtVoorletters.Text);
            dbcom.Parameters.AddWithValue("@Tussenvoegsel", txtVoorvoegsel.Text);
            dbcom.Parameters.AddWithValue("@Achternaam", txtAchternaam.Text);
            dbcom.Parameters.AddWithValue("@Straat", txtStraat.Text);
            dbcom.Parameters.AddWithValue("@Huisnummer", txtHuisnummer.Text);
            dbcom.Parameters.AddWithValue("@tHuisnummer", txtTHuisnummer.Text);
            dbcom.Parameters.AddWithValue("@Postcode", txtPostcode.Text);
            dbcom.Parameters.AddWithValue("@Woonplaats", txtWoonplaats.Text);
            dbcom.Parameters.AddWithValue("@Telefoon", txtWoonplaats.Text);
            dbcom.Parameters.AddWithValue("@klantid", klantid);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            globaal.Connection.Close();
            MessageBox.Show("Gewijzigd");
        }

        public void LeesGegevens()
        {
            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            globaal.Connection.Open();
            string sql = "SELECT * FROM klanten";
            OleDbCommand dbcom = new OleDbCommand(sql, globaal.Connection);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                lbxOverzicht.Items.Add(dbread.GetValue(0).ToString() + " "
                    + dbread.GetValue(1).ToString() + " " +
                    dbread.GetValue(2).ToString() + " " +
                    dbread.GetValue(3).ToString());
            }
            dbread.Close();
            dbcom.Dispose();
            globaal.Connection.Close();

        }

        private void LadenKlantDetails(int klantid)
        {

            OleDbDataReader dbread = null;
            OleDbConnection con = new OleDbConnection();
            globaal.Connection.Open();
            string sql = "SELECT * FROM klanten WHERE klantid = @klantid";
            OleDbCommand dbcom = new OleDbCommand(sql, globaal.Connection);
            OleDbParameter param1 = new OleDbParameter();
            param1.ParameterName = "@klantid";
            param1.Value = klantid;
            dbcom.Parameters.Add(param1);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                txtVoorletters.Text = dbread.GetValue(1).ToString();
                txtVoorvoegsel.Text = dbread.GetValue(2).ToString();
                txtAchternaam.Text = dbread.GetValue(3).ToString();
                txtStraat.Text = dbread.GetValue(4).ToString();
                txtHuisnummer.Text = dbread.GetValue(5).ToString();
                txtWoonplaats.Text = dbread.GetValue(6).ToString();
                txtPostcode.Text = dbread.GetValue(7).ToString();
                txtWoonplaats.Text = dbread.GetValue(8).ToString();
                txtTelefoon.Text = dbread.GetValue(9).ToString();
            }
            dbread.Close();
            dbcom.Dispose();
            globaal.Connection.Close();


        }

    }
}
