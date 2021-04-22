using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Car_app
{
    class Database
    {
        public SQLiteConnection dbConn;
        private string databaseFilename = "./car.db";

        public Database()
        {
            if (!File.Exists(databaseFilename))
            {
                File.Create(databaseFilename);
            }

            dbConn = new SQLiteConnection("Data Source=" + databaseFilename);
        }

        public void OpenConnection()
        {

        }
    

        
        
    }
    
}
