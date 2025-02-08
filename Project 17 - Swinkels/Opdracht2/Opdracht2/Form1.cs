using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;


namespace Opdracht2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=swinkels.accdb");
            OleDbCommand cmd = con.CreateCommand();
            OleDbDataReader dr;

            //SQL
            //voorbeeld: string student = "SELECT * FROM Student";

            string klanten = "SELECT COUNT (klantnr) FROM klanten";
            string artikelen = "SELECT COUNT (artikelnr) FROM artikelen";
            string bestellingen = "SELECT COUNT (Klantnr) FROM bestelling";
            string rekenbestellingen = "SELECT SUM (prijs) FROM artikelen";

            //DatabaseConnectieklanten:

            cmd.CommandText = klanten;
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    klantenText.Text = dr[0].ToString();
                }
            }
            dr.Close();

            //DatabaseArtikelen

            cmd.CommandText = artikelen;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    artikelenText.Text = dr[0].ToString();
                }
            }
            dr.Close();

            //DatabaseBestellingen

            cmd.CommandText = bestellingen;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    bestellingenText.Text = dr[0].ToString();
                }
            }
            dr.Close();

            //DatabaseBestellingenRekenen

            cmd.CommandText = rekenbestellingen;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    bestellingenreken.Text = dr[0].ToString();
                }
            }
            dr.Close();

            //Selecteren toprow van tabel artikelen

            cmd.CommandText = "SELECT TOP 1 prijs FROM artikelen";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    upperRow.Text = dr[0].ToString();
                }
            }
            dr.Close();

            //Selecteren Midden van tabel artikelen

            cmd.CommandText = "SELECT TOP 4 prijs FROM artikelen";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    middleRow.Text = dr[0].ToString();
                }
            }
            dr.Close();
            con.Close();
        }
    }
}
