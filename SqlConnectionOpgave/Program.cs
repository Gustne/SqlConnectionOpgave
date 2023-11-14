

using BuisnessLogic;
using Models;


ItemBL itemBL = new ItemBL();


List<Item> items = new List<Item>();

items = itemBL.Get();


foreach (Item item in items)
{

    Console.WriteLine($"ID:{item.Id} Name:{item.Name} saleprice:{item.Sellprice}");


}


Console.WriteLine();

Item item1 = itemBL.Get(10);


