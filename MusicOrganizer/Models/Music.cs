using System.Collections.Generic;

namespace MusicOrganizer.Models
{
  public class Music
  {
    public string Title { get; set; }

    public string Artist { get; set; }

    private static List<Music> _instances = new List<Music> { };

    // public Music(string title)
    // {
    //   Title = title;
    //   Artist = "";
    //   _instances.Add(this);

    // }

    // public void SetArtist(string artist)
    // {
    //   Artist = artist;
    // }

    public Music(string title)
    {
      Title = title;
      _instances.Add(this);

    }

    public Music(string title, string artist)
    {
      Title = title;
      Artist = artist;
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