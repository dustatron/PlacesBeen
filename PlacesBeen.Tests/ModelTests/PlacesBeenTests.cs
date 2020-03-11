using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.ModelTests
{
  [TestClass]
  public class PlacesTest : IDisposable
  {
    public void Dispose()
    {
      Places.ClearAll();
    }
    [TestMethod]
    public void PlacesConstructor_CreatesInstanceOfPlaces_Places()
    {
      Places newPlace = new Places("name", "picture", "staylength", "time traveled");
      Assert.AreEqual(typeof(Places), newPlace.GetType());
    }

    [TestMethod]
    public void PlacesConstructor_AddingToTheList_List()
    {
      Places newPlace = new Places("name", "picture", "staylength", "time traveled");
      List<Places> TestList = new List<Places>() { newPlace };
      CollectionAssert.AreEqual(TestList, Places.Trips);
    }

    [TestMethod]
    public void DeletePlace_WillDeletePlaceFromList_List()
    {
      Places place1 = new Places("name", "picture", "staylength", "time traveled");
      Places place2 = new Places("name", "picture", "staylength", "time traveled");
      List<Places> TestList = new List<Places>() { place2 };

      Places.DeletePlace(1);

      CollectionAssert.AreEqual(TestList, Places.Trips);

    }

    [TestMethod]
    public void UpdatePlace_WillUpdatePlaceDetailsInList_Places()
    {
      Places place1 = new Places("Johnny", "picture", "staylength", "time traveled");
      Places place2 = new Places("name", "picture", "staylength", "time traveled");

      string testName = "testName";

      Console.WriteLine("after the set from obj " + Places.Trips[0].Name);

      Places.UpdatePlace(1, "testName", "picture", "staylength", "time traveled");

      Assert.AreEqual(testName, Places.Trips[0].Name);

    }
  }
}