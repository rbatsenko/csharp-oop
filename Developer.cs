using System;

public abstract class Developer
{
  private string _mainDevLanguage;

  public Developer( string mainDevLanguage )
  {
    this._mainDevLanguage = mainDevLanguage;
  }

  public virtual void Code()
  {
    Console.WriteLine(String.Format("I code in {0}.", this._mainDevLanguage));
  }

  public virtual void Code(string firstExtraDevLanguage)
  {
    Console.WriteLine(String.Format("I code in {0} and I also use {1}.", this._mainDevLanguage, firstExtraDevLanguage));
  }

  public virtual void Code(string firstExtraDevLanguage, string secondExtraDevLanguage)
  {
    Console.WriteLine(String.Format("I code in {0} and I also use {1} and {2}.", this._mainDevLanguage, firstExtraDevLanguage, secondExtraDevLanguage));
  }
}