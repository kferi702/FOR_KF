using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR.Model
{
    class MySqlConnectionDatabase
    {
        public MySqlComm connection()
        {
            MySqlComm mysql = new MySqlComm();
            mysql.setConnServer("localhost","forproba","3306","none");
            mysql.setConnUser("root", "");
            mysql.makeConn();
            return mysql;
        }
    }
}
