using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicBotAdministration.Classes
{
    public class Tracks
    {
        // Список подписок
        private List<Track> _tracksList = new List<Track>();

        public List<Track> TracksList
        {
            get => _tracksList;
            set
            {
                _tracksList = value;
                // Выполнить делегат при изменении списка
                OnSet?.Invoke(this, null);
            }
        }

        // Делегат при изменении списка
        public event EventHandler OnSet;

        // Делегат при добавлении в список
        public event EventHandler OnAdd;

        public Tracks(EventHandler onSet, EventHandler onAdd)
        {
            OnSet += onSet;
            OnAdd += onAdd;
        }

        // Добавление в список
        public void Add(Track track)
        {
            TracksList.Add(track);
            OnAdd?.Invoke(this, null);
        }

        // Получение данных о треках
        public static List<Track> GetData()
        {
            var tracksFromDb = DbConnector.Read("Трек",
                    "Не удалось получить данные о треках", "Трек.ID, Название, ID_Автор, Автор.ИмяАвтора",
                    "LEFT JOIN Автор ON Трек.ID_Автор = Автор.ID")
                .Select(track =>
                {
                    var id = Convert.ToInt32(track["ID"]);
                    var name = track["Название"].ToString();
                    var idAuthor = Convert.ToInt32(track["ID_Автор"]);
                    var author = track["ИмяАвтора"].ToString();
                    
                    return new Track(id, name, new Author(idAuthor, author));
                }).ToList();

            return tracksFromDb;
        }
    }

    public class Track
    {
        public int Id { get; set; }

        // Название трека
        public string Name { get; set; }

        // Имя автора
        public Author Author { get; set; }

        public Track(int id, string name, Author author)
        {
            Id = id;
            Name = name;
            Author = author;
        }
    }

    public class Author
    {
        public int Id { get; set; }

        // Имя автора
        public string Name { get; set; }

        public Author(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}