using System;
using System.Collections.Generic;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Salesman> salesmen = new List<Salesman>()
            {
                new CarSalesman("James", "One"),
                new CarSalesman("John", "Two"),
                new RetailSalesPerson("Mike", "Three"),
            };

            foreach (var item in salesmen)
            {
                ShowMeHowToSell(item);
            }
        }

        static void ShowMeHowToSell(Salesman salesman)
        {
            salesman.Sell();
        }
    }
}
