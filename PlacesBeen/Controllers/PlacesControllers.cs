
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PlacesBeen.Models;

namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller
  {
    [HttpGet("/places")]
    public ActionResult PlacesIndex()
    {
      return View();
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }
  }

}