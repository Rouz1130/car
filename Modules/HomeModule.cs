using Nancy;
using CarSearch.Object;
using System.Collections.Generic;

namespace CarSearch
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["new_car_form.cshtml"];

      Post["/Car_entry"] = _ => {
        Car newCar = new Car(Request.Form["Model"], Request.Form["Price"],Request.Form["Miles"]);
        newCar.Save();
        return View["new_car_confirmation.cshtml", newCar];
      };

      Get["/stock"] = _ => {
        var allCars = Car.GetAll();
        return View["show_inventory.cshtml", allCars];
      };
    }
  }
}
