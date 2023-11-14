
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
            List<Item> items = new List<Item>();
            string command = "Select *, Purchaseprice * (1+(Profit/100)) AS Salesprice from Items";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlcommand = new SqlCommand(command, dbConn);
            dbConn.Open();
            using SqlDataReader reader = sqlcommand.ExecuteReader();
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
            dbConn.Close();

            return items;
        }

        public Item Get(int id)
        {
            Item item = new Item();
            string command = "Select *, Purchaseprice * (1+(Profit/100)) AS Salesprice from Items where Id = @ID";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlcommand = new SqlCommand(command, dbConn);
            sqlcommand.Parameters.AddWithValue("@ID", id);
            dbConn.Open();
            using SqlDataReader reader = sqlcommand.ExecuteReader();
            while (reader.Read())
            {

                item.Id = (int)reader["Id"];
                item.Name = (string)reader["Itemname"];
                item.Description = (string)reader["Itemdescription"];
                item.Stock = (int)reader["Stock"];
                item.PurchasePrice = (double)reader["Purchaseprice"];
                item.Profit = (double)reader["Profit"];
                item.Sellprice = (double)reader["Salesprice"];

            }
            dbConn.Close();

            return item;
        }


    }
}