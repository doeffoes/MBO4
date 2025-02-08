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


namespace ProjectBluebird
{
    public partial class Form1 : Form
    {
        OleDbDataReader dr;
        private static string _cs = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BluebirdDB.accdb";
        public Form1()
        {
            InitializeComponent();
            string q = "SELECT * FROM Reserveringen";
            using (OleDbConnection conn = new OleDbConnection(_cs))
            {
                OleDbCommand cmd = new OleDbCommand(q, conn);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        listBox1.Items.Add(dr[1].ToString() + " " + dr[3].ToString());
                    }
                }
                conn.Close();
            }
        }

private void listboxrefresh()
    {
        listBox1.Items.Clear();
        string q = "SELECT * FROM Reserveringen";
        using (OleDbConnection conn = new OleDbConnection(_cs))
        {
            OleDbCommand cmd = new OleDbCommand(q, conn);
            conn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[1].ToString() + " " + dr[3].ToString());
                }
            }
            conn.Close();
        }
    }
private void button1_Click(object sender, EventArgs e)
        {
            string stoelclass = null;
            if (firstButton.Checked)
            {
                stoelclass = "Firstclass";
            }
            else if (busButton.Checked)
            {
                stoelclass = "Businessclass";
            }
            else if (ecoButton.Checked)
            {
                stoelclass = "Economyclass";
            }

            string stoelselected = stoelSelected.Text;
            string naam = naamInput.Text;
            string q = "UPDATE Reserveringen SET CurrentValue = '" + naam + "' WHERE StoelNummer ='" + stoelselected + "' and Klasse = '" + stoelclass + "' and CurrentValue = 'Vrij'";
            using(OleDbConnection conn = new OleDbConnection(_cs))
            {
                OleDbCommand cmd = new OleDbCommand(q, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            listboxrefresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string stoelselected = stoelSelected.Text;
            string q = "UPDATE Reserveringen SET CurrentValue = 'Vrij' where StoelNummer = '" + stoelselected + "'";
            using (OleDbConnection conn = new OleDbConnection(_cs))
            {
                OleDbCommand cmd = new OleDbCommand(q, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            listboxrefresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void stoelSelected_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void filter_class(string classname) {
            stoelSelected.Items.Clear();
            string query = $"select * from Reserveringen where Klasse = '{classname}'";
            using (OleDbConnection conn = new OleDbConnection(_cs))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(query, conn);
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    stoelSelected.Items.Add(reader[1]);
                }

                reader.Close();
                cmd.Dispose();
                conn.Close();
            }
        }


        private void firstButton_CheckedChanged(object sender, EventArgs e)
        {
            filter_class("Firstclass");
        }
        private void busButton_CheckedChanged(object sender, EventArgs e)
        {
            filter_class("Businessclass");
        }
        private void ecoButton_CheckedChanged(object sender, EventArgs e)
        {
            filter_class("Economyclass");
        }
    }
}
