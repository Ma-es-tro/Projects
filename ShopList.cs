using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int decision;
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        Console.WriteLine("Enter a list of items, quantities, and costs separated by commas:");
        Console.WriteLine("1 to add");
        Console.WriteLine("Press enter to Total");

        decision = int.Parse(Console.ReadLine());

        List<Item> itemList = new List<Item>();

        if (decision == 1)
        {
            Console.WriteLine("Enter the list of items, quantities, and costs in the format: Item1,Quantity1,Cost1;Item2,Quantity2,Cost2;...");
            string groceriesInput = Console.ReadLine();

            string[] itemsArray = groceriesInput.Split(';');

            foreach (var itemDescription in itemsArray)
            {
                string[] parts = itemDescription.Split(',');

                if (parts.Length == 3)
                {
                    string itemName = parts[0].Trim();
                    int quantity = int.Parse(parts[1].Trim());
                    decimal cost = decimal.Parse(parts[2].Trim());

                    Item item = new Item(itemName, quantity, cost);
                    itemList.Add(item);
                }
                else
                {
                    Console.WriteLine("Invalid input format for an item. Please use the correct format.");
                }
            }

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                StringBuilder allItemsStringBuilder = new StringBuilder();
                foreach (var item in itemList)
                {
                    allItemsStringBuilder.Append(item.Name).Append(", ");
                }
                string allItems = allItemsStringBuilder.ToString().TrimEnd(',', ' ');

                Console.WriteLine($"All items: {allItems}");


                decimal total = 0;
                foreach (var item in itemList)
                {
                    total += item.Quantity * item.Cost;
                }

                Console.WriteLine($"Total cost of items: {total}");
            }
        }
        Console.ReadLine();
    }
}

struct Item
{
    public string Name { get; }
    public int Quantity { get; }
    public decimal Cost { get; }

    public Item(string name, int quantity, decimal cost)
    {
        Name = name;
        Quantity = quantity;
        Cost = cost;
    }
}
