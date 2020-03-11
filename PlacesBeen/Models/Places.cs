using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Places
  {
    public static List<Places> Trips { get; set; } = new List<Places>();

    public string Name { get; set; }

    public string Picture { get; set; }

    public string StayLength { get; set; }

    public string TravelTime { get; set; }
    public int Id { get; set; }

    public Places(string name, string picture, string stayLength, string timeTravel)
    {
      Name = name;
      Picture = picture;
      StayLength = stayLength;
      TravelTime = timeTravel;
      Id = Trips.Count + 1;
      Trips.Add(this);
    }
    public static void ClearAll()
    {
      Trips.Clear();
    }

    public static Places Find(int id)
    {
      return Places.Trips[id - 1];
    }

    public static void DeletePlace(int id)
    {
      Trips.RemoveAt(id - 1);
    }

    public static void UpdatePlace(int id, string name, string picture, string stayLength, string timeTravel)
    {
      Places place = Trips[id - 1];
      place.Name = name;
      place.Picture = picture;
      place.StayLength = stayLength;
      place.TravelTime = timeTravel;

    }


  }
}