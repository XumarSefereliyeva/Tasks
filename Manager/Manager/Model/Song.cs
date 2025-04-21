using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.Enums;

namespace Manager.Model;

public  class Song
{
    //int Duration, => Mahnının uzunluğu(saniyə ilə)
    public static int count ;
    private static int _id = ++count;
    private Genres genre;

    public int Id { 
        get {
            return _id;
        } 
        set {
            _id = value;
        } 
    }
    public string SongName { get; set; }
    public  List<string> ArtisName { get; set; }
    public Genres Genre { get => genre; set => genre = value; }
    public int Duration { get; set; }

   public Song(string songName, List<string> artisName, Genres genre, int duration)
    {
        SongName = songName;
        ArtisName = artisName;
        Genre = genre;
        Duration = duration;
    }
}
