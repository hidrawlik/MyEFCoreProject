using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;
using BuildingMaterialsStoresWebApi.DAL.Interfaces;

namespace BuildingMaterialsStoresWebApi.DAL.Infrastructure
{
    public class ConnectionFactory : IConnectionFactory
    {
        private static string _connectionString;

        public void SetConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection GetSqlConnection
        {
            get
            {
                SqlConnection connection;

                if (!string.IsNullOrEmpty(_connectionString))
                {
                    connection = new SqlConnection(_connectionString);
                }
                else
                {
                    connection = new SqlConnection(MyConnection.ConnectionString);
                    //connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);   
                }

                connection.Open();

                return connection;
            }
        }
    }
}
