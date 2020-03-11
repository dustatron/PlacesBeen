
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller
  {
    //index
    [HttpGet("/places")]
    public ActionResult PlacesIndex()
    {
      List<Places> showList = Places.Trips;
      return View(showList);
    }

    //New
    [HttpGet("/places/new")]
    public ActionResult New()
    {

      return View();
    }

    //Create
    [HttpPost("/places/create")]
    public ActionResult Create(string name, string picture, string stayLength, string timeTravel)
    {
      Places place = new Places(name, picture, stayLength, timeTravel);
      return RedirectToAction("PlacesIndex");
    }

    //Show
    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Places place = Places.Find(id);
      return View(place);
    }

    //Edit form
    [HttpGet("/places/{id}/edit")]
    public ActionResult Edit(int id)
    {
      Places place = Places.Find(id);
      return View(place);
    }

    //Update
    [HttpPost("/places/{id}")]
    public ActionResult Update(int id, string name, string picture, string stayLength, string timeTravel)
    {
      Places.UpdatePlace(id, name, picture, stayLength, timeTravel);
      return RedirectToAction("PlacesIndex");
    }

    //Destroy
    [HttpPost("/places/delete/{id}")]
    public ActionResult Delete(int id)
    {
      Places.DeletePlace(id);
      return View();
    }
  }

}