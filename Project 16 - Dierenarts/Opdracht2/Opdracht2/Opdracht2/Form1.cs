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

namespace Opdracht2MericRecepten
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // maken verbinding
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();

            // opstellen query
            string sql = "SELECT * FROM Recept";

            // uitvoeren query
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            OleDbDataReader dbread = null;

            // lezen gegevens uit database
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                lbxOverzicht.Items.Add(dbread.GetValue(1).ToString()
                );
            }

            // sluiten verbinding
            dbread.Close();
            Globaal.Connection.Close();
        }
    }
}
