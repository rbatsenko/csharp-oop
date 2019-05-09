using System;

namespace oop
{
    class Program
    {
        static void Main(string[] args)
        {
            RetailSalesPerson erik = new RetailSalesPerson("Erik", "Erikson");
            Console.WriteLine(erik.FullName);
            erik.Sell();
            erik.Develop();

            WebDeveloper john = new WebDeveloper("React");
            john.Code();
            john.Develop();
        }
    }
}
