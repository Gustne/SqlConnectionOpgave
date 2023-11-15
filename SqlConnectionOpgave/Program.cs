﻿

using BuisnessLogic;
using Models;
using System.Security.AccessControl;

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


item1.Description = "AppelsinLikør der virkelig kan noget";
item1.Profit = 255.12;

Console.WriteLine(itemBL.Update(item1));


Console.WriteLine(itemBL.Delete(item1.Id));

Console.WriteLine(itemBL.Create(item1));