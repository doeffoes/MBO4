using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project17
{
    class Globaal
    {
        public static OleDbConnection Connection = new OleDbConnection
            (@"Provider=Microsoft.ACE.OLEDB.12.0;data source=C:\\Users\\maxsi\\Onedrive\\Bureaublad\\School\\Project 17 - Swinkels\\Swinkels\\Swinkels\\swinkels.accdb;Persist Security Info=False;");
    }
}
