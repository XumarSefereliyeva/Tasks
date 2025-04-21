using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Manager.Model;
namespace Manager.Services;

public class SongServices
{
    private static List<Song> songs = new List<Song>();
 
    public void CreateMusic(Song song)
    {
        songs.Add(song);
        Console.WriteLine("elave olundu");
    }
    public List<Song> GetAllSongs()
    {
        return songs;
    }
    public void UpdateSongs(int id, Song updateSong)
    {
        foreach(var item in songs)
        {
            if (item.Id == id)
            {
                item.SongName = updateSong.SongName;
                item.ArtisName = updateSong.ArtisName;
                item.Genre = updateSong.Genre;
                item.Duration = updateSong.Duration;
            }
        }

        throw new Exception("update olmadi");
    }
    public void DeleteSong(int id)
    {
       foreach(Song item in songs)
        {
            if(item.Id == id)
            {
                songs.Remove(item);
                Console.WriteLine("silindi");
            }
        }
    }
}
