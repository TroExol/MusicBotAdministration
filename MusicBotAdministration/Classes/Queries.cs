using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicBotAdministration.Classes
{
    public class Queries
    {
        // Список запросов
        private List<Query> _queriesList = new List<Query>();

        public List<Query> QueriesList
        {
            get => _queriesList;
            set
            {
                _queriesList = value;
                // Выполнить делегат при изменении списка запросов
                OnSet?.Invoke(this, null);
            }
        }

        // Делегат при изменении списка запросов
        public event EventHandler OnSet;

        // Делегат при добавлении запроса в список запросов
        public event EventHandler OnAdd;

        public Queries(EventHandler onSet, EventHandler onAdd)
        {
            OnSet += onSet;
            OnAdd += onAdd;
        }

        // Добавление запроса в список запросов
        public void Add(Query query)
        {
            QueriesList.Add(query);
            OnAdd?.Invoke(this, null);
        }

        // Получение данных о запросах
        public static List<Query> GetData()
        {
            var queriesFromDb = DbConnector.Read("Запрос",
                    "Не удалось получить данные о запросах",
                    "Запрос.ID, ДатаЗапроса, КоличествоТреков, ЗапрашиваемыйАвтор, ID_Пользователь," +
                    " Пользователь.ФамилияИмя, Пользователь.СсылкаНаVK, ID_ТипЗапроса, ТипЗапроса.Название",
                    " LEFT JOIN Пользователь ON Запрос.ID_Пользователь = Пользователь.ID" +
                    " LEFT JOIN ТипЗапроса ON Запрос.ID_ТипЗапроса = ТипЗапроса.ID")
                .Select(query =>
                {
                    var id = Convert.ToInt32(query["ID"]);
                    var date = Convert.ToDateTime(query["ДатаЗапроса"]);
                    var countTracks = Convert.ToInt32(query["КоличествоТреков"]);
                    var requiredAuthor = query["ЗапрашиваемыйАвтор"].ToString();
                    var idUser = Convert.ToInt32(query["ID_Пользователь"]);
                    var fio = query["ФамилияИмя"].ToString();
                    var url = query["СсылкаНаVK"].ToString();
                    var idQueryType = Convert.ToInt32(query["ID_ТипЗапроса"]);
                    var queryTypeName = query["Название"].ToString();

                    var tracksFromDb = DbConnector.Read("ПолученныйТрек",
                        "Не удалось получить данные о полученных треках для запроса",
                        "Трек.ID, Трек.Название, ID_Автор, Автор.ИмяАвтора",
                        $"INNER JOIN Трек ON ПолученныйТрек.ID_Трек = Трек.ID AND ПолученныйТрек.ID_Запрос = {id}" +
                        " LEFT JOIN Автор ON Трек.ID_Автор = Автор.ID");
                    var tracks = tracksFromDb
                        .Select(track =>
                            new Track(Convert.ToInt32(track["ID"]), track["Название"].ToString(),
                                new Author(Convert.ToInt32(track["ID_Автор"]), track["ИмяАвтора"].ToString())))
                        .ToList();

                    return new Query(id, date, countTracks, requiredAuthor,
                        new User(idUser, fio, url), new QueryType(idQueryType, queryTypeName), tracks);
                }).ToList();

            return queriesFromDb;
        }
    }

    public class Query
    {
        public int Id { get; set; }

        // Дата запроса
        public DateTime Date { get; set; }

        // Кол-во треков
        public int CountMusic { get; set; }

        // Запрашиваемый автор
        public string Author { get; set; }

        // Пользователь
        public User User { get; set; }

        // Тип запроса
        public QueryType QueryType { get; set; }

        // Полученные треки
        public List<Track> ReceivedTracks { get; set; }

        public Query(int id, DateTime date, int countMusic, string author,
            User user, QueryType queryType, List<Track> receivedTracks)
        {
            Id = id;
            Date = date;
            CountMusic = countMusic;
            Author = author;
            User = user;
            QueryType = queryType;
            ReceivedTracks = receivedTracks;
        }
    }
}