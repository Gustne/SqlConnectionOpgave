
using Models;
using System.Configuration;
using System.Data.SqlClient;
using System.Dynamic;
using System.Security.AccessControl;

namespace DataAccess
{
    public class ItemDA
    {

        string connString;

        public ItemDA() 
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlServer"].ConnectionString;

        }


        public List<Item> Get()
        {
            string command = "Select *, Purchaseprice * (1+(Profit/100)) AS Salesprice from Items";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlcommand = new SqlCommand(command, dbConn);
            
            return LoadData(sqlcommand,dbConn);
        }

        public Item Get(int id)
        {
            string command = "Select *, Purchaseprice * (1+(Profit/100)) AS Salesprice from Items where Id = @ID";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlcommand = new SqlCommand(command, dbConn);
            sqlcommand.Parameters.AddWithValue("@ID", id);
            List<Item> output = LoadData(sqlcommand,dbConn);

            if (output.Count == 0)
            {
                return new Item();
            }
            else
            {
                return output[0];
            }

        }


        private List<Item> LoadData(SqlCommand sqlCommand, SqlConnection dbConn)
        {
            List<Item> items = new List<Item>();
            try
            {
                dbConn.Open();
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Fejl i oprettelse af forbindelse til serveren:");
                if (dbConn.State == System.Data.ConnectionState.Open)
                {
                    dbConn.Close();
                }
                return items;
            }
            try
            {
                using SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {

                    Item item = new Item();
                    item.Id = (int)reader["Id"];
                    item.Name = (string)reader["Itemname"];
                    item.Description = (string)reader["Itemdescription"];
                    item.Stock = (int)reader["Stock"];
                    item.PurchasePrice = (double)reader["Purchaseprice"];
                    item.Profit = (double)reader["Profit"];
                    item.Sellprice = (double)reader["Salesprice"];

                    items.Add(item);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fejl under læsning af data, kontroller den din query");
            }
            finally 
            {
                dbConn.Close();
            }
            return items;

        }

    }
}