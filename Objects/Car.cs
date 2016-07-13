using System;
using System.Collections.Generic;

namespace CarSearch.Object
{
  public class Car
  {
    private string _model;
    private int _price;
    private int _miles;
    private static List<Car> listOfAllOfOurCars = new List<Car> {};

    public Car(string Model, int Price, int Miles)
    {
      _model = Model;
      _price = Price;
      _miles = Miles;
    }

    public string GetModel()
    {
      return _model;
    }
    public void SetModel(string Model)
    {
      _model = Model;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int Price)
    {
      _price = Price;
    }

    public int GetMiles()
    {
      return _miles;
    }

    public void SetMiles(int Miles)
    {
      _miles = Miles;
    }

    public static List<Car> GetAll()
    {
      return _listOfAllOfOurCars;
    }

    public void Save()
    {
      _listOfAllOfOurCars.Add(this);
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
