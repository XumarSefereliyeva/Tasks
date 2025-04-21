using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Manager.Model;
namespace Manager.Services;

public  class PlaylistServices
{
    // Playlistdəki mahnıların filterlə axtarışı(Artist adı, Mahnı adı və ya Janr)
    private static List<Playlist> _songs { get; } = new List<Playlist>();
    public void Addsong(Playlist song)
    {
        _songs.Add(song);
    }
    public List<Playlist> GetAllPlaylist()
    {
        return _songs;
    }
    public Playlist GetSongById(int id)
    {
        foreach(Playlist sng in _songs)
        {
            if (sng.Id == id)
            {
                return sng;
            }
        }
        throw new Exception("Tapilmadi");
    }
    public void UpdatePlaylist(int id,Playlist updatesong)
    {
        foreach(var item in _songs)
        {
            if (item.Id == id)
            {
                item.PlayListName = updatesong.PlayListName;
            }
        }
    }
    public void Deletesong(int id)
    {
        for(int i=0;i<_songs.Count;i++)
        {
            if (_songs[i].Id == id)
            {
                _songs.RemoveAt(i);
                break;
            }
        }
    }

}
