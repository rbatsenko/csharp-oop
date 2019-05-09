using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            CarSalesman steveTheSalesman = new CarSalesman("Steve", "Rogers");
            Console.WriteLine(steveTheSalesman.FullName);
            steveTheSalesman.Sell();

            RetailSalesPerson erik = new RetailSalesPerson("Erik", "Erikson");
            Console.WriteLine(erik.FullName);
            erik.Sell();
        }
    }
}
