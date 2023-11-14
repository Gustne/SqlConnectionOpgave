using DataAccess;
using Models;


namespace BuisnessLogic
{
    public class ItemBL
    {
        ItemDA db;

        public ItemBL()
        {
            db = new ItemDA();
        }



        
        public List<Item> Get()
        {
            return db.Get();
        }

        public Item Get(int id)
        {
            return db.Get(id);
        }


    }
}