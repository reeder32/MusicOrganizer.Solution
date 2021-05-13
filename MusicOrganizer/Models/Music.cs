using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Music
  {
    public string Title { get; set; }

    private static List<Music> _instances = new List<Music> { };

    public Music(string title)
    {
      Title = title;
      _instances.Add(this);

    }

    public static List<Music> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }


  }
}