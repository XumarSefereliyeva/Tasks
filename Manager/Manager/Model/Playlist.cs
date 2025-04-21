using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager.Model;

public  class Playlist
{ 
    private int _id;
    public int Id { get; set; }
    public string PlayListName { get; set; }
    public static List<Song> Songs { get; set; }

   public Playlist(int id,  string playListName,List<Song> songs)
    {
        Id = id;
        PlayListName = playListName;
        Songs = songs;
    }
}
