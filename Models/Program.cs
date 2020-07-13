using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership {
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, true);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, true);
      Console.WriteLine(yugo.MakeModel);
      yugo.MakeModel = "Worst Car Ever";
      Console.WriteLine(yugo.MakeModel);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, false);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, true);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc };

      yugo.SetPrice(300);

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);

      Console.WriteLine("Would you like a car with an accident history? (y or n)");
      string userResponse = Console.ReadLine();
      userResponse.ToLower();

      List<Car> CarsMatchingSearch = new List<Car>(0);

      if (userResponse == "n")
      {
          foreach (Car automobile in Cars)
          {
            if (automobile.WorthBuying(maxPrice) && automobile.HadAccident)
            {
              CarsMatchingSearch.Add(automobile);
            }
          }
      } 
      else
      {
          foreach (Car automobile in Cars)
            {
              if (automobile.WorthBuying(maxPrice) && !automobile.HadAccident)
              {
                CarsMatchingSearch.Add(automobile);
              }
            }
      }

      if (CarsMatchingSearch == null)
      {
          Console.WriteLine("----------------------");
          Console.WriteLine("Sorry there are no vehicles matching your search.");
      }
      else
      {
          foreach (Car automobile in CarsMatchingSearch)
          {
            Console.WriteLine("----------------------");
            Console.WriteLine(automobile.GetMakeModel());
            Console.WriteLine(automobile.GetMiles() + " miles");
            Console.WriteLine("$" + automobile.GetPrice());
            Console.WriteLine("Your car is totally fine. 100% Guaranteed");
          }
      }
    }
  }
}