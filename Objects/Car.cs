using System;
using System.Collections.Generic;

namespace CarSearch.Object
{
  public class Car
  {
    private string _model;
    private int _price;
    private int _miles;

    public Car(string newModel, int newPrice, int newMiles)
    {
      _model = newModel;
      _price = newPrice;
      _miles = newMiles;
    }

    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string newModel)
    {
      _model = newModel;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int newPrice)
    {
      _price = newPrice;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetMiles(int newMiles)
    {
      _miles = newMiles;
    }
  }
}



// public class Program
// {
//   public static void Main()
//   {
//     Car firstCar = new Car("Acura", 10000, 10000);
//     Car secondCar = new Car("Bmw", 20000, 25000);
//     Car thirdCar = new Car("Benz", 30000, 5000);
//
//
//     List<Car> Cars = new List<Car>() { Acura, Bmw, Benz};
//
//     Console.WriteLine("Enter maximum price: ");
//     string stringMaxPrice = Console.ReadLine();
//     int maxPrice = int.Parse(stringMaxPrice);
//
//     Console.WriteLine("Enter maximum miles: ");
//     string stringMaxMiles = Console.ReadLine();
//     int maxMiles = int.Parse(stringMaxMiles);
//
//     List<Car> CarsMatchingSearch = new List<Car>(0);
//
//     foreach (Car automobile in Cars)
//     {
//       if (automobile.Price < maxPrice && automobile.Miles < maxMiles)
//       {
//         CarsMatchingSearch.Add(automobile);
//       }
//     }
//
//     foreach(Car automobile in CarsMatchingSearch)
//     {
//       Console.WriteLine(automobile.MakeModel);
//     }
//   }
// }
