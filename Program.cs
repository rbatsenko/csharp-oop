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

            CarSalesman erik = new CarSalesman("Erik", "Erikson");
            Console.WriteLine(erik.FullName);
            erik.Sell();
        }
    }
}
