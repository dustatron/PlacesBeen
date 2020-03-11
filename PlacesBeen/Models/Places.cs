using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Places
  {
    private static List<Places> Trips = new List<Places>();

    public string Name { get; set; }

    public string Picture { get; set; }

    public string StayLength { get; set; }

    public string TravelTime { get; set; }

    public Places(string name, string picture, string stayLength, string timeTravel)
    {
      Name = name;
      Picture = picture;
      StayLength = stayLength;
      TravelTime = timeTravel;
      Trips.Add(this);
    }
    public static void ClearAll()
    {
      Trips.Clear();
    }


  }
}