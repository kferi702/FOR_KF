using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR.Modell
{
    class ConnectionData
    {
        public Database connection()
        {
            Database mysql = new Database();
            mysql.setConnServer("localhost","forproba","3306","none");
            mysql.setConnUser("root", "");
            mysql.makeConn();
            return mysql;
        }
    }
}
