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

        public bool Create(Item item)
        {
            return db.Create(item);
        }

        public bool Update(Item item)
        {
            return db.Update(item);
        }

        public bool Delete(int id)
        {
            return db.Delete(id);
        }


    }
}