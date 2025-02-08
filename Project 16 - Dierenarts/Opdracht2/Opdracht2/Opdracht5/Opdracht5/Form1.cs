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

namespace Opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // maken verbinding
            OleDbConnection con = new OleDbConnection();
            globaal.Connection.Open();

            // opstellen query
            string sql = "SELECT COUNT(*) FROM Categorie";
            string sql2 = "SELECT COUNT(*) FROM Recept";
            string sql3 = "SELECT COUNT(*) FROM Recept HAVING Bereidingstijd <= 30";

            // uitvoeren query
            OleDbCommand dbcom = new OleDbCommand(sql, globaal.Connection);
            OleDbCommand dbcom2 = new OleDbCommand(sql2, globaal.Connection);
            OleDbCommand dbcom3 = new OleDbCommand(sql3, globaal.Connection);

            // lezen gegevens uit database
            textBox1.Text = dbcom.ExecuteScalar().ToString();
            textBox2.Text = dbcom2.ExecuteScalar().ToString();
            textBox3.Text = dbcom3.ExecuteScalar().ToString();

            // sluiten verbinding
            globaal.Connection.Close();
        }

        private void Overzichtklanten()
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
