using System;

public class RetailSalesPerson : Salesman, SelfDeveloping
{
  public RetailSalesPerson(string firstName, string lastName) : base(firstName, lastName)
  {
  }

  public override void Sell()
  {
    Console.WriteLine(String.Format("Hi my name is {0}, I recommend You to buy this pen!", this.FullName));
  }

  public void Develop()
  {
    Console.WriteLine("I develop...");
  }  
}