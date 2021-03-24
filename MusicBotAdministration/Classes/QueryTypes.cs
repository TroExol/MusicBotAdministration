using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicBotAdministration.Classes
{
    public class QueryTypes
    {
        // Список типов запросов
        private List<QueryType> _queryTypesList = new List<QueryType>();

        public List<QueryType> QueryTypesList
        {
            get => _queryTypesList;
            set
            {
                _queryTypesList = value;
                // Выполнить делегат при изменении списка
                OnSet?.Invoke(this, null);
            }
        }

        // Делегат при изменении списка
        public event EventHandler OnSet;

        // Делегат при добавлении в список
        public event EventHandler OnAdd;

        public QueryTypes(EventHandler onSet, EventHandler onAdd)
        {
            OnSet += onSet;
            OnAdd += onAdd;
        }

        // Добавление в список
        public void Add(QueryType queryType)
        {
            QueryTypesList.Add(queryType);
            OnAdd?.Invoke(this, null);
        }

        // Получение данных о типах запросов
        public static List<QueryType> GetData()
        {
            var queryTypesFromDb = DbConnector.Read("ТипЗапроса",
                    "Не удалось получить данные о типах запросов")
                .Select(queryType =>
                {
                    var id = Convert.ToInt32(queryType["ID"]);
                    var name = queryType["Название"].ToString();
                    
                    return new QueryType(id, name);
                }).ToList();

            return queryTypesFromDb;
        }
    }

    public class QueryType
    {
        public int Id { get; set; }

        // Название типа запроса
        public string Name { get; set; }

        public QueryType(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}