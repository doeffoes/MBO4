using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Opdracht5
{
    class globaal
    {
        // vaste connectie naar database
        public static OleDbConnection Connection = new OleDbConnection
            (@"Provider=Microsoft.ACE.OLEDB.12.0;
            data source = ..\\..\\..\\Recepten.accdb ; 
            Persist Security Info=False;");
    }
}
