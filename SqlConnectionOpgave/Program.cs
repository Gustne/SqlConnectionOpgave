

using BuisnessLogic;
using Models;


ItemBL itemBL = new ItemBL();


List<Item> items = new List<Item>();

items = itemBL.Get();


foreach (Item item in items)
{

    Console.WriteLine($"ID:{item.Id} Name:{item.Name} saleprice:{Math.Round(item.Sellprice,2)}");


}


Console.WriteLine();

Item item1 = itemBL.Get(10);

Console.WriteLine($"ID: {item1.Id} Name: {item1.Name} saleprice: {Math.Round(item1.Sellprice,2)}");

