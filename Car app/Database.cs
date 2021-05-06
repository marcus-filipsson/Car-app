﻿using System;
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

            dbConn = new SQLiteConnection("DataSource=" + databaseFilename);
        }

        public void OpenConnection()
        {
            if (dbConn.State != System.Data.ConnectionState.Closed)
            {
                dbConn.Close();
            }
        }


            public void CloseConnection()
            {
                    if (dbConn.State != System.Data.ConnectionState.Closed)
                    {
                         dbConn.Close();
                    }
            }


        public int AddRow(Car car)
        {
            string qInsert = "Insert Into car ('regNr','maid','model','year','forSale',) VALUES (@regNr, @maid,@model,@year,@forSale);";

            SQLiteCommand dbCommand = new SQLiteCommand(qInsert, dbConn);
            OpenConnection();


            dbCommand.Parameters.AddWithValue(@"regNr", car.GetRegNr());
            dbCommand.Parameters.AddWithValue(@"maid", car.GetMake());
            dbCommand.Parameters.AddWithValue(@"model", car.GetModel());
            dbCommand.Parameters.AddWithValue(@"year", car.GetYear());

            dbCommand.Parameters.AddWithValue(@"forSale", (car.GetForSale() ? 1 : 0));

            int result = dbCommand.ExecuteNonQuery();
            CloseConnection();
            return result;
            

        }
        public List<Car> GetRowsFromCars()
        {
            List<Car> listOfCars = new List<Car>();
            string qSelect = "SELECT * FROM car;";

            SQLiteCommand dbCommand = new SQLiteCommand(qSelect, dbConn);
            OpenConnection();
            SQLiteDataReader res = dbCommand.ExecuteReader();
            if (res.HasRows)
            {
                while( res.Read())
                {
                    Car car = new Car(Convert.ToString(res["regNr"]),
                        Convert.ToString(res["maid"]),
                        Convert.ToString(res["model"]),
                        Convert.ToInt32(res["year"]),
                        Convert.ToBoolean(res["forSale"]));
                    listOfCars.Add(car);
                }

            }
            CloseConnection();
            return listOfCars;

        }
        internal int RemoveCarRowByRegNr(string regNr)
        {
            string qDelete = "DELETE FROM car WHERE regNr = @regNr;";
            SQLiteCommand dbCommand = new SQLiteCommand(qDelete, dbConn);
            OpenConnection();

            dbCommand.Parameters.AddWithValue(@"regNr", regNr);

            int result = dbCommand.ExecuteNonQuery();
            CloseConnection();
            return result;
        }

        public int RemoveAllCars()
        {
            string qDelete = "DELETE FROM car;";
            SQLiteCommand dbCommand = new SQLiteCommand(qDelete, dbConn);
            OpenConnection();

            int result = dbCommand.ExecuteNonQuery();
            CloseConnection();
            return result;
        }










    }
    
}
