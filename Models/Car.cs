using System;

namespace Dealership.Models 
{
  public class Car
  {
    public int Price { get; set; }
    public int Miles { get; set; }
    public string MakeModel { get; set; }

    public bool HadAccident { get; }
    public Car(string makeModel, int price, int miles, bool hadAccident)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
      HadAccident = hadAccident;
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    // public Car(string makeModel, int price, int miles)
    // {
    //   _makeModel = makeModel;
    //   _price = price;
    //   _miles = miles;
    // }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price < maxPrice);
    }
    public static string MakeSound(string sound)
    {
        return "Our cars sound like " + sound;
    }

  }
}
