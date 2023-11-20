namespace Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock {  get; set; }
        public double PurchasePrice { get; set; }
        public double Profit {  get; set; }
        public double Sellprice 
        {
            get
            {
                return Math.Round(PurchasePrice * (1 + Profit / 100),2);
            }
                 
        }

    }
}