using Manager.Enums;
using Manager.Model;
using Manager.Services;
using System.Data.SqlTypes;

namespace Manager
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int input;
            SongServices songServices = new SongServices();

            do
            {

                Console.WriteLine("1.Create Song");
                Console.WriteLine("2.Get all Songs");
                Console.WriteLine("3.Update songs");
                Console.WriteLine("4.Delete song");

                bool convert = int.TryParse(Console.ReadLine(), out input);

                if (convert)
                {
                    switch (input)
                    {
                        case 1:
                            Console.WriteLine("song name: ");
                            string songName = Console.ReadLine();

                            Console.WriteLine("artist name: ");
                            List<string> artistName = new List<string>();

                            Console.WriteLine("genre: ");
                            string genre = Console.ReadLine();
                            Enum.TryParse(genre, out Genres type);

                            Console.WriteLine("duration: ");
                            int duration = Convert.ToInt32(Console.ReadLine());

                            Song song = new Song(songName, artistName, type, duration);

                            songServices.CreateMusic(song);

                            break;

                        case 2:
                            var getAll =  songServices.GetAllSongs();

                            foreach (var item in getAll)
                            {
                                Console.WriteLine($"{item.SongName} {item.ArtisName} {item.Genre} {item.Duration}");
                            }

                            break;

                        case 3:
                            Console.WriteLine("id: ");
                            int id = Convert.ToInt32(Console.ReadLine());

                            Song song1 = null;
                            songServices.UpdateSongs(id, song1);
                            break;
                        case 4:
                            Console.WriteLine("id: ");
                            int deleteID = Convert.ToInt32(Console.ReadLine());
                            songServices.DeleteSong(deleteID);
                            break;

                    }
                }

            }
            while (input != 0);
        }
    }
}
