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

namespace Opdracht8
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

           
        }

        private void lbxOverzicht_SelectedIndexChanged(object sender, EventArgs e)
        {
            string woord = lbxOverzicht.SelectedItem.ToString();
            string[] woordenArray = woord.Split(' ');
            int Receptid = int.Parse(woordenArray[0]);
            LadenKlantDetails(Receptid);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
           LeesGegevens();
        }
        private void LadenKlantDetails(int Receptid)
        {
                OleDbDataReader dbread = null;
                OleDbConnection con = new OleDbConnection();
                Globaal.Connection.Open();
                string sql = "SELECT * FROM Recept";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                dbread = dbcom.ExecuteReader();
                while (dbread.Read())
                {
                     dbread.GetValue(1).ToString();
                     dbread.GetValue(2).ToString();
                     dbread.GetValue(3).ToString();
                     dbread.GetValue(4).ToString();
                     dbread.GetValue(5).ToString();
                     dbread.GetValue(6).ToString();
                     dbread.GetValue(7).ToString();
                }
                dbread.Close();
                dbcom.Dispose();
                Globaal.Connection.Close();
           
             
        }
        public void LeesGegevens()
        {
                OleDbDataReader dbread = null;
                OleDbConnection con = new OleDbConnection();
                Globaal.Connection.Open();
                string sql = "SELECT * FROM Recept";
                OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
                dbread = dbcom.ExecuteReader();
                while (dbread.Read())
                {
                    lbxOverzicht.Items.Add(dbread.GetValue(0).ToString() + " " 
                       +dbread.GetValue(1).ToString() + " " + 
                        dbread.GetValue(2).ToString() + " " +
                        dbread.GetValue(3).ToString() + " " +
                        dbread.GetValue(4).ToString() + " " +
                        dbread.GetValue(5).ToString() + " " +
                        dbread.GetValue(6).ToString() + " " +
                        dbread.GetValue(7).ToString());
                }
                dbread.Close();
                dbcom.Dispose();
                Globaal.Connection.Close();
        }
        private void Form1_Shown(object sender, EventArgs e)
        {
                
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            LeesGegevens();
        }
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            string woord = lbxOverzicht.SelectedItem.ToString();
            string[] woordenArray = woord.Split(' ');
            int Receptid = int.Parse(woordenArray[0]);
            VerwijderKlantgegevens(Receptid);
        }
        public void VerwijderKlantgegevens(int Receptid)
        {
            Globaal.Connection.Open();
            OleDbConnection con = new OleDbConnection();
            string sql = "DELETE FROM Recept WHERE [Recept-id] = @Receptid";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            dbcom.Parameters.AddWithValue("@Recept-id", Receptid);
            dbcom.ExecuteNonQuery();
            dbcom.Dispose();
            Globaal.Connection.Close();
            MessageBox.Show("Verwijderd");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
