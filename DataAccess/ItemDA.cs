
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

        //constructor der henter forbindelsesstreng fra app.config fil
        public ItemDA() 
        {
            connString = ConfigurationManager.ConnectionStrings["MySqlServer"].ConnectionString;

        }


        public List<Item> Get()
        {

            string command = "SELECT * FROM items";
            using SqlConnection dbConn = new SqlConnection(connString);
            SqlCommand sqlcommand = new SqlCommand(command, dbConn);
            
            return LoadData(sqlcommand,dbConn);
        }

        public Item Get(int id)
        {
            string command = "Select * FROM items where Iditem = @ID";
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
                    item.Id = (int)reader["Iditem"];
                    item.Name = (string)reader["Itemname"];
                    item.Description = (string)reader["Itemdescription"];
                    item.Stock = (int)reader["Stock"];
                    item.PurchasePrice = (double)reader["Purchaseprice"];
                    item.Profit = (double)reader["Profit"];

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

        public bool Create(Item item)
        {
            using SqlConnection dbConn = new SqlConnection(connString);

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
            }
            string command = "INSERT INTO Items (Itemname, Itemdescription, Stock, Purchaseprice, Profit) Values (@Itemname , @ItemDescription , @Stock , @PurchasePrice , @Profit )";
            using SqlCommand sqlcommand = new SqlCommand(command, dbConn);
            sqlcommand.Parameters.AddWithValue("@Itemname", item.Name);
            sqlcommand.Parameters.AddWithValue("@ItemDescription", item.Description);
            sqlcommand.Parameters.AddWithValue("@Stock",item.Stock);
            sqlcommand.Parameters.AddWithValue("@PurchasePrice",item.PurchasePrice);
            sqlcommand.Parameters.AddWithValue("@Profit",item.Profit);


            int res = 0;
            try
            {
                res = sqlcommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                Console.WriteLine("fejlede at udfører SQL query");
            }

            if (res == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        public bool Update(Item item)
        {
            using SqlConnection dbConn = new SqlConnection(connString);

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
            }
            string command = "Update Items set Itemname = @Itemname, Itemdescription = @Itemdescription, Stock = @Stock, Purchaseprice = @PurchasePrice, Profit = @Profit where IDitem = @ID";
            using SqlCommand sqlcommand = new SqlCommand(command, dbConn);
            sqlcommand.Parameters.AddWithValue("@Itemname", item.Name);
            sqlcommand.Parameters.AddWithValue("@ItemDescription", item.Description);
            sqlcommand.Parameters.AddWithValue("@Stock", item.Stock);
            sqlcommand.Parameters.AddWithValue("@PurchasePrice", item.PurchasePrice);
            sqlcommand.Parameters.AddWithValue("@Profit", item.Profit);
            sqlcommand.Parameters.AddWithValue("@ID", item.Id);


            int res = 0;
            try
            {
                res = sqlcommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                Console.WriteLine("fejlede at udfører SQL query");
            }

            if (res == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

        public bool Delete(int id)
        {
            using SqlConnection dbConn = new SqlConnection(connString);

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
            }
            string command = "delete FROM items where IDitem = @ID";
            using SqlCommand sqlcommand = new SqlCommand(command, dbConn);
            sqlcommand.Parameters.AddWithValue("@ID", id);
            

            int res = 0;
            try
            {
                res = sqlcommand.ExecuteNonQuery();
            }
            catch (Exception)
            {

                Console.WriteLine("fejlede at udfører SQL query");
            }

            if (res == 0)
            {
                return false;
            }
            else
            {
                return true;
            }


        }

    }
}