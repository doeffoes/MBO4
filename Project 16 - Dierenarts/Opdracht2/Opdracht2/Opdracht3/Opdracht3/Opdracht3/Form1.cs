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

namespace Opdracht3
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

        private void OverzichtRecepten(string ReceptId)
        {
            lbxOverzicht.Items.Clear();
            OleDbConnection con = new OleDbConnection();
            Globaal.Connection.Open();
            OleDbDataReader dbread = null;
            string sql = "select * from Recept WHERE ReceptId = @ReceptId";
            OleDbCommand dbcom = new OleDbCommand(sql, Globaal.Connection);
            OleDbParameter param1 = new OleDbParameter();
            param1.ParameterName = "@ReceptId";
            param1.Value = ReceptId;
            dbcom.Parameters.Add(param1);
            dbread = dbcom.ExecuteReader();
            while (dbread.Read())
            {
                // lbxOverzicht.Items.Add(dbread.GetValue(1).ToString());

                lbxOverzicht.Items.Add(dbread["Naam recept"].ToString());
            }
            dbread.Close();
            Globaal.Connection.Close();
        }

        private void btnWoonplaats_Click(object sender, EventArgs e)
        {
            OverzichtRecepten(txtWoonplaats.Text);
        }
    }
}
