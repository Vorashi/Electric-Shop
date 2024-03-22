using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace mainPage
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GPMHDR2\SQLEXPRESS;Initial Catalog=SystemShop;Integrated Security=True");

        /// <summary>
        /// Метод открывает соединение с БД
        /// </summary>
        public void openConnection() 
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed) 
            {
                sqlConnection.Open();
            }
        }

        /// <summary>
        /// Метод закрывает соединение с БД
        /// </summary>
        public void closeConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) 
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Метод для подключения к выбранной БД
        /// </summary>
        public SqlConnection getConnection() 
        {
            return sqlConnection;
        }
    }
}
