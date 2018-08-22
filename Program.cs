using System.Collections.Generic;
using System;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();

            (string product, double amount, int quantity) hammer = ("hammer", 19.99, 20);
            (string product, double amount, int quantity) nails = ("nails", .99, 200);
            (string product, double amount, int quantity) stapleGun = ("staple gun", 30.99, 10);

            transactions.Add(hammer);
            transactions.Add(nails);
            transactions.Add(stapleGun);

            double TotalRevenue = 0;
            int TotalProductsSold = 0;

            foreach ((string product, double amount, int quantity) i in transactions)
            {
                TotalProductsSold += i.quantity;
                TotalRevenue += i.amount;
            }

            Console.WriteLine($"We sold {TotalProductsSold} products for a revenue of ${TotalRevenue}");
        }
    }
}
