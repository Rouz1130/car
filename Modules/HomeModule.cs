using Nancy;
using CarSearch.Object;
using System.Collections.Generic;

namespace CarSearch
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        // Car firstCar = new Car("Acura", 10000, 10000);
        // Car secondCar = new Car("Bmw", 20000, 50000);
        // Car thirdCar = new Car("Benz", 30000, 5000);
        // "hello world";
        return View["dealership.cshtml"];
      };

      Get["/page2"] = _ => {
        Car newCar = new Car("Acura", 1500, 10000);
        Car newCarTwo = new Car("Honda", 1500, 10000);
        newCar.Save();
        List<Car> allCars = Car.GetAll();
        return View["page2.cshtml", allCars];
      };

    }
  }
}
