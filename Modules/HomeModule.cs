using Nancy;
using CarSearch.Object;
using System.Collections.Generic;

namespace CarSearch
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["daelership.cshtml"];
      Post["/Car_entry"] = _ = {
        Car newCar = new Car(Request.Form["Model"], Request.Form["Price"],Request.Form["Miles"]);
        newCar.Saves();
        return View["dealership.cshtml"];
      };

      Get["/stock"] = _ => {
        List<Car> allCars = Car.GetAll();
        return View["stock.cshtml", allCars];
      };
    }
  }
}









 //this is project w/o form

// Car firstCar = new Car("Acura", 10000, 10000);
// Car secondCar = new Car("Bmw", 20000, 50000);
// Car thirdCar = new Car("Benz", 30000, 5000);
// "hello world";
// };




// Car newCar = new Car("Acura", 1500, 10000);
// Car newCarTwo = new Car("Honda", 1500, 10000);
// newCar.Save();
