using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornekproje
{
    class StockDao
    {
        SqlConnection _connection = new SqlConnection(@"server=(localdb)\MSSQLLocalDB;initial catalog=Product;integrated security=true");
        public List<Stock> GetAll()
        {
            
            
           
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }

            SqlCommand command = new SqlCommand(" select * from Stock ",_connection);

            SqlDataReader reader = command.ExecuteReader();

            List<Stock> stocks = new List<Stock>();

            while (reader.Read())
            {
                Stock stock = new Stock
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString(),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                stocks.Add(stock);
            }

            reader.Close();
            _connection.Close();

            return stocks;

        }

        public DataTable GetAll2()
        {
           
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }
            SqlCommand command = new SqlCommand(" select * from Stock ", _connection);

            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);
            reader.Close();
            _connection.Close();
            return dataTable;

        }

        public void Add(Stock stock)
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }

            SqlCommand command = new SqlCommand("Insert into Stock values(@name,@stockAmount)", _connection);
            command.Parameters.AddWithValue("@name", stock.Name);
            command.Parameters.AddWithValue("@stockAmount", stock.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void Update(Stock stock)
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }

            SqlCommand command = new SqlCommand("Update Stock set Name=@name, StockAmount=@stockAmount where Id=@id", _connection);
            command.Parameters.AddWithValue("@name", stock.Name);
            command.Parameters.AddWithValue("@stockAmount", stock.StockAmount);
            command.Parameters.AddWithValue("@id", stock.Id);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void Delete(int id)
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();

            }

            SqlCommand command = new SqlCommand("Delete from Stock where Id=@id", _connection);

            command.Parameters.AddWithValue("@id",id);
            command.ExecuteNonQuery();

            _connection.Close();

        }


    }

}
